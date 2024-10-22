using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEstudoPessoal
{
    internal class Cls_Uteis
    {
        public static void VerificaoComColorBox(bool validador, Control tbox)
        {
            if (validador == true)
            {
                ColorirTboxVerde(tbox);
            }
            else
            {
                ColorirTboxVermelho(tbox);
            }
            VoltarTboxPraCorDefault(tbox);
        }

        public static bool validaSenha(string senha)
        {
            if (senha.Length < 6)
                return false;

            bool contemLetra = senha.Any(char.IsLetter);
            bool contemNumero = senha.Any(char.IsDigit);

            return contemLetra && contemNumero;
        }

        public static bool comparaDadosParaCriacaoDeNovoUsuario(string nome, string senha, Control tbx1, Control tbx2)
        {
            if (tbx1.Text == nome || tbx2.Text == senha)
            {
                return true;
            }
            else
            {

                MessageBox.Show("Usuario ou Senha Invalidos, insira dados válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public static bool verificaNovoUsuario()
        {
            if (Admin.name == "Admin" && Admin.senha == "12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DateTime ConverterStringParaData(string dataTexto)
        {
            DateTime dataConvertida;
            DateTime.TryParse(dataTexto, out dataConvertida);
            return dataConvertida;
        }
        public static void AtualizarGarantiaCliente(Cliente cliente, RadioButton b1, RadioButton b2, MaskedTextBox tbox)
        {
            switch (cliente.PossuiGarantia)
            {
                case "SIM":
                    b1.Checked = true;
                    tbox.Text = cliente.Orcamento.Validade.ToString("dd/MM/yyyy");
                    tbox.BackColor = Color.LightGreen;
                    break;

                case "NAO":
                    b2.Checked = true;
                    tbox.Clear();
                    tbox.BackColor = SystemColors.Window;
                    break;
                default:
                    b1.Checked = false;
                    b2.Checked = false;
                    break;
            }
        }
        public static void AtualizarRadioButtonsFormaDePagamento(Cliente cliente, RadioButton b1, RadioButton b2, RadioButton b3)
        {
            switch (cliente.FormaDePagamento)
            {
                case "PIX":
                    b1.Checked = true;
                    break;
                case "Dinheiro":
                    b2.Checked = true;
                    break;
                case "Cartao":
                    b3.Checked = true;
                    break;
                default:
                    b1.Checked = false;
                    b2.Checked = false;
                    b3.Checked = false;
                    break;
            }
        }
        public static async Task<Endereco> GeraJSONCEPAsync(string CEP, Control tbox)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://viacep.com.br/ws/{CEP}/json/";
                string resposta = await client.GetStringAsync(url);

                Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resposta);

                if (resposta.Contains("erro"))
                {
                    Thread.Sleep(3000);
                    ColorirTboxVermelho(tbox);

                    DialogResult resultado = MessageBox.Show("CEP inválido. Por favor, insira um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (resultado == DialogResult.OK)
                    {
                        tbox.Text = "";
                        tbox.BackColor = SystemColors.Window;
                    }
                }
                else
                {
                    ColorirTboxVerde(tbox);
                }

                Thread.Sleep(3000);
                return endereco;
            }
        }

        public static string ValidaTamanhoCep(string CEP)
        {
            string cepInformado = CEP;


            if (cepInformado.Length != 8)
            {
                MessageBox.Show("O CEP deve possuir 8 números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            else
                return cepInformado;
        }

        public static bool VerificarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,3}$";

            bool temUmArroba = email.Count(c => c == '@') == 1;
            bool terminaComCom = email.EndsWith(".com");

            return Regex.IsMatch(email, pattern) && temUmArroba && terminaComCom;
        }
        public static bool SomenteNumeros(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(char.IsDigit);
        }

        public static bool VerificaSeContemApenasCaracteresEspacosAcentos(string texto)
        {
            return texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) ||
                                  "áéíóúàèìòùãõâêîôûçÁÉÍÓÚÀÈÌÒÙÃÕÂÊÎÔÛÇ".Contains(c));
        }

        public static void ColorirTboxVerde(Control tbox)
        {
            tbox.BackColor = Color.LightGreen;
        }

        public static void ColorirTboxAmarelo(Control tbox)
        {
            tbox.BackColor = Color.Yellow;
        }

        public static void ColorirTboxVermelho(Control tbox)
        {
            tbox.BackColor = Color.LightCoral;
        }

        public static void VoltarTboxPraCorDefault(Control tbox)
        {
            if (string.IsNullOrEmpty(tbox.Text))
            {
                tbox.BackColor = SystemColors.Window;
            }
        }

        public static void DefaultSemVirgula(Control tbox)
        {
            if (string.IsNullOrEmpty(tbox.Text.Replace(",", "")))
            {
                tbox.BackColor = SystemColors.Window;
            }
        }

        public static void DefaultParaTelefone(Control tbox)
        {
            if (string.IsNullOrEmpty(tbox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim()))
            {
                tbox.BackColor = SystemColors.Window;
            }
        }

        public static bool limitadorDeCaracteresEmDoze(String text)
        {
            return text.Length <= 12;
        }

        public static bool ValidarData(String text)
        {
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
            return text == dataAtual;
        }

        public static bool ValidarTelefone(string text)
        {
            string numeroLimpo = text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (SomenteNumeros(numeroLimpo))
            {
                return numeroLimpo.Length == 10;
            }

            return false;
        }
        public static void AvaliarFormaPagamento(RadioButton rb, string info)
        {
            if (rb.Checked)
            {
                MessageBox.Show("Pagamento via " + info + " selecionado.");
            }
            else if (rb.Checked)
            {
                MessageBox.Show("Pagamento em Dinheiro selecionado.");
            }
            else if (rb.Checked)
            {
                MessageBox.Show("Pagamento via Cartão selecionado.");
            }
            else
            {
                MessageBox.Show("Nenhuma forma de pagamento selecionada.");
            }
        }

        public static bool validaData(Control mtbx)
        {
            if (DateTime.TryParse(mtbx.Text, out DateTime dataEntrada))
            {
                return dataEntrada.Date >= DateTime.Today;
            }
            return false;
        }

        public static double SomarValores(List<Produto> produtos)
        {
            return produtos.Sum(p => p.Valor);
        }

        public static void CalcularResultadoNovoOrcamento(List<Produto> produtos, System.Windows.Forms.Label lbl)
        {
            if (produtos == null || !produtos.Any())
            {
                MessageBox.Show("A lista de produtos está vazia. Não é possível calcular o orçamento.");
                return;
            }

            try
            {
                double total = SomarValores(produtos);
                lbl.Text = "R$: " + total.ToString("N2", CultureInfo.InvariantCulture).Replace('.', ',');
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        public static void CalcularResultadoOrcamento(Cliente c, System.Windows.Forms.Label lbl)
        {
            if (c.Produtos == null || !c.Produtos.Any())
            {
                MessageBox.Show("A lista de produtos está vazia. Não é possível calcular o orçamento.");
                return;
            }

            try
            {
                double total = SomarValores(c.Produtos);
                lbl.Text = "R$: " + total.ToString("N2", CultureInfo.InvariantCulture).Replace('.', ',');
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }



        public static void RemoverUltimoProdutoGlobal(List<Produto> lista, Panel p)
        {
            if (lista.Count > 0 && p.Controls.Count > 0)
            {
                lista.RemoveAt(lista.Count - 1);


                Control ultimoProduto = p.Controls[p.Controls.Count - 1];

                if (ultimoProduto is System.Windows.Forms.Label)
                {
                    p.Controls.Remove(ultimoProduto);
                    ultimoProduto.Dispose();
                    AtualizarPosicaoProdutos(p);
                }

            }
            else
            {
                MessageBox.Show("A lista de produtos está vazia. Não é possível remover o produto.");
            }
        }

        public static void AtualizarPosicaoProdutos(Panel p)
        {
            int posY;
            posY = 10;
            foreach (Control controle in p.Controls)
            {
                if (controle is System.Windows.Forms.Label)
                {
                    controle.Location = new Point(10, posY);
                    posY += controle.Height + 10;
                }
            }
        }

        public static bool VerificaTodasTextBoxes(Control tbox, Control tbox2, Control tbox3, Control tbox4, Control tbox5)
        {
            bool validaTbox = tbox.BackColor == Color.LightGreen &&
                  tbox2.BackColor == Color.LightGreen &&
                  tbox3.BackColor == Color.LightGreen &&
                  tbox4.BackColor == Color.LightGreen &&
                  tbox5.BackColor == Color.LightGreen;

            return validaTbox;
        }

        public static bool VerificaTodasTextBoxesLogin(Control tbox, Control tbox2, Control tbox3, Control tbox4)
        {
            bool validaTbox = tbox.BackColor == Color.LightGreen &&
                  tbox2.BackColor == Color.LightGreen &&
                  tbox3.BackColor == Color.LightGreen &&
                  tbox4.BackColor == Color.LightGreen;

            return validaTbox;
        }

        public static bool VerificaRadioButtonsPagamento(RadioButton b1, RadioButton b2, RadioButton b3)
        {
            return b1.Checked || b2.Checked || b3.Checked;
        }

        public static bool VerificaRadioButtonsGarantia(RadioButton b1, RadioButton b2)
        {
            return b1.Checked || b2.Checked;
        }

        public static string RecebeNomeRadioButtonPagamento(RadioButton b1, RadioButton b2, RadioButton b3)
        {
            string formaPagamento = "";
            if (b1.Checked)
            {
                formaPagamento = b1.Text;
                return formaPagamento;
            }
            else if (b2.Checked)
            {
                formaPagamento = b2.Text;
                return formaPagamento;
            }
            else if (b3.Checked)
            {
                formaPagamento = b3.Text;
                return formaPagamento;
            }
            return formaPagamento;
        }

        public static string RecebeNomeRadioButtonGarantia(RadioButton b1, RadioButton b2)
        {
            string possuiGarantia = "";
            if (b1.Checked)
            {
                possuiGarantia = b1.Text;
                return possuiGarantia;
            }
            else if (b2.Checked)
            {
                possuiGarantia = b2.Text;
                return possuiGarantia;
            }
            return possuiGarantia;
        }

        public static void atribuiPossuiGarantia(Cliente c, RadioButton b1, RadioButton b2)
        {
            c.Nome = RecebeNomeRadioButtonGarantia(b1, b2);
        }

        public static void atribuiFormaDePagamento(Cliente c, RadioButton b1, RadioButton b2, RadioButton b3)
        {
            c.Nome = RecebeNomeRadioButtonPagamento(b1, b2, b3);
        }

        public static int posY = 10;
        public static void AdicionarProduto(string nome, double valor, Panel p)
        {
            if (valor <= 0)
            {
                MessageBox.Show("O valor não pode ser menor que 0.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.Windows.Forms.Label produtoLabel = new System.Windows.Forms.Label
            {
                Text = $"{nome}  R$ {valor:F2}",
                Font = new Font("Arial", 9, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(5)
            };

            produtoLabel.Location = new Point(10, posY);

            p.Controls.Add(produtoLabel);

            posY += produtoLabel.Height + 10;
        }

        public static void CarregarProdutosOrcamento(Cliente cliente, FlowLayoutPanel fp)
        {
            fp.Controls.Clear();

            fp.FlowDirection = FlowDirection.TopDown;
            fp.WrapContents = false;
            fp.AutoScroll = true;
            if (cliente.Orcamento != null)
            {
                foreach (var produto in cliente.Produtos)
                {
                    System.Windows.Forms.Label lblProduto = new System.Windows.Forms.Label
                    {
                        Text = $"{produto.Nome} - R$ {produto.Valor:F2}",
                        AutoSize = true,
                        Margin = new Padding(5)
                    };

                    fp.Controls.Add(lblProduto);
                }
            }
        }
        public static void GerarPdfCliente(Cliente cliente, RadioButton button)
        {
            string caminhoPasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Coffebara Arquivos");

            string caminhoSubpastaPDF = Path.Combine(caminhoPasta, "PDF");

            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
            }

            if (!Directory.Exists(caminhoSubpastaPDF))
            {
                Directory.CreateDirectory(caminhoSubpastaPDF);
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                saveFileDialog.Title = "Salvar PDF";
                saveFileDialog.InitialDirectory = caminhoSubpastaPDF;
                saveFileDialog.FileName = $"{cliente.Nome}_cliente.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = saveFileDialog.FileName;

                    using (PdfWriter writer = new PdfWriter(caminhoArquivo))
                    {
                        PdfDocument pdf = new PdfDocument(writer);

                        Document document = new Document(pdf);

                        PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                        document.Add(new Paragraph("Informações do Emissor")
                            .SetFont(font)
                            .SetFontSize(15)
                            .SetBold()
                            .SetTextAlignment(TextAlignment.CENTER));

                        document.Add(new Paragraph(" "));

                        document.Add(new Paragraph($"Nome: {Admin.name}")
                            .SetFont(font)
                            .SetFontSize(12));

                        document.Add(new Paragraph($"Telefone: {Admin.telefone}")
                            .SetFont(font)
                            .SetFontSize(12));

                        document.Add(new Paragraph($"E-mail: {Admin.Email}")
                            .SetFont(font)
                            .SetFontSize(12));

                        document.Add(new Paragraph(" "));

                        document.Add(new Paragraph("Informações do Cliente")
                            .SetFont(font)
                            .SetFontSize(15)
                            .SetBold()
                            .SetTextAlignment(TextAlignment.CENTER));

                        document.Add(new Paragraph($"Nome: {cliente.Nome}")
                            .SetFont(font)
                            .SetFontSize(12));

                        document.Add(new Paragraph($"Telefone: {cliente.Telefone}")
                            .SetFont(font)
                            .SetFontSize(12));

                        document.Add(new Paragraph($"Email: {cliente.Email}")
                            .SetFont(font)
                            .SetFontSize(12));

                        document.Add(new Paragraph($"Forma de Pagamento: {cliente.FormaDePagamento}")
                            .SetFont(font)
                            .SetFontSize(12));

                        if (button.Checked == false && !string.IsNullOrWhiteSpace(cliente.PossuiGarantia))
                        {
                            document.Add(new Paragraph($"Garantia válida até: {cliente.Orcamento.Validade.Day}/{cliente.Orcamento.Validade.Month}/{cliente.Orcamento.Validade.Year}")
                                .SetFont(font)
                                .SetFontSize(12));
                        }

                        document.Add(new Paragraph($"Endereço: CEP: {cliente.Endereco.Cep}, Estado: {cliente.Endereco.Estado}, Município: {cliente.Endereco.Localidade}, Bairro: {cliente.Endereco.Bairro}, Logradouro: {cliente.Endereco.Logradouro}")
                            .SetFont(font)
                            .SetFontSize(12));

                        document.Add(new Paragraph(" "));

                        document.Add(new Paragraph("Informações do Produto")
                            .SetFont(font)
                            .SetFontSize(15)
                            .SetBold()
                            .SetTextAlignment(TextAlignment.CENTER));

                        Table table = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1 })).UseAllAvailableWidth();

                        for (int i = 0; i < cliente.Produtos.Count; i++)
                        {
                            var produto = cliente.Produtos[i];

                            table.AddCell(new Cell()
                                .Add(new Paragraph($"{produto.Nome}, Valor: R$ {produto.Valor:F2}")
                                .SetFont(font)
                                .SetFontSize(12)));

                            if (i + 1 < cliente.Produtos.Count)
                            {
                                var nextProduto = cliente.Produtos[i + 1];
                                table.AddCell(new Cell()
                                    .Add(new Paragraph($"{nextProduto.Nome}, Valor: R$ {nextProduto.Valor:F2}")
                                    .SetFont(font)
                                    .SetFontSize(12)));

                                i++;
                            }
                            else
                            {
                                table.AddCell(new Cell().Add(new Paragraph("")));
                            }
                        }

                        document.Add(table);

                        double valorTotal = cliente.Produtos.Sum(produto => produto.Valor);

                        document.Add(new Paragraph($"Valor Total: R$ {valorTotal:F2}")
                            .SetFont(font)
                            .SetFontSize(12)
                            .SetBold()
                            .SetTextAlignment(TextAlignment.RIGHT));
                        document.Add(new Paragraph(" "));

                        float pageWidth = pdf.GetDefaultPageSize().GetWidth();
                        float margin = document.GetLeftMargin();

                        float assinaturaYPosition = 50;
                        float assinaturaWidth = (pageWidth - 2 * margin) / 2;

                        document.Add(new Paragraph("_________________________")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFixedPosition(margin, assinaturaYPosition, assinaturaWidth));

                        document.Add(new Paragraph("Assinatura do Emissor")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFixedPosition(margin, assinaturaYPosition - 15, assinaturaWidth));

                        document.Add(new Paragraph("_________________________")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFixedPosition(margin + assinaturaWidth, assinaturaYPosition, assinaturaWidth));

                        document.Add(new Paragraph("Assinatura do Cliente")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFixedPosition(margin + assinaturaWidth, assinaturaYPosition - 15, assinaturaWidth));

                        document.Close();
                    }
                }
            }
        }



        public static void PermitirLetrasEspacosEAcentos(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public static void PermitirLetrasNumerosPontosUnderscoreArrobaBackspace(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '_' &&
                e.KeyChar != '@' &&
                e.KeyChar != '-' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public static void PermitirNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public static void PermitirNumerosEVirgulaEPonto(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public static void PermitirLetrasENumeros(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        public static void ColorirTboxValorProduto(Control tbox)
        {
            if (double.TryParse(tbox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
            {
                Cls_Uteis.ColorirTboxVerde(tbox);
                return;
            }
            else
            {
                Cls_Uteis.ColorirTboxVermelho(tbox);
                Cls_Uteis.VoltarTboxPraCorDefault(tbox);
            }
        }

        public static void AtualizarLabelConformeFoco2(string text, string textDF, System.Windows.Forms.Label LabelText, System.Windows.Forms.TextBox tbx)
        {
            if (tbx.Focused)
            {
                LabelText.Text = text;
            }
            else
            {
                LabelText.Text = textDF;
            }
        }

        public static void AtualizarLabelConformeFoco(System.Windows.Forms.TextBox tbx, System.Windows.Forms.Label Label, string text)
        {
            Label.Text = text;
        }

        public static bool IsAcento(char c)
        {
            char[] acentos = { 'á', 'ã', 'â', 'à', 'ä', 'é', 'ê', 'í', 'ï', 'ó', 'õ', 'ô', 'ú', 'ü', 'ç',
                       'Á', 'Ã', 'Â', 'À', 'Ä', 'É', 'Ê', 'Í', 'Ï', 'Ó', 'Õ', 'Ô', 'Ú', 'Ü', 'Ç' };

            return acentos.Contains(c);
        }

        public static bool ContemApenasLetrasECaracteresPermitidosENumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ' && !IsAcento(c) && !char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ContemApenasLetrasECaracteresPermitidos(Control tbox)
        {
            if (!tbox.Text.All(c => char.IsLetter(c) || c == ' ' || IsAcento(c)))
            {
                return true;
            }
            return false;
        }

        public static void ContemApenasDigitosEControles(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool eDouble(Control tbox)
        {
            if (double.TryParse(tbox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
            {
                Cls_Uteis.ColorirTboxVerde(tbox);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool validarDataOrcamento(Control tbox)
        {
            DateTime dataOrcamento;

            try
            {
                if (DateTime.TryParseExact(tbox.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataOrcamento))
                {
                    if (dataOrcamento < DateTime.Now.Date)
                    {
                        tbox.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    tbox.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao validar a data: " + ex.Message);
                tbox.Focus();
                return false;
            }
        }
    }
}

