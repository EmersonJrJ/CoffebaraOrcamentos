using System;
using System.Windows.Forms;

namespace WindowsFormsEstudoPessoal
{
    public partial class Frm_RegistroUsuario : Form
    {
        string LblInfoCadastroUsuarioDefault = "Digite suas informacoes";
        string LblInfoCadastroUsuarioNome = "O Nome pode conter apenas letras, espacos e acentos";
        string LblInfoCadastroUsuarioSenha = "A senha deve conter Letras e Numeros";
        string LblInfoCadastroUsuarioEmail = "O Email precisa de um (@) e finalizar com (.com):";
        string LblInfoCadastroUsuarioTelefone = "O telefone precisa de ter todo campo preenchido";

        public Frm_RegistroUsuario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            Lbl_Texto_Explicativo.Text = LblInfoCadastroUsuarioDefault;
            Lbl_Novo_NomeUsuario.Text = "Novo Nome:";
            Lbl_Nova_Senha.Text = "Nova Senha:";
            Lbl_Novo_Email.Text = "Novo Email";
            Lbl_Novo_Telefone.Text = "Novo Telefone";
            Btn_SalvarUsuario.Text = "Salvar Dados";
        }

        private void Btn_SalvarUsuario_Click(object sender, EventArgs e)
        {
            if (Cls_Uteis.VerificaTodasTextBoxesLogin(Tbx_Novo_Nome, Tbx_Nova_Senha, Tbx_Novo_Email, Mtbx_Novo_Telefone))
            {
                Admin.name = Tbx_Novo_Nome.Text;
                Admin.senha = Tbx_Nova_Senha.Text;
                Admin.Email = Tbx_Novo_Email.Text;
                Admin.telefone = Mtbx_Novo_Telefone.Text;
                Admin.SalvarConfiguracoes();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void Tbx_Novo_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cls_Uteis.PermitirLetrasNumerosPontosUnderscoreArrobaBackspace(e);
        }

        private void Tbx_Novo_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cls_Uteis.PermitirLetrasEspacosEAcentos(e);
        }

        private void Mtbx_Novo_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cls_Uteis.PermitirNumeros(e);
        }

        private void Tbx_Nova_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cls_Uteis.PermitirLetrasENumeros(e);
        }

        private void Mtbx_Novo_Telefone_TextChanged(object sender, EventArgs e)
        {
            Cls_Uteis.VerificaoComColorBox(Cls_Uteis.ValidarTelefone(Mtbx_Novo_Telefone.Text), Mtbx_Novo_Telefone);
            Cls_Uteis.DefaultParaTelefone(Mtbx_Novo_Telefone);
        }

        private void Tbx_Nova_Senha_TextChanged(object sender, EventArgs e)
        {
            Cls_Uteis.VerificaoComColorBox(Cls_Uteis.ContemApenasLetrasECaracteresPermitidos(Tbx_Nova_Senha), Tbx_Nova_Senha);
        }

        private void Tbx_Novo_Email_TextChanged(object sender, EventArgs e)
        {
            Cls_Uteis.VerificaoComColorBox(Cls_Uteis.VerificarEmail(Tbx_Novo_Email.Text), Tbx_Novo_Email);
        }

        private void Tbx_Novo_Nome_TextChanged(object sender, EventArgs e)
        {
            Cls_Uteis.VerificaoComColorBox(Cls_Uteis.VerificaSeContemApenasCaracteresEspacosAcentos(Tbx_Novo_Nome.Text), Tbx_Novo_Nome);
        }

        private void Tbx_Novo_Nome_Enter(object sender, EventArgs e)
        {
            Cls_Uteis.AtualizarLabelConformeFoco(Tbx_Novo_Nome, Lbl_Texto_Explicativo, LblInfoCadastroUsuarioNome);
        }

        private void Tbx_Novo_Email_Enter(object sender, EventArgs e)
        {
            Cls_Uteis.AtualizarLabelConformeFoco(Tbx_Novo_Nome, Lbl_Texto_Explicativo, LblInfoCadastroUsuarioEmail);
        }

        private void Mtbx_Novo_Telefone_Enter(object sender, EventArgs e)
        {
            Cls_Uteis.AtualizarLabelConformeFoco(Tbx_Novo_Nome, Lbl_Texto_Explicativo, LblInfoCadastroUsuarioTelefone);
        }

        private void Tbx_Nova_Senha_Enter(object sender, EventArgs e)
        {
            Cls_Uteis.AtualizarLabelConformeFoco(Tbx_Novo_Nome, Lbl_Texto_Explicativo, LblInfoCadastroUsuarioSenha);
        }

        private void Tbx_Nova_Senha_Leave(object sender, EventArgs e)
        {
            Cls_Uteis.AtualizarLabelConformeFoco(Tbx_Novo_Nome, Lbl_Texto_Explicativo, LblInfoCadastroUsuarioDefault);
        }

        private void Tbx_Novo_Nome_Leave(object sender, EventArgs e)
        {
            Cls_Uteis.AtualizarLabelConformeFoco(Tbx_Novo_Nome, Lbl_Texto_Explicativo, LblInfoCadastroUsuarioDefault);
        }

        private void Tbx_Novo_Email_Leave(object sender, EventArgs e)
        {
            Cls_Uteis.AtualizarLabelConformeFoco(Tbx_Novo_Nome, Lbl_Texto_Explicativo, LblInfoCadastroUsuarioDefault);
        }

        private void Mtbx_Novo_Telefone_Leave(object sender, EventArgs e)
        {
            Cls_Uteis.AtualizarLabelConformeFoco(Tbx_Novo_Nome, Lbl_Texto_Explicativo, LblInfoCadastroUsuarioEmail);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}
