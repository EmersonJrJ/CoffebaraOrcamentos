using System;
using System.Windows.Forms;
using WindowsFormsEstudoPessoal.Formularios;

namespace WindowsFormsEstudoPessoal
{
    public partial class Frm_Menu_Principal : Form
    {
        public Frm_Menu_Principal()
        {
            InitializeComponent();

            GB_Carregar_Arquivo.Text = "Carregar";
            GB_Novo_Arquivo.Text = "Novo";
            GB_Deletar_Arquivo.Text = "Deletar";


            Btn_Novo_Orcamento.Text = "Novo";
            Btn_Carregar_Orcamento.Text = "Carregar";
            Btn_Deletar_Arquivo.Text = "Deletar";

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Novo_Orcamento_Click(object sender, EventArgs e)
        {
            Frm_Gerenciar_Orcamento frm_Gerenciar_Orcamento = new Frm_Gerenciar_Orcamento();
            frm_Gerenciar_Orcamento.ShowDialog();
        }

        private void FecharMenuPrincipal_Se_Fechar_MenuLogin_A_Forca(DialogResult result)
        {
            if (result != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Btn_Carregar_Orcamento_Click(object sender, EventArgs e)
        {
            Frm_Gerenciar_Orcamento frm_Gerenciar_Orcamento = new Frm_Gerenciar_Orcamento();
            frm_Gerenciar_Orcamento.formularioCarregadoViaBotaoCarregar = true;

            if (frm_Gerenciar_Orcamento.CarregarCliente())
            {
                frm_Gerenciar_Orcamento.ShowDialog();
            }
        }

        private void novoOrcamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Gerenciar_Orcamento frm_Gerenciar_Orcamento = new Frm_Gerenciar_Orcamento();
            frm_Gerenciar_Orcamento.ShowDialog();
        }

        private void carregarOrcamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Gerenciar_Orcamento frm_Gerenciar_Orcamento = new Frm_Gerenciar_Orcamento();
            frm_Gerenciar_Orcamento.formularioCarregadoViaBotaoCarregar = true;

            if (frm_Gerenciar_Orcamento.CarregarCliente())
            {
                frm_Gerenciar_Orcamento.ShowDialog();
            }
        }

        private void Btn_Deletar_Arquivo_Click(object sender, EventArgs e)
        {
            Frm_Gerenciar_Orcamento frm_Gerenciar_Orcamento = new Frm_Gerenciar_Orcamento();
            frm_Gerenciar_Orcamento.formularioCarregadoViaBotaoCarregar = true;

            frm_Gerenciar_Orcamento.DeletarOrcamento();
        }

        private void deletarOrcamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Gerenciar_Orcamento frm_Gerenciador_Orcamento = new Frm_Gerenciar_Orcamento();
            frm_Gerenciador_Orcamento.formularioCarregadoViaBotaoCarregar = true;

            frm_Gerenciador_Orcamento.DeletarOrcamento();
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistroUsuario frm_RegistroUsuario = new Frm_RegistroUsuario();
            frm_RegistroUsuario.ShowDialog();
        }
    }
}
