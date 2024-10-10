using System;
using System.Windows.Forms;

namespace WindowsFormsEstudoPessoal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Admin.CarregarConfiguracoes();
            Frm_Login frm_Login = new Frm_Login();

            if (frm_Login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Frm_Menu_Principal());
            }
        }
    }
}
