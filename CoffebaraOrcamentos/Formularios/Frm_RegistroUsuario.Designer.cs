namespace WindowsFormsEstudoPessoal
{
    partial class Frm_RegistroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Novo_NomeUsuario = new System.Windows.Forms.Label();
            this.Lbl_Nova_Senha = new System.Windows.Forms.Label();
            this.Lbl_Texto_Explicativo = new System.Windows.Forms.Label();
            this.Tbx_Novo_Nome = new System.Windows.Forms.TextBox();
            this.Tbx_Nova_Senha = new System.Windows.Forms.TextBox();
            this.Btn_SalvarUsuario = new System.Windows.Forms.Button();
            this.Lbl_Novo_Email = new System.Windows.Forms.Label();
            this.Lbl_Novo_Telefone = new System.Windows.Forms.Label();
            this.Tbx_Novo_Email = new System.Windows.Forms.TextBox();
            this.Mtbx_Novo_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Lbl_Novo_NomeUsuario
            // 
            this.Lbl_Novo_NomeUsuario.AutoSize = true;
            this.Lbl_Novo_NomeUsuario.Location = new System.Drawing.Point(12, 49);
            this.Lbl_Novo_NomeUsuario.Name = "Lbl_Novo_NomeUsuario";
            this.Lbl_Novo_NomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Novo_NomeUsuario.TabIndex = 0;
            this.Lbl_Novo_NomeUsuario.Text = "label1";
            // 
            // Lbl_Nova_Senha
            // 
            this.Lbl_Nova_Senha.AutoSize = true;
            this.Lbl_Nova_Senha.Location = new System.Drawing.Point(12, 75);
            this.Lbl_Nova_Senha.Name = "Lbl_Nova_Senha";
            this.Lbl_Nova_Senha.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nova_Senha.TabIndex = 1;
            this.Lbl_Nova_Senha.Text = "label2";
            // 
            // Lbl_Texto_Explicativo
            // 
            this.Lbl_Texto_Explicativo.AutoSize = true;
            this.Lbl_Texto_Explicativo.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Texto_Explicativo.Name = "Lbl_Texto_Explicativo";
            this.Lbl_Texto_Explicativo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Texto_Explicativo.TabIndex = 2;
            this.Lbl_Texto_Explicativo.Text = "label3";
            // 
            // Tbx_Novo_Nome
            // 
            this.Tbx_Novo_Nome.Location = new System.Drawing.Point(111, 42);
            this.Tbx_Novo_Nome.Name = "Tbx_Novo_Nome";
            this.Tbx_Novo_Nome.Size = new System.Drawing.Size(168, 20);
            this.Tbx_Novo_Nome.TabIndex = 3;
            this.Tbx_Novo_Nome.TextChanged += new System.EventHandler(this.Tbx_Novo_Nome_TextChanged);
            this.Tbx_Novo_Nome.Enter += new System.EventHandler(this.Tbx_Novo_Nome_Enter);
            this.Tbx_Novo_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Novo_Nome_KeyPress);
            this.Tbx_Novo_Nome.Leave += new System.EventHandler(this.Tbx_Novo_Nome_Leave);
            // 
            // Tbx_Nova_Senha
            // 
            this.Tbx_Nova_Senha.Location = new System.Drawing.Point(111, 68);
            this.Tbx_Nova_Senha.Name = "Tbx_Nova_Senha";
            this.Tbx_Nova_Senha.Size = new System.Drawing.Size(168, 20);
            this.Tbx_Nova_Senha.TabIndex = 4;
            this.Tbx_Nova_Senha.TextChanged += new System.EventHandler(this.Tbx_Nova_Senha_TextChanged);
            this.Tbx_Nova_Senha.Enter += new System.EventHandler(this.Tbx_Nova_Senha_Enter);
            this.Tbx_Nova_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Nova_Senha_KeyPress);
            this.Tbx_Nova_Senha.Leave += new System.EventHandler(this.Tbx_Nova_Senha_Leave);
            // 
            // Btn_SalvarUsuario
            // 
            this.Btn_SalvarUsuario.Location = new System.Drawing.Point(176, 157);
            this.Btn_SalvarUsuario.Name = "Btn_SalvarUsuario";
            this.Btn_SalvarUsuario.Size = new System.Drawing.Size(103, 23);
            this.Btn_SalvarUsuario.TabIndex = 5;
            this.Btn_SalvarUsuario.Text = "button1";
            this.Btn_SalvarUsuario.UseVisualStyleBackColor = true;
            this.Btn_SalvarUsuario.Click += new System.EventHandler(this.Btn_SalvarUsuario_Click);
            // 
            // Lbl_Novo_Email
            // 
            this.Lbl_Novo_Email.AutoSize = true;
            this.Lbl_Novo_Email.Location = new System.Drawing.Point(12, 101);
            this.Lbl_Novo_Email.Name = "Lbl_Novo_Email";
            this.Lbl_Novo_Email.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Novo_Email.TabIndex = 6;
            this.Lbl_Novo_Email.Text = "label2";
            // 
            // Lbl_Novo_Telefone
            // 
            this.Lbl_Novo_Telefone.AutoSize = true;
            this.Lbl_Novo_Telefone.Location = new System.Drawing.Point(12, 127);
            this.Lbl_Novo_Telefone.Name = "Lbl_Novo_Telefone";
            this.Lbl_Novo_Telefone.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Novo_Telefone.TabIndex = 8;
            this.Lbl_Novo_Telefone.Text = "label2";
            // 
            // Tbx_Novo_Email
            // 
            this.Tbx_Novo_Email.Location = new System.Drawing.Point(111, 94);
            this.Tbx_Novo_Email.Name = "Tbx_Novo_Email";
            this.Tbx_Novo_Email.Size = new System.Drawing.Size(168, 20);
            this.Tbx_Novo_Email.TabIndex = 9;
            this.Tbx_Novo_Email.TextChanged += new System.EventHandler(this.Tbx_Novo_Email_TextChanged);
            this.Tbx_Novo_Email.Enter += new System.EventHandler(this.Tbx_Novo_Email_Enter);
            this.Tbx_Novo_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Novo_Email_KeyPress);
            this.Tbx_Novo_Email.Leave += new System.EventHandler(this.Tbx_Novo_Email_Leave);
            // 
            // Mtbx_Novo_Telefone
            // 
            this.Mtbx_Novo_Telefone.Location = new System.Drawing.Point(111, 127);
            this.Mtbx_Novo_Telefone.Mask = "(00)0000-0000";
            this.Mtbx_Novo_Telefone.Name = "Mtbx_Novo_Telefone";
            this.Mtbx_Novo_Telefone.Size = new System.Drawing.Size(168, 20);
            this.Mtbx_Novo_Telefone.TabIndex = 10;
            this.Mtbx_Novo_Telefone.TextChanged += new System.EventHandler(this.Mtbx_Novo_Telefone_TextChanged);
            this.Mtbx_Novo_Telefone.Enter += new System.EventHandler(this.Mtbx_Novo_Telefone_Enter);
            this.Mtbx_Novo_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mtbx_Novo_Telefone_KeyPress);
            this.Mtbx_Novo_Telefone.Leave += new System.EventHandler(this.Mtbx_Novo_Telefone_Leave);
            // 
            // Frm_RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 192);
            this.Controls.Add(this.Mtbx_Novo_Telefone);
            this.Controls.Add(this.Tbx_Novo_Email);
            this.Controls.Add(this.Lbl_Novo_Telefone);
            this.Controls.Add(this.Lbl_Novo_Email);
            this.Controls.Add(this.Btn_SalvarUsuario);
            this.Controls.Add(this.Tbx_Nova_Senha);
            this.Controls.Add(this.Tbx_Novo_Nome);
            this.Controls.Add(this.Lbl_Texto_Explicativo);
            this.Controls.Add(this.Lbl_Nova_Senha);
            this.Controls.Add(this.Lbl_Novo_NomeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_RegistroUsuario";
            this.Text = "Coffebara Orçamentos - Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Novo_NomeUsuario;
        private System.Windows.Forms.Label Lbl_Nova_Senha;
        private System.Windows.Forms.Label Lbl_Texto_Explicativo;
        private System.Windows.Forms.TextBox Tbx_Novo_Nome;
        private System.Windows.Forms.TextBox Tbx_Nova_Senha;
        private System.Windows.Forms.Button Btn_SalvarUsuario;
        private System.Windows.Forms.Label Lbl_Novo_Email;
        private System.Windows.Forms.Label Lbl_Novo_Telefone;
        private System.Windows.Forms.TextBox Tbx_Novo_Email;
        private System.Windows.Forms.MaskedTextBox Mtbx_Novo_Telefone;
    }
}