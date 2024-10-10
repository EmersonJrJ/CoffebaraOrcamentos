using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsEstudoPessoal
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();

            this.Text = "Login";

            Lbl_Senha.Font = new Font(Lbl_Senha.Font, FontStyle.Bold);
            Lbl_Senha.Text = "Senha";

            Lbl_Usuario.Font = new Font(Lbl_Usuario.Font, FontStyle.Bold);
            Lbl_Usuario.Text = "Usuario";

            GB_Login.Text = "Login";

            Btn_OK.Text = "OK";
            Btn_Cancel.Text = "Cancel";

            Lbl_Introducao.Font = new Font(Lbl_Introducao.Font.FontFamily, 12, FontStyle.Bold);

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            Btn_Novo_Usuario.Enabled = false;
            Btn_Novo_Usuario.Visible = false;

            if (Cls_Uteis.verificaNovoUsuario())
            {
                GB_Login.Enabled = false;
                GB_Login.Visible = false;
                Btn_OK.Enabled = false;
                Btn_OK.Visible = false;

                Btn_Novo_Usuario.Text = "Novo Usuario";
                Btn_Novo_Usuario.Enabled = true;
                Btn_Novo_Usuario.Visible = true;

                Btn_Novo_Usuario.Location = new Point(394, 282);
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Tbx_Inserir_Nome.Text == Admin.name && Tbx_Inserir_Senha.Text == Admin.senha)
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos. Tente novamente.",
               "Erro de Login",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            Application.Exit();
        }

        private void Btn_Novo_Usuario_Click(object sender, EventArgs e)
        {
            Frm_RegistroUsuario frm_RegistroUsuario = new Frm_RegistroUsuario();
            frm_RegistroUsuario.ShowDialog();

            if (frm_RegistroUsuario.DialogResult == DialogResult.OK)
            {
                Btn_Novo_Usuario.Enabled = false;
                Btn_Novo_Usuario.Visible = false;
                GB_Login.Enabled = true;
                GB_Login.Visible = true;
                Btn_OK.Enabled = true;
                Btn_OK.Visible = true;
            }
        }
    }
}
