using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsEstudoPessoal.Formularios
{
    public partial class Frm_Gerenciar_Orcamento : Form
    {

        private List<Produto> listasDeProdutosGlobal = new List<Produto>();
        private Cliente clienteGlobal = new Cliente();
        public bool formularioCarregadoViaBotaoCarregar;

        
        public Frm_Gerenciar_Orcamento()
        {
            InitializeComponent();
            Lbl_Nome_Emissor.Text = Admin.name;
            Lbl_Email_Emissor.Text = Admin.Email;
            Lbl_Telefone_Emissor.Text = Admin.telefone.ToString();
        }
        private void AtualizarClienteGlobal()
        {
            //Dados Pessoais
            clienteGlobal.Nome = Tbx_Nome_Cliente.Text;
            clienteGlobal.Email = Tbx_Email_Cliente.Text;
            clienteGlobal.Telefone = Mtbx_Telefone_Cliente.Text;
            //Dados Endereco
            clienteGlobal.Endereco.Cep = Tbx_Cep_Cliente.Text;
            clienteGlobal.Endereco.Estado = Tbx_Estado_Cliente.Text;
            clienteGlobal.Endereco.Localidade = Tbx_Localidade_Cliente.Text;
            clienteGlobal.Endereco.Logradouro = Tbx_Logradouro_Cliente.Text;
            clienteGlobal.Endereco.Bairro = Tbx_Bairro_Cliente.Text;
            //Dados Garantia
            clienteGlobal.PossuiGarantia = Cls_Uteis.RecebeNomeRadioButtonGarantia(Rbtn_SIM, Rbtn_NAO);
            clienteGlobal.FormaDePagamento = Cls_Uteis.RecebeNomeRadioButtonPagamento(Rbtn_PIX, Rbtn_Dinheiro, Rbtn_Cartao);
            clienteGlobal.Orcamento.Data = Cls_Uteis.ConverterStringParaData(Mtbx_Data_Orcamento.Text);
            clienteGlobal.Orcamento.Validade = Cls_Uteis.ConverterStringParaData(Mtbx_Validade_Orcamento.Text);
        }
        private void atualizarClienteGenerico(Cliente cliente)
        {
            this.Tbx_Nome_Cliente.Text = cliente.Nome;
            this.Tbx_Email_Cliente.Text = cliente.Email;
            this.Mtbx_Telefone_Cliente.Text = cliente.Telefone;
            this.Tbx_Cep_Cliente.Text = cliente.Endereco.Cep;
            this.Mtbx_Data_Orcamento.Text = cliente.Orcamento.Data.ToString("dd/MM/yyyy");
            this.listasDeProdutosGlobal = cliente.Produtos;
        }

        public bool CarregarCliente()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Coffebara Arquivos", "Clientes");

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    openFileDialog.InitialDirectory = path;
                    openFileDialog.Filter = "Arquivo JSON (*.json)|*.json|Todos os Arquivos (*.*)|*.*";
                    openFileDialog.Title = "Selecionar Arquivo de Cliente";

                    if (openFileDialog.ShowDialog() != DialogResult.OK)
                        return false;

                    string fileName = openFileDialog.FileName;

                    Cliente cliente = JsonConvert.DeserializeObject<Cliente>(File.ReadAllText(fileName));

                    Cls_Uteis.CarregarProdutosOrcamento(cliente, this.Pnl_Mostrar_Produtos);

                    atualizarClienteGenerico(cliente);
                    clienteGlobal = cliente;

                    Cls_Uteis.AtualizarGarantiaCliente(cliente, Rbtn_SIM, Rbtn_NAO, Mtbx_Validade_Orcamento);
                    Cls_Uteis.AtualizarRadioButtonsFormaDePagamento(cliente, Rbtn_PIX, Rbtn_Dinheiro, Rbtn_Cartao);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cliente: " + ex.Message);
                return false;
            }
        }

        private void Btn_Salvar_Orcamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cls_Uteis.VerificaTodasTextBoxes((Control)this.Tbx_Nome_Cliente, (Control)this.Mtbx_Telefone_Cliente, (Control)this.Tbx_Email_Cliente, (Control)this.Tbx_Cep_Cliente, (Control)this.Mtbx_Data_Orcamento) &&
                   Cls_Uteis.VerificaRadioButtonsGarantia(this.Rbtn_NAO, this.Rbtn_SIM) &&
                   Cls_Uteis.VerificaRadioButtonsPagamento(this.Rbtn_PIX, this.Rbtn_Dinheiro, this.Rbtn_Cartao))
                {
                    string text1 = this.Tbx_Nome_Cliente.Text;
                    string text2 = this.Mtbx_Telefone_Cliente.Text;
                    string text3 = this.Tbx_Email_Cliente.Text;

                    Endereco endereco1 = new Endereco()
                    {
                        Logradouro = this.Tbx_Logradouro_Cliente.Text,
                        Bairro = this.Tbx_Bairro_Cliente.Text,
                        Localidade = this.Tbx_Localidade_Cliente.Text,
                        Estado = this.Tbx_Estado_Cliente.Text,
                        Cep = this.Tbx_Cep_Cliente.Text
                    };

                    DateTime minValue = DateTime.MinValue;
                    string str1 = Cls_Uteis.RecebeNomeRadioButtonGarantia(this.Rbtn_SIM, this.Rbtn_NAO);
                    if (this.Rbtn_SIM.Checked)
                    {
                        minValue = DateTime.Parse(this.Mtbx_Validade_Orcamento.Text);
                        str1 = Cls_Uteis.RecebeNomeRadioButtonGarantia(this.Rbtn_SIM, this.Rbtn_NAO);
                    }

                    Orcamento orcamento1 = new Orcamento()
                    {
                        Data = DateTime.Parse(this.Mtbx_Data_Orcamento.Text),
                        Validade = minValue
                    };

                    List<Produto> deProdutosGlobal = this.listasDeProdutosGlobal;
                    string telefone = text2;
                    string email = text3;
                    Endereco endereco2 = endereco1;
                    Orcamento orcamento2 = orcamento1;
                    List<Produto> listaProdutos = deProdutosGlobal;

                    Cliente cliente = Cliente.CriarCliente(text1, telefone, email, endereco2, orcamento2, listaProdutos);
                    cliente.PossuiGarantia = str1;
                    cliente.FormaDePagamento = Cls_Uteis.RecebeNomeRadioButtonPagamento(this.Rbtn_Dinheiro, this.Rbtn_PIX, this.Rbtn_Cartao);
                    string str3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Coffebara Arquivos");
                    string path = Path.Combine(str3, "Clientes");

                    if (!Directory.Exists(str3))
                        Directory.CreateDirectory(str3);
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.InitialDirectory = path;
                        saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                        saveFileDialog.Title = "Salvar Cliente";
                        saveFileDialog.FileName = cliente.Nome + "_cliente.json";
                        if (saveFileDialog.ShowDialog() != DialogResult.OK)
                            return;

                        string contents = JsonConvert.SerializeObject((object)cliente, Formatting.Indented);
                        File.WriteAllText(saveFileDialog.FileName, contents);

                        int num = (int)MessageBox.Show("Cliente criado: " + cliente.Nome + ", Telefone: " + cliente.Telefone + "\nArquivo salvo em: " + saveFileDialog.FileName);
                    }
                }
                else
                {
                    int num1 = (int)MessageBox.Show("Por favor, preencha todos os campos e selecione as opções corretamente.");
                }
            }
            catch (FormatException ex)
            {
                int num = (int)MessageBox.Show("Ocorreu um erro de formatação: " + ex.Message);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Ocorreu um erro ao salvar o orçamento: " + ex.Message);
            }
        }


        public bool DeletarOrcamento()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Budget Coffebara", "Clientes");
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    openFileDialog.InitialDirectory = path;
                    openFileDialog.Filter = "Arquivo JSON (*.json)|*.json|Todos os Arquivos (*.*)|*.*";
                    openFileDialog.Title = "Selecionar Arquivo de Orçamento para Deletar";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = openFileDialog.FileName;
                        if (MessageBox.Show("Tem certeza que deseja deletar este orçamento?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            File.Delete(fileName);
                            int num = (int)MessageBox.Show("Orçamento deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Erro ao deletar o orçamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return false;
        }

        private void LimparFormulario(Cliente c)
        {
            try
            {
                this.Tbx_Nome_Cliente.Clear();
                this.Mtbx_Telefone_Cliente.Clear();
                this.Tbx_Email_Cliente.Clear();
                this.Tbx_Cep_Cliente.Clear();
                this.Tbx_Estado_Cliente.Clear();
                this.Tbx_Logradouro_Cliente.Clear();
                this.Tbx_Bairro_Cliente.Clear();
                this.Tbx_Localidade_Cliente.Clear();
                this.Mtbx_Data_Orcamento.Clear();
                this.Mtbx_Validade_Orcamento.Clear();

                this.Rbtn_PIX.Checked = false;
                this.Rbtn_Cartao.Checked = false;
                this.Rbtn_Dinheiro.Checked = false;
                this.Rbtn_NAO.Checked = false;
                this.Rbtn_SIM.Checked = false;

                this.Mtbx_Telefone_Cliente.BackColor = SystemColors.Window;
                this.Mtbx_Data_Orcamento.BackColor = SystemColors.Window;
                this.Tbx_Cep_Cliente.BackColor = SystemColors.Window;

                this.Pnl_Mostrar_Produtos.Controls.Clear();


                c?.Produtos.Clear();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tbx_Cep_Cliente_Leave(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.ValidaTamanhoCep(this.Tbx_Cep_Cliente.Text);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Btn_Adicionar_Produto_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeProduto = this.Tbx_Nome_Produto.Text;
                string valorProdutoTexto = this.MTbx_Valor_Produto.Text;
                double valorProduto;

                if (string.IsNullOrWhiteSpace(nomeProduto) || string.IsNullOrWhiteSpace(valorProdutoTexto) || !double.TryParse(valorProdutoTexto, out valorProduto))
                {
                    MessageBox.Show("Por favor, insira um nome válido e um valor numérico para o produto.");
                }
                else if (this.Tbx_Nome_Produto.BackColor == Color.LightGreen && this.MTbx_Valor_Produto.BackColor == Color.LightGreen)
                {
                    this.listasDeProdutosGlobal.Add(new Produto(nomeProduto, valorProduto));

                    Cls_Uteis.AdicionarProduto(nomeProduto, valorProduto, (FlowLayoutPanel)this.Pnl_Mostrar_Produtos);

                    AtualizarValorTotal();

                    this.Tbx_Nome_Produto.Clear();
                    this.MTbx_Valor_Produto.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um nome válido e um valor numérico para o produto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void AtualizarValorTotal()
        {
            double valorTotal = this.listasDeProdutosGlobal.Sum(produto => produto.Valor);

            Lbl_Total.Text = $"Valor Total: R$ {valorTotal:F2}";
        }

        private void Tbx_Nome_Cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Tbx_Nome_Cliente.MaxLength = 32;

                Cls_Uteis.VerificaoComColorBox(Cls_Uteis.VerificaSeContemApenasCaracteresEspacosAcentos(this.Tbx_Nome_Cliente.Text), (Control)this.Tbx_Nome_Cliente);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tbx_Email_Cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.VerificaoComColorBox(Cls_Uteis.VerificarEmail(this.Tbx_Email_Cliente.Text), (Control)this.Tbx_Email_Cliente);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tbx_Cep_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Cls_Uteis.ContemApenasDigitosEControles(e);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tbx_Nome_Produto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Tbx_Nome_Produto.MaxLength = 12;

                Cls_Uteis.VerificaoComColorBox(Cls_Uteis.VerificaSeContemApenasCaracteresEspacosAcentos(this.Tbx_Nome_Produto.Text), (Control)this.Tbx_Nome_Produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Mtbx_Data_Orcamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.VerificaoComColorBox(Cls_Uteis.validarDataOrcamento((Control)this.Mtbx_Data_Orcamento), (Control)this.Mtbx_Data_Orcamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Mtbx_Telefone_Cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.VerificaoComColorBox(Cls_Uteis.ValidarTelefone(this.Mtbx_Telefone_Cliente.Text), (Control)this.Mtbx_Telefone_Cliente);

                Cls_Uteis.DefaultParaTelefone((Control)this.Mtbx_Telefone_Cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void MTbx_Valor_Produto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.MTbx_Valor_Produto.MaxLength = 7;

                Cls_Uteis.VerificaoComColorBox(Cls_Uteis.eDouble((Control)this.MTbx_Valor_Produto), (Control)this.MTbx_Valor_Produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Rbtn_NAO_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Mtbx_Validade_Orcamento.ReadOnly = true;
                this.Mtbx_Validade_Orcamento.Clear();
                this.Mtbx_Validade_Orcamento.BackColor = SystemColors.Window;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Rbtn_SIM_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Mtbx_Validade_Orcamento.ReadOnly = false;
                this.Mtbx_Validade_Orcamento.BackColor = SystemColors.Window;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Mtbx_Validade_Orcamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.VerificaoComColorBox(Cls_Uteis.validaData((Control)this.Mtbx_Validade_Orcamento), (Control)this.Mtbx_Validade_Orcamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }



        private void Btn_Deletar_Produto_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.RemoverUltimoProdutoGlobal(this.listasDeProdutosGlobal, (Panel)this.Pnl_Mostrar_Produtos);
                AtualizarValorTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void MTbx_Valor_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cls_Uteis.PermitirNumerosEVirgulaEPonto(e);
        }

        private void Tsb_Voltar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tsb_Limpar_Click(object sender, EventArgs e)
        {
            try
            {
                this.LimparFormulario(this.clienteGlobal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tsb_SalvarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.GerarPdfCliente(this.clienteGlobal, this.Rbtn_NAO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tsb_CarregarOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                this.CarregarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tbx_Nome_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Cls_Uteis.PermitirLetrasEspacosEAcentos(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }


        private void Mtbx_Telefone_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Cls_Uteis.PermitirNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tbx_Email_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Cls_Uteis.PermitirLetrasNumerosPontosUnderscoreArrobaBackspace(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Tbx_Nome_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Cls_Uteis.PermitirLetrasEspacosEAcentos(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private void Mtbx_Data_Orcamento_Enter(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.validaData((Control)this.Mtbx_Data_Orcamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }

        private async void Tbx_Cep_Cliente_TextChanged(object sender, EventArgs e)
        {
            string text = this.Tbx_Cep_Cliente.Text;
            this.Tbx_Cep_Cliente.MaxLength = 8;

            if (string.IsNullOrWhiteSpace(text))
                return;

            if (text.Length != 8)
                return;

            try
            {
                Endereco endereco = await Cls_Uteis.GeraJSONCEPAsync(text, (Control)this.Tbx_Cep_Cliente);
                this.Tbx_Localidade_Cliente.Text = endereco.Localidade;
                this.Tbx_Estado_Cliente.Text = endereco.Estado;
                this.Tbx_Logradouro_Cliente.Text = endereco.Logradouro;
                this.Tbx_Bairro_Cliente.Text = endereco.Bairro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar informações do CEP: " + ex.Message);
            }
        }
        private void Btn_SalvarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Uteis.VerificaTodasTextBoxes((Control)this.Tbx_Nome_Cliente,
                (Control)this.Mtbx_Telefone_Cliente,
                (Control)this.Tbx_Email_Cliente,
                (Control)this.Tbx_Cep_Cliente,
                (Control)this.Mtbx_Data_Orcamento);

                this.clienteGlobal.Nome = this.Tbx_Nome_Cliente.Text;
                this.clienteGlobal.Email = this.Tbx_Email_Cliente.Text;
                this.clienteGlobal.Telefone = this.Mtbx_Telefone_Cliente.Text.ToString();
                this.clienteGlobal.FormaDePagamento = Cls_Uteis.RecebeNomeRadioButtonPagamento(Rbtn_PIX, Rbtn_Dinheiro, Rbtn_Cartao);

                this.clienteGlobal.Endereco = new Endereco(
                this.Tbx_Cep_Cliente.Text,
                this.Tbx_Estado_Cliente.Text,
                this.Tbx_Localidade_Cliente.Text,
                this.Tbx_Bairro_Cliente.Text,
                this.Tbx_Logradouro_Cliente.Text);
                this.clienteGlobal.Produtos = this.listasDeProdutosGlobal;

                DateTime result1;
                if (DateTime.TryParse(this.Mtbx_Data_Orcamento.Text, out result1))
                {
                    this.clienteGlobal.Orcamento = new Orcamento();
                    this.clienteGlobal.Orcamento.Data = result1;
                }

                DateTime result2;
                if (DateTime.TryParse(this.Mtbx_Validade_Orcamento.Text, out result2))
                    this.clienteGlobal.Orcamento.Validade = result2;
                Cls_Uteis.GerarPdfCliente(this.clienteGlobal, this.Rbtn_NAO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar os dados: " + ex.Message);
            }
        }
    }
}


