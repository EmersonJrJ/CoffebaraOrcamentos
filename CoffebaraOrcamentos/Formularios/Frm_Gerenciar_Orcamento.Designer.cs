namespace WindowsFormsEstudoPessoal.Formularios
{
    partial class Frm_Gerenciar_Orcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gerenciar_Orcamento));
            this.GB_Dados_Emissor = new System.Windows.Forms.GroupBox();
            this.Lbl_Telefone_Emissor = new System.Windows.Forms.Label();
            this.Lbl_Email_Emissor = new System.Windows.Forms.Label();
            this.Lbl_Nome_Emissor = new System.Windows.Forms.Label();
            this.Gb_Dados_Cliente = new System.Windows.Forms.GroupBox();
            this.Lbl_Telefone_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Email_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Nome_Cliente = new System.Windows.Forms.Label();
            this.Mtbx_Telefone_Cliente = new System.Windows.Forms.MaskedTextBox();
            this.Tbx_Email_Cliente = new System.Windows.Forms.TextBox();
            this.Tbx_Nome_Cliente = new System.Windows.Forms.TextBox();
            this.GB_Endereco_Cliente = new System.Windows.Forms.GroupBox();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Tbx_Logradouro_Cliente = new System.Windows.Forms.TextBox();
            this.Tbx_Bairro_Cliente = new System.Windows.Forms.TextBox();
            this.Tbx_Localidade_Cliente = new System.Windows.Forms.TextBox();
            this.Tbx_Estado_Cliente = new System.Windows.Forms.TextBox();
            this.Tbx_Cep_Cliente = new System.Windows.Forms.TextBox();
            this.Gb_Dados_Orcamento = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Mtbx_Data_Orcamento = new System.Windows.Forms.MaskedTextBox();
            this.Gb_Pagamento = new System.Windows.Forms.GroupBox();
            this.Rbtn_Dinheiro = new System.Windows.Forms.RadioButton();
            this.Rbtn_Cartao = new System.Windows.Forms.RadioButton();
            this.Rbtn_PIX = new System.Windows.Forms.RadioButton();
            this.Gb_Garantia = new System.Windows.Forms.GroupBox();
            this.Gb_Validade = new System.Windows.Forms.GroupBox();
            this.Lbl_Validade_Garantia = new System.Windows.Forms.Label();
            this.Mtbx_Validade_Orcamento = new System.Windows.Forms.MaskedTextBox();
            this.Gb_PossuiGarantia = new System.Windows.Forms.GroupBox();
            this.Lbl_PossuiGarantia = new System.Windows.Forms.Label();
            this.Rbtn_SIM = new System.Windows.Forms.RadioButton();
            this.Rbtn_NAO = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Pnl_Mostrar_Produtos = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MTbx_Valor_Produto = new System.Windows.Forms.TextBox();
            this.Btn_Adicionar_Produto = new System.Windows.Forms.Button();
            this.Lbl_Valor_Produto = new System.Windows.Forms.Label();
            this.Lbl_Nome_Produto = new System.Windows.Forms.Label();
            this.Tbx_Nome_Produto = new System.Windows.Forms.TextBox();
            this.Btn_Deletar_Produto = new System.Windows.Forms.Button();
            this.Btn_SalvarPDF = new System.Windows.Forms.Button();
            this.Btn_Salvar_Orcamento = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Voltar = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Limpar = new System.Windows.Forms.ToolStripButton();
            this.Tsb_SalvarPDF = new System.Windows.Forms.ToolStripButton();
            this.Tsb_CarregarOrcamento = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_Dados_Emissor.SuspendLayout();
            this.Gb_Dados_Cliente.SuspendLayout();
            this.GB_Endereco_Cliente.SuspendLayout();
            this.Gb_Dados_Orcamento.SuspendLayout();
            this.Gb_Pagamento.SuspendLayout();
            this.Gb_Garantia.SuspendLayout();
            this.Gb_Validade.SuspendLayout();
            this.Gb_PossuiGarantia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Dados_Emissor
            // 
            this.GB_Dados_Emissor.Controls.Add(this.Lbl_Telefone_Emissor);
            this.GB_Dados_Emissor.Controls.Add(this.Lbl_Email_Emissor);
            this.GB_Dados_Emissor.Controls.Add(this.Lbl_Nome_Emissor);
            this.GB_Dados_Emissor.Location = new System.Drawing.Point(12, 30);
            this.GB_Dados_Emissor.Name = "GB_Dados_Emissor";
            this.GB_Dados_Emissor.Size = new System.Drawing.Size(136, 81);
            this.GB_Dados_Emissor.TabIndex = 0;
            this.GB_Dados_Emissor.TabStop = false;
            this.GB_Dados_Emissor.Text = "Emissor";
            // 
            // Lbl_Telefone_Emissor
            // 
            this.Lbl_Telefone_Emissor.AutoSize = true;
            this.Lbl_Telefone_Emissor.Location = new System.Drawing.Point(6, 61);
            this.Lbl_Telefone_Emissor.Name = "Lbl_Telefone_Emissor";
            this.Lbl_Telefone_Emissor.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Telefone_Emissor.TabIndex = 2;
            this.Lbl_Telefone_Emissor.Text = "label3";
            // 
            // Lbl_Email_Emissor
            // 
            this.Lbl_Email_Emissor.AutoSize = true;
            this.Lbl_Email_Emissor.Location = new System.Drawing.Point(6, 38);
            this.Lbl_Email_Emissor.Name = "Lbl_Email_Emissor";
            this.Lbl_Email_Emissor.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Email_Emissor.TabIndex = 1;
            this.Lbl_Email_Emissor.Text = "label2";
            // 
            // Lbl_Nome_Emissor
            // 
            this.Lbl_Nome_Emissor.AutoSize = true;
            this.Lbl_Nome_Emissor.Location = new System.Drawing.Point(6, 16);
            this.Lbl_Nome_Emissor.Name = "Lbl_Nome_Emissor";
            this.Lbl_Nome_Emissor.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nome_Emissor.TabIndex = 0;
            this.Lbl_Nome_Emissor.Text = "label1";
            // 
            // Gb_Dados_Cliente
            // 
            this.Gb_Dados_Cliente.Controls.Add(this.Lbl_Telefone_Cliente);
            this.Gb_Dados_Cliente.Controls.Add(this.Lbl_Email_Cliente);
            this.Gb_Dados_Cliente.Controls.Add(this.Lbl_Nome_Cliente);
            this.Gb_Dados_Cliente.Controls.Add(this.Mtbx_Telefone_Cliente);
            this.Gb_Dados_Cliente.Controls.Add(this.Tbx_Email_Cliente);
            this.Gb_Dados_Cliente.Controls.Add(this.Tbx_Nome_Cliente);
            this.Gb_Dados_Cliente.Location = new System.Drawing.Point(12, 111);
            this.Gb_Dados_Cliente.Name = "Gb_Dados_Cliente";
            this.Gb_Dados_Cliente.Size = new System.Drawing.Size(168, 155);
            this.Gb_Dados_Cliente.TabIndex = 1;
            this.Gb_Dados_Cliente.TabStop = false;
            this.Gb_Dados_Cliente.Text = "Cliente";
            // 
            // Lbl_Telefone_Cliente
            // 
            this.Lbl_Telefone_Cliente.AutoSize = true;
            this.Lbl_Telefone_Cliente.Location = new System.Drawing.Point(6, 103);
            this.Lbl_Telefone_Cliente.Name = "Lbl_Telefone_Cliente";
            this.Lbl_Telefone_Cliente.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Telefone_Cliente.TabIndex = 5;
            this.Lbl_Telefone_Cliente.Text = "Telefone";
            // 
            // Lbl_Email_Cliente
            // 
            this.Lbl_Email_Cliente.AutoSize = true;
            this.Lbl_Email_Cliente.Location = new System.Drawing.Point(6, 63);
            this.Lbl_Email_Cliente.Name = "Lbl_Email_Cliente";
            this.Lbl_Email_Cliente.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Email_Cliente.TabIndex = 4;
            this.Lbl_Email_Cliente.Text = "E-mail";
            this.Lbl_Email_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Nome_Cliente
            // 
            this.Lbl_Nome_Cliente.AutoSize = true;
            this.Lbl_Nome_Cliente.Location = new System.Drawing.Point(6, 23);
            this.Lbl_Nome_Cliente.Name = "Lbl_Nome_Cliente";
            this.Lbl_Nome_Cliente.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nome_Cliente.TabIndex = 3;
            this.Lbl_Nome_Cliente.Text = "Nome";
            // 
            // Mtbx_Telefone_Cliente
            // 
            this.Mtbx_Telefone_Cliente.Location = new System.Drawing.Point(0, 119);
            this.Mtbx_Telefone_Cliente.Mask = "(00)0000-0000";
            this.Mtbx_Telefone_Cliente.Name = "Mtbx_Telefone_Cliente";
            this.Mtbx_Telefone_Cliente.Size = new System.Drawing.Size(169, 20);
            this.Mtbx_Telefone_Cliente.TabIndex = 2;
            this.Mtbx_Telefone_Cliente.TextChanged += new System.EventHandler(this.Mtbx_Telefone_Cliente_TextChanged);
            this.Mtbx_Telefone_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mtbx_Telefone_Cliente_KeyPress);
            // 
            // Tbx_Email_Cliente
            // 
            this.Tbx_Email_Cliente.Location = new System.Drawing.Point(0, 79);
            this.Tbx_Email_Cliente.Name = "Tbx_Email_Cliente";
            this.Tbx_Email_Cliente.Size = new System.Drawing.Size(169, 20);
            this.Tbx_Email_Cliente.TabIndex = 1;
            this.Tbx_Email_Cliente.TextChanged += new System.EventHandler(this.Tbx_Email_Cliente_TextChanged);
            this.Tbx_Email_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Email_Cliente_KeyPress);
            // 
            // Tbx_Nome_Cliente
            // 
            this.Tbx_Nome_Cliente.Location = new System.Drawing.Point(0, 39);
            this.Tbx_Nome_Cliente.Name = "Tbx_Nome_Cliente";
            this.Tbx_Nome_Cliente.Size = new System.Drawing.Size(169, 20);
            this.Tbx_Nome_Cliente.TabIndex = 0;
            this.Tbx_Nome_Cliente.TextChanged += new System.EventHandler(this.Tbx_Nome_Cliente_TextChanged);
            this.Tbx_Nome_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Nome_Cliente_KeyPress);
            // 
            // GB_Endereco_Cliente
            // 
            this.GB_Endereco_Cliente.Controls.Add(this.Lbl_Logradouro);
            this.GB_Endereco_Cliente.Controls.Add(this.Lbl_Bairro);
            this.GB_Endereco_Cliente.Controls.Add(this.Lbl_Cidade);
            this.GB_Endereco_Cliente.Controls.Add(this.Lbl_Estado);
            this.GB_Endereco_Cliente.Controls.Add(this.Lbl_Cep);
            this.GB_Endereco_Cliente.Controls.Add(this.Tbx_Logradouro_Cliente);
            this.GB_Endereco_Cliente.Controls.Add(this.Tbx_Bairro_Cliente);
            this.GB_Endereco_Cliente.Controls.Add(this.Tbx_Localidade_Cliente);
            this.GB_Endereco_Cliente.Controls.Add(this.Tbx_Estado_Cliente);
            this.GB_Endereco_Cliente.Controls.Add(this.Tbx_Cep_Cliente);
            this.GB_Endereco_Cliente.Location = new System.Drawing.Point(12, 272);
            this.GB_Endereco_Cliente.Name = "GB_Endereco_Cliente";
            this.GB_Endereco_Cliente.Size = new System.Drawing.Size(168, 247);
            this.GB_Endereco_Cliente.TabIndex = 2;
            this.GB_Endereco_Cliente.TabStop = false;
            this.GB_Endereco_Cliente.Text = "Endereco";
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(1, 205);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Logradouro.TabIndex = 11;
            this.Lbl_Logradouro.Text = "Logradouro";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(1, 159);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 10;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(1, 111);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Cidade.TabIndex = 9;
            this.Lbl_Cidade.Text = "Cidade";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(1, 69);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Estado.TabIndex = 8;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Location = new System.Drawing.Point(1, 22);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(26, 13);
            this.Lbl_Cep.TabIndex = 6;
            this.Lbl_Cep.Text = "Cep";
            // 
            // Tbx_Logradouro_Cliente
            // 
            this.Tbx_Logradouro_Cliente.Location = new System.Drawing.Point(-1, 221);
            this.Tbx_Logradouro_Cliente.Name = "Tbx_Logradouro_Cliente";
            this.Tbx_Logradouro_Cliente.Size = new System.Drawing.Size(170, 20);
            this.Tbx_Logradouro_Cliente.TabIndex = 7;
            // 
            // Tbx_Bairro_Cliente
            // 
            this.Tbx_Bairro_Cliente.Location = new System.Drawing.Point(-1, 175);
            this.Tbx_Bairro_Cliente.Name = "Tbx_Bairro_Cliente";
            this.Tbx_Bairro_Cliente.Size = new System.Drawing.Size(169, 20);
            this.Tbx_Bairro_Cliente.TabIndex = 6;
            // 
            // Tbx_Localidade_Cliente
            // 
            this.Tbx_Localidade_Cliente.Location = new System.Drawing.Point(-1, 127);
            this.Tbx_Localidade_Cliente.Name = "Tbx_Localidade_Cliente";
            this.Tbx_Localidade_Cliente.Size = new System.Drawing.Size(169, 20);
            this.Tbx_Localidade_Cliente.TabIndex = 5;
            // 
            // Tbx_Estado_Cliente
            // 
            this.Tbx_Estado_Cliente.Location = new System.Drawing.Point(0, 85);
            this.Tbx_Estado_Cliente.Name = "Tbx_Estado_Cliente";
            this.Tbx_Estado_Cliente.Size = new System.Drawing.Size(168, 20);
            this.Tbx_Estado_Cliente.TabIndex = 4;
            // 
            // Tbx_Cep_Cliente
            // 
            this.Tbx_Cep_Cliente.Location = new System.Drawing.Point(0, 38);
            this.Tbx_Cep_Cliente.Name = "Tbx_Cep_Cliente";
            this.Tbx_Cep_Cliente.Size = new System.Drawing.Size(168, 20);
            this.Tbx_Cep_Cliente.TabIndex = 3;
            this.Tbx_Cep_Cliente.TextChanged += new System.EventHandler(this.Tbx_Cep_Cliente_TextChanged);
            this.Tbx_Cep_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Cep_Cliente_KeyPress);
            this.Tbx_Cep_Cliente.Leave += new System.EventHandler(this.Tbx_Cep_Cliente_Leave);
            // 
            // Gb_Dados_Orcamento
            // 
            this.Gb_Dados_Orcamento.Controls.Add(this.label6);
            this.Gb_Dados_Orcamento.Controls.Add(this.Mtbx_Data_Orcamento);
            this.Gb_Dados_Orcamento.Controls.Add(this.Gb_Pagamento);
            this.Gb_Dados_Orcamento.Controls.Add(this.Gb_Garantia);
            this.Gb_Dados_Orcamento.Location = new System.Drawing.Point(187, 239);
            this.Gb_Dados_Orcamento.Name = "Gb_Dados_Orcamento";
            this.Gb_Dados_Orcamento.Size = new System.Drawing.Size(142, 280);
            this.Gb_Dados_Orcamento.TabIndex = 1;
            this.Gb_Dados_Orcamento.TabStop = false;
            this.Gb_Dados_Orcamento.Text = "Orcamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data";
            // 
            // Mtbx_Data_Orcamento
            // 
            this.Mtbx_Data_Orcamento.Location = new System.Drawing.Point(6, 35);
            this.Mtbx_Data_Orcamento.Mask = "00/00/0000";
            this.Mtbx_Data_Orcamento.Name = "Mtbx_Data_Orcamento";
            this.Mtbx_Data_Orcamento.Size = new System.Drawing.Size(100, 20);
            this.Mtbx_Data_Orcamento.TabIndex = 7;
            this.Mtbx_Data_Orcamento.ValidatingType = typeof(System.DateTime);
            this.Mtbx_Data_Orcamento.TextChanged += new System.EventHandler(this.Mtbx_Data_Orcamento_TextChanged);
            this.Mtbx_Data_Orcamento.Enter += new System.EventHandler(this.Mtbx_Data_Orcamento_Enter);
            // 
            // Gb_Pagamento
            // 
            this.Gb_Pagamento.Controls.Add(this.Rbtn_Dinheiro);
            this.Gb_Pagamento.Controls.Add(this.Rbtn_Cartao);
            this.Gb_Pagamento.Controls.Add(this.Rbtn_PIX);
            this.Gb_Pagamento.Location = new System.Drawing.Point(6, 61);
            this.Gb_Pagamento.Name = "Gb_Pagamento";
            this.Gb_Pagamento.Size = new System.Drawing.Size(93, 87);
            this.Gb_Pagamento.TabIndex = 4;
            this.Gb_Pagamento.TabStop = false;
            this.Gb_Pagamento.Text = "Pagamento";
            // 
            // Rbtn_Dinheiro
            // 
            this.Rbtn_Dinheiro.AutoSize = true;
            this.Rbtn_Dinheiro.Location = new System.Drawing.Point(4, 65);
            this.Rbtn_Dinheiro.Name = "Rbtn_Dinheiro";
            this.Rbtn_Dinheiro.Size = new System.Drawing.Size(56, 17);
            this.Rbtn_Dinheiro.TabIndex = 8;
            this.Rbtn_Dinheiro.TabStop = true;
            this.Rbtn_Dinheiro.Text = "Cartao";
            this.Rbtn_Dinheiro.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Cartao
            // 
            this.Rbtn_Cartao.AutoSize = true;
            this.Rbtn_Cartao.Location = new System.Drawing.Point(6, 42);
            this.Rbtn_Cartao.Name = "Rbtn_Cartao";
            this.Rbtn_Cartao.Size = new System.Drawing.Size(64, 17);
            this.Rbtn_Cartao.TabIndex = 7;
            this.Rbtn_Cartao.TabStop = true;
            this.Rbtn_Cartao.Text = "Dinheiro";
            this.Rbtn_Cartao.UseVisualStyleBackColor = true;
            // 
            // Rbtn_PIX
            // 
            this.Rbtn_PIX.AutoSize = true;
            this.Rbtn_PIX.Location = new System.Drawing.Point(6, 19);
            this.Rbtn_PIX.Name = "Rbtn_PIX";
            this.Rbtn_PIX.Size = new System.Drawing.Size(42, 17);
            this.Rbtn_PIX.TabIndex = 6;
            this.Rbtn_PIX.TabStop = true;
            this.Rbtn_PIX.Text = "PIX";
            this.Rbtn_PIX.UseVisualStyleBackColor = true;
            // 
            // Gb_Garantia
            // 
            this.Gb_Garantia.Controls.Add(this.Gb_Validade);
            this.Gb_Garantia.Controls.Add(this.Gb_PossuiGarantia);
            this.Gb_Garantia.Location = new System.Drawing.Point(6, 154);
            this.Gb_Garantia.Name = "Gb_Garantia";
            this.Gb_Garantia.Size = new System.Drawing.Size(123, 126);
            this.Gb_Garantia.TabIndex = 3;
            this.Gb_Garantia.TabStop = false;
            this.Gb_Garantia.Text = "Garantia";
            // 
            // Gb_Validade
            // 
            this.Gb_Validade.Controls.Add(this.Lbl_Validade_Garantia);
            this.Gb_Validade.Controls.Add(this.Mtbx_Validade_Orcamento);
            this.Gb_Validade.Location = new System.Drawing.Point(6, 69);
            this.Gb_Validade.Name = "Gb_Validade";
            this.Gb_Validade.Size = new System.Drawing.Size(110, 46);
            this.Gb_Validade.TabIndex = 8;
            this.Gb_Validade.TabStop = false;
            // 
            // Lbl_Validade_Garantia
            // 
            this.Lbl_Validade_Garantia.AutoSize = true;
            this.Lbl_Validade_Garantia.Location = new System.Drawing.Point(6, 7);
            this.Lbl_Validade_Garantia.Name = "Lbl_Validade_Garantia";
            this.Lbl_Validade_Garantia.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade_Garantia.TabIndex = 6;
            this.Lbl_Validade_Garantia.Text = "Validade";
            // 
            // Mtbx_Validade_Orcamento
            // 
            this.Mtbx_Validade_Orcamento.Location = new System.Drawing.Point(0, 22);
            this.Mtbx_Validade_Orcamento.Mask = "00/00/0000";
            this.Mtbx_Validade_Orcamento.Name = "Mtbx_Validade_Orcamento";
            this.Mtbx_Validade_Orcamento.Size = new System.Drawing.Size(100, 20);
            this.Mtbx_Validade_Orcamento.TabIndex = 3;
            this.Mtbx_Validade_Orcamento.ValidatingType = typeof(System.DateTime);
            this.Mtbx_Validade_Orcamento.TextChanged += new System.EventHandler(this.Mtbx_Validade_Orcamento_TextChanged);
            // 
            // Gb_PossuiGarantia
            // 
            this.Gb_PossuiGarantia.Controls.Add(this.Lbl_PossuiGarantia);
            this.Gb_PossuiGarantia.Controls.Add(this.Rbtn_SIM);
            this.Gb_PossuiGarantia.Controls.Add(this.Rbtn_NAO);
            this.Gb_PossuiGarantia.Location = new System.Drawing.Point(6, 19);
            this.Gb_PossuiGarantia.Name = "Gb_PossuiGarantia";
            this.Gb_PossuiGarantia.Size = new System.Drawing.Size(110, 46);
            this.Gb_PossuiGarantia.TabIndex = 7;
            this.Gb_PossuiGarantia.TabStop = false;
            // 
            // Lbl_PossuiGarantia
            // 
            this.Lbl_PossuiGarantia.AutoSize = true;
            this.Lbl_PossuiGarantia.Location = new System.Drawing.Point(6, 10);
            this.Lbl_PossuiGarantia.Name = "Lbl_PossuiGarantia";
            this.Lbl_PossuiGarantia.Size = new System.Drawing.Size(81, 13);
            this.Lbl_PossuiGarantia.TabIndex = 3;
            this.Lbl_PossuiGarantia.Text = "Possui Garantia";
            // 
            // Rbtn_SIM
            // 
            this.Rbtn_SIM.AutoSize = true;
            this.Rbtn_SIM.Location = new System.Drawing.Point(6, 27);
            this.Rbtn_SIM.Name = "Rbtn_SIM";
            this.Rbtn_SIM.Size = new System.Drawing.Size(44, 17);
            this.Rbtn_SIM.TabIndex = 4;
            this.Rbtn_SIM.Text = "SIM";
            this.Rbtn_SIM.UseVisualStyleBackColor = true;
            this.Rbtn_SIM.CheckedChanged += new System.EventHandler(this.Rbtn_SIM_CheckedChanged);
            // 
            // Rbtn_NAO
            // 
            this.Rbtn_NAO.AutoSize = true;
            this.Rbtn_NAO.Location = new System.Drawing.Point(56, 27);
            this.Rbtn_NAO.Name = "Rbtn_NAO";
            this.Rbtn_NAO.Size = new System.Drawing.Size(48, 17);
            this.Rbtn_NAO.TabIndex = 5;
            this.Rbtn_NAO.Text = "NAO";
            this.Rbtn_NAO.UseVisualStyleBackColor = true;
            this.Rbtn_NAO.CheckedChanged += new System.EventHandler(this.Rbtn_NAO_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_Total);
            this.groupBox1.Controls.Add(this.Pnl_Mostrar_Produtos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(335, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 489);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orçamento ";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(73, 350);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Total.TabIndex = 9;
            // 
            // Pnl_Mostrar_Produtos
            // 
            this.Pnl_Mostrar_Produtos.Location = new System.Drawing.Point(7, 16);
            this.Pnl_Mostrar_Produtos.Name = "Pnl_Mostrar_Produtos";
            this.Pnl_Mostrar_Produtos.Size = new System.Drawing.Size(269, 331);
            this.Pnl_Mostrar_Produtos.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MTbx_Valor_Produto);
            this.groupBox2.Controls.Add(this.Btn_Adicionar_Produto);
            this.groupBox2.Controls.Add(this.Lbl_Valor_Produto);
            this.groupBox2.Controls.Add(this.Lbl_Nome_Produto);
            this.groupBox2.Controls.Add(this.Tbx_Nome_Produto);
            this.groupBox2.Location = new System.Drawing.Point(6, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo Produto";
            // 
            // MTbx_Valor_Produto
            // 
            this.MTbx_Valor_Produto.Location = new System.Drawing.Point(0, 88);
            this.MTbx_Valor_Produto.Name = "MTbx_Valor_Produto";
            this.MTbx_Valor_Produto.Size = new System.Drawing.Size(175, 20);
            this.MTbx_Valor_Produto.TabIndex = 9;
            this.MTbx_Valor_Produto.TextChanged += new System.EventHandler(this.MTbx_Valor_Produto_TextChanged);
            this.MTbx_Valor_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTbx_Valor_Produto_KeyPress);
            // 
            // Btn_Adicionar_Produto
            // 
            this.Btn_Adicionar_Produto.Location = new System.Drawing.Point(181, 48);
            this.Btn_Adicionar_Produto.Name = "Btn_Adicionar_Produto";
            this.Btn_Adicionar_Produto.Size = new System.Drawing.Size(75, 53);
            this.Btn_Adicionar_Produto.TabIndex = 8;
            this.Btn_Adicionar_Produto.Text = "Adicionar Produto";
            this.Btn_Adicionar_Produto.UseVisualStyleBackColor = true;
            this.Btn_Adicionar_Produto.Click += new System.EventHandler(this.Btn_Adicionar_Produto_Click);
            // 
            // Lbl_Valor_Produto
            // 
            this.Lbl_Valor_Produto.AutoSize = true;
            this.Lbl_Valor_Produto.Location = new System.Drawing.Point(3, 72);
            this.Lbl_Valor_Produto.Name = "Lbl_Valor_Produto";
            this.Lbl_Valor_Produto.Size = new System.Drawing.Size(86, 13);
            this.Lbl_Valor_Produto.TabIndex = 8;
            this.Lbl_Valor_Produto.Text = "Valor do Produto";
            // 
            // Lbl_Nome_Produto
            // 
            this.Lbl_Nome_Produto.AutoSize = true;
            this.Lbl_Nome_Produto.Location = new System.Drawing.Point(3, 22);
            this.Lbl_Nome_Produto.Name = "Lbl_Nome_Produto";
            this.Lbl_Nome_Produto.Size = new System.Drawing.Size(90, 13);
            this.Lbl_Nome_Produto.TabIndex = 3;
            this.Lbl_Nome_Produto.Text = "Nome do Produto";
            // 
            // Tbx_Nome_Produto
            // 
            this.Tbx_Nome_Produto.Location = new System.Drawing.Point(0, 38);
            this.Tbx_Nome_Produto.Name = "Tbx_Nome_Produto";
            this.Tbx_Nome_Produto.Size = new System.Drawing.Size(175, 20);
            this.Tbx_Nome_Produto.TabIndex = 6;
            this.Tbx_Nome_Produto.TextChanged += new System.EventHandler(this.Tbx_Nome_Produto_TextChanged);
            this.Tbx_Nome_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Nome_Produto_KeyPress);
            // 
            // Btn_Deletar_Produto
            // 
            this.Btn_Deletar_Produto.Location = new System.Drawing.Point(197, 97);
            this.Btn_Deletar_Produto.Name = "Btn_Deletar_Produto";
            this.Btn_Deletar_Produto.Size = new System.Drawing.Size(132, 23);
            this.Btn_Deletar_Produto.TabIndex = 5;
            this.Btn_Deletar_Produto.Text = "Remover Ultimo Produto";
            this.Btn_Deletar_Produto.UseVisualStyleBackColor = true;
            this.Btn_Deletar_Produto.Click += new System.EventHandler(this.Btn_Deletar_Produto_Click);
            // 
            // Btn_SalvarPDF
            // 
            this.Btn_SalvarPDF.Location = new System.Drawing.Point(197, 68);
            this.Btn_SalvarPDF.Name = "Btn_SalvarPDF";
            this.Btn_SalvarPDF.Size = new System.Drawing.Size(132, 23);
            this.Btn_SalvarPDF.TabIndex = 6;
            this.Btn_SalvarPDF.Text = "Salvar em PDF";
            this.Btn_SalvarPDF.UseVisualStyleBackColor = true;
            this.Btn_SalvarPDF.Click += new System.EventHandler(this.Btn_SalvarPDF_Click);
            // 
            // Btn_Salvar_Orcamento
            // 
            this.Btn_Salvar_Orcamento.Location = new System.Drawing.Point(197, 41);
            this.Btn_Salvar_Orcamento.Name = "Btn_Salvar_Orcamento";
            this.Btn_Salvar_Orcamento.Size = new System.Drawing.Size(132, 23);
            this.Btn_Salvar_Orcamento.TabIndex = 7;
            this.Btn_Salvar_Orcamento.Text = "Salvar Orçamento";
            this.Btn_Salvar_Orcamento.UseVisualStyleBackColor = true;
            this.Btn_Salvar_Orcamento.Click += new System.EventHandler(this.Btn_Salvar_Orcamento_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Voltar,
            this.Tsb_Limpar,
            this.Tsb_SalvarPDF,
            this.Tsb_CarregarOrcamento});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsb_Voltar
            // 
            this.Tsb_Voltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Voltar.Image = global::WindowsFormsEstudoPessoal.Properties.Resources.SetaEquerda;
            this.Tsb_Voltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Voltar.Name = "Tsb_Voltar";
            this.Tsb_Voltar.Size = new System.Drawing.Size(23, 22);
            this.Tsb_Voltar.Text = "Voltar";
            this.Tsb_Voltar.Click += new System.EventHandler(this.Tsb_Voltar_Click);
            // 
            // Tsb_Limpar
            // 
            this.Tsb_Limpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Limpar.Image = global::WindowsFormsEstudoPessoal.Properties.Resources.Limpar;
            this.Tsb_Limpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Limpar.Name = "Tsb_Limpar";
            this.Tsb_Limpar.Size = new System.Drawing.Size(23, 22);
            this.Tsb_Limpar.Text = "Limpar";
            this.Tsb_Limpar.Click += new System.EventHandler(this.Tsb_Limpar_Click);
            // 
            // Tsb_SalvarPDF
            // 
            this.Tsb_SalvarPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_SalvarPDF.Image = global::WindowsFormsEstudoPessoal.Properties.Resources.PDF4;
            this.Tsb_SalvarPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_SalvarPDF.Name = "Tsb_SalvarPDF";
            this.Tsb_SalvarPDF.Size = new System.Drawing.Size(23, 22);
            this.Tsb_SalvarPDF.Text = "Salvar PDF";
            this.Tsb_SalvarPDF.Click += new System.EventHandler(this.Tsb_SalvarPDF_Click);
            // 
            // Tsb_CarregarOrcamento
            // 
            this.Tsb_CarregarOrcamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_CarregarOrcamento.Image = global::WindowsFormsEstudoPessoal.Properties.Resources.Carregar;
            this.Tsb_CarregarOrcamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_CarregarOrcamento.Name = "Tsb_CarregarOrcamento";
            this.Tsb_CarregarOrcamento.Size = new System.Drawing.Size(23, 22);
            this.Tsb_CarregarOrcamento.Text = "Carregar Orçamento ";
            this.Tsb_CarregarOrcamento.Click += new System.EventHandler(this.Tsb_CarregarOrcamento_Click);
            // 
            // Frm_Gerenciar_Orcamento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(633, 531);
            this.Controls.Add(this.Btn_Deletar_Produto);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Btn_Salvar_Orcamento);
            this.Controls.Add(this.Btn_SalvarPDF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gb_Dados_Orcamento);
            this.Controls.Add(this.GB_Endereco_Cliente);
            this.Controls.Add(this.Gb_Dados_Cliente);
            this.Controls.Add(this.GB_Dados_Emissor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Gerenciar_Orcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffebara Orçamentos - Gerenciador de Orçamento";
            this.GB_Dados_Emissor.ResumeLayout(false);
            this.GB_Dados_Emissor.PerformLayout();
            this.Gb_Dados_Cliente.ResumeLayout(false);
            this.Gb_Dados_Cliente.PerformLayout();
            this.GB_Endereco_Cliente.ResumeLayout(false);
            this.GB_Endereco_Cliente.PerformLayout();
            this.Gb_Dados_Orcamento.ResumeLayout(false);
            this.Gb_Dados_Orcamento.PerformLayout();
            this.Gb_Pagamento.ResumeLayout(false);
            this.Gb_Pagamento.PerformLayout();
            this.Gb_Garantia.ResumeLayout(false);
            this.Gb_Validade.ResumeLayout(false);
            this.Gb_Validade.PerformLayout();
            this.Gb_PossuiGarantia.ResumeLayout(false);
            this.Gb_PossuiGarantia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Dados_Emissor;
        private System.Windows.Forms.GroupBox Gb_Dados_Cliente;
        private System.Windows.Forms.GroupBox GB_Endereco_Cliente;
        private System.Windows.Forms.GroupBox Gb_Dados_Orcamento;
        private System.Windows.Forms.Label Lbl_Telefone_Emissor;
        private System.Windows.Forms.Label Lbl_Email_Emissor;
        private System.Windows.Forms.Label Lbl_Nome_Emissor;
        private System.Windows.Forms.MaskedTextBox Mtbx_Telefone_Cliente;
        private System.Windows.Forms.TextBox Tbx_Email_Cliente;
        private System.Windows.Forms.TextBox Tbx_Nome_Cliente;
        private System.Windows.Forms.GroupBox Gb_Garantia;
        private System.Windows.Forms.GroupBox Gb_Pagamento;
        private System.Windows.Forms.TextBox Tbx_Logradouro_Cliente;
        private System.Windows.Forms.TextBox Tbx_Bairro_Cliente;
        private System.Windows.Forms.TextBox Tbx_Localidade_Cliente;
        private System.Windows.Forms.TextBox Tbx_Estado_Cliente;
        private System.Windows.Forms.TextBox Tbx_Cep_Cliente;
        private System.Windows.Forms.RadioButton Rbtn_SIM;
        private System.Windows.Forms.RadioButton Rbtn_NAO;
        private System.Windows.Forms.Label Lbl_PossuiGarantia;
        private System.Windows.Forms.Label Lbl_Validade_Garantia;
        private System.Windows.Forms.MaskedTextBox Mtbx_Validade_Orcamento;
        private System.Windows.Forms.GroupBox Gb_Validade;
        private System.Windows.Forms.GroupBox Gb_PossuiGarantia;
        private System.Windows.Forms.MaskedTextBox Mtbx_Data_Orcamento;
        private System.Windows.Forms.RadioButton Rbtn_Dinheiro;
        private System.Windows.Forms.RadioButton Rbtn_Cartao;
        private System.Windows.Forms.RadioButton Rbtn_PIX;
        private System.Windows.Forms.Label Lbl_Telefone_Cliente;
        private System.Windows.Forms.Label Lbl_Email_Cliente;
        private System.Windows.Forms.Label Lbl_Nome_Cliente;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Cep;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Tbx_Nome_Produto;
        private System.Windows.Forms.Label Lbl_Valor_Produto;
        private System.Windows.Forms.Label Lbl_Nome_Produto;
        private System.Windows.Forms.Button Btn_Deletar_Produto;
        private System.Windows.Forms.Button Btn_SalvarPDF;
        private System.Windows.Forms.Button Btn_Salvar_Orcamento;
        private System.Windows.Forms.Button Btn_Adicionar_Produto;
        private System.Windows.Forms.FlowLayoutPanel Pnl_Mostrar_Produtos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MTbx_Valor_Produto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsb_Voltar;
        private System.Windows.Forms.ToolStripButton Tsb_Limpar;
        private System.Windows.Forms.ToolStripButton Tsb_SalvarPDF;
        private System.Windows.Forms.ToolStripButton Tsb_CarregarOrcamento;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Lbl_Total;
    }
}