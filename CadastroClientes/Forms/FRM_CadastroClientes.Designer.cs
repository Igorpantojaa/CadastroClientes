namespace CadastroClientes
{
    partial class FRM_CadastroClientes
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
            this.GP_Identificacao = new System.Windows.Forms.GroupBox();
            this.CHK_SemPaternidade = new System.Windows.Forms.CheckBox();
            this.TXB_DataNascimento = new System.Windows.Forms.TextBox();
            this.LBL_DataNascimento = new System.Windows.Forms.Label();
            this.TXB_RG = new System.Windows.Forms.TextBox();
            this.LBL_RG = new System.Windows.Forms.Label();
            this.TXB_NomePai = new System.Windows.Forms.TextBox();
            this.LBL_NomePai = new System.Windows.Forms.Label();
            this.TXB_NomeMae = new System.Windows.Forms.TextBox();
            this.LBL_NomeMae = new System.Windows.Forms.Label();
            this.LBL_Gemero = new System.Windows.Forms.Label();
            this.TXB_CPF = new System.Windows.Forms.TextBox();
            this.LBL_CPF = new System.Windows.Forms.Label();
            this.TXB_Nome = new System.Windows.Forms.TextBox();
            this.LBL_Nome = new System.Windows.Forms.Label();
            this.GP_Endereco = new System.Windows.Forms.GroupBox();
            this.TXB_Cep = new System.Windows.Forms.TextBox();
            this.LBL_CEP = new System.Windows.Forms.Label();
            this.TXB_Estado = new System.Windows.Forms.TextBox();
            this.LBL_Estado = new System.Windows.Forms.Label();
            this.TXB_Complemento = new System.Windows.Forms.TextBox();
            this.LBL_Complemento = new System.Windows.Forms.Label();
            this.TXB_Numero = new System.Windows.Forms.TextBox();
            this.LBL_Numero = new System.Windows.Forms.Label();
            this.TXB_Municipio = new System.Windows.Forms.TextBox();
            this.LBL_Municipio = new System.Windows.Forms.Label();
            this.TXB_Bairro = new System.Windows.Forms.TextBox();
            this.LBL_Bairro = new System.Windows.Forms.Label();
            this.TXB_Logradouro = new System.Windows.Forms.TextBox();
            this.LBL_Logradouro = new System.Windows.Forms.Label();
            this.GP_Contatos = new System.Windows.Forms.GroupBox();
            this.TXB_OutroContato = new System.Windows.Forms.TextBox();
            this.LBL_Outro = new System.Windows.Forms.Label();
            this.TXB_Telefone = new System.Windows.Forms.TextBox();
            this.LBL_Telefone = new System.Windows.Forms.Label();
            this.TXB_Email = new System.Windows.Forms.TextBox();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.TXB_Celular = new System.Windows.Forms.TextBox();
            this.LBL_Celular = new System.Windows.Forms.Label();
            this.GP_Acoes = new System.Windows.Forms.GroupBox();
            this.BTN_Descartar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.CB_Genero = new System.Windows.Forms.ComboBox();
            this.GP_Identificacao.SuspendLayout();
            this.GP_Endereco.SuspendLayout();
            this.GP_Contatos.SuspendLayout();
            this.GP_Acoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GP_Identificacao
            // 
            this.GP_Identificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_Identificacao.Controls.Add(this.CB_Genero);
            this.GP_Identificacao.Controls.Add(this.CHK_SemPaternidade);
            this.GP_Identificacao.Controls.Add(this.TXB_DataNascimento);
            this.GP_Identificacao.Controls.Add(this.LBL_DataNascimento);
            this.GP_Identificacao.Controls.Add(this.TXB_RG);
            this.GP_Identificacao.Controls.Add(this.LBL_RG);
            this.GP_Identificacao.Controls.Add(this.TXB_NomePai);
            this.GP_Identificacao.Controls.Add(this.LBL_NomePai);
            this.GP_Identificacao.Controls.Add(this.TXB_NomeMae);
            this.GP_Identificacao.Controls.Add(this.LBL_NomeMae);
            this.GP_Identificacao.Controls.Add(this.LBL_Gemero);
            this.GP_Identificacao.Controls.Add(this.TXB_CPF);
            this.GP_Identificacao.Controls.Add(this.LBL_CPF);
            this.GP_Identificacao.Controls.Add(this.TXB_Nome);
            this.GP_Identificacao.Controls.Add(this.LBL_Nome);
            this.GP_Identificacao.Location = new System.Drawing.Point(12, 12);
            this.GP_Identificacao.Name = "GP_Identificacao";
            this.GP_Identificacao.Size = new System.Drawing.Size(774, 187);
            this.GP_Identificacao.TabIndex = 0;
            this.GP_Identificacao.TabStop = false;
            this.GP_Identificacao.Text = "Informações Pessoais";
            // 
            // CHK_SemPaternidade
            // 
            this.CHK_SemPaternidade.AutoSize = true;
            this.CHK_SemPaternidade.Location = new System.Drawing.Point(8, 144);
            this.CHK_SemPaternidade.Name = "CHK_SemPaternidade";
            this.CHK_SemPaternidade.Size = new System.Drawing.Size(96, 17);
            this.CHK_SemPaternidade.TabIndex = 4;
            this.CHK_SemPaternidade.Text = "Não declarado";
            this.CHK_SemPaternidade.UseVisualStyleBackColor = true;
            this.CHK_SemPaternidade.CheckedChanged += new System.EventHandler(this.CHK_SemPaternidade_CheckedChanged);
            // 
            // TXB_DataNascimento
            // 
            this.TXB_DataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXB_DataNascimento.Location = new System.Drawing.Point(524, 117);
            this.TXB_DataNascimento.Name = "TXB_DataNascimento";
            this.TXB_DataNascimento.Size = new System.Drawing.Size(244, 20);
            this.TXB_DataNascimento.TabIndex = 7;
            // 
            // LBL_DataNascimento
            // 
            this.LBL_DataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_DataNascimento.AutoSize = true;
            this.LBL_DataNascimento.Location = new System.Drawing.Point(521, 100);
            this.LBL_DataNascimento.Name = "LBL_DataNascimento";
            this.LBL_DataNascimento.Size = new System.Drawing.Size(104, 13);
            this.LBL_DataNascimento.TabIndex = 18;
            this.LBL_DataNascimento.Text = "Data de Nascimento";
            // 
            // TXB_RG
            // 
            this.TXB_RG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXB_RG.Location = new System.Drawing.Point(524, 77);
            this.TXB_RG.Name = "TXB_RG";
            this.TXB_RG.Size = new System.Drawing.Size(244, 20);
            this.TXB_RG.TabIndex = 6;
            // 
            // LBL_RG
            // 
            this.LBL_RG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_RG.AutoSize = true;
            this.LBL_RG.Location = new System.Drawing.Point(521, 60);
            this.LBL_RG.Name = "LBL_RG";
            this.LBL_RG.Size = new System.Drawing.Size(23, 13);
            this.LBL_RG.TabIndex = 16;
            this.LBL_RG.Text = "RG";
            // 
            // TXB_NomePai
            // 
            this.TXB_NomePai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_NomePai.Location = new System.Drawing.Point(6, 117);
            this.TXB_NomePai.Name = "TXB_NomePai";
            this.TXB_NomePai.Size = new System.Drawing.Size(501, 20);
            this.TXB_NomePai.TabIndex = 3;
            // 
            // LBL_NomePai
            // 
            this.LBL_NomePai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_NomePai.AutoSize = true;
            this.LBL_NomePai.Location = new System.Drawing.Point(5, 100);
            this.LBL_NomePai.Name = "LBL_NomePai";
            this.LBL_NomePai.Size = new System.Drawing.Size(68, 13);
            this.LBL_NomePai.TabIndex = 14;
            this.LBL_NomePai.Text = "Nome do Pai";
            // 
            // TXB_NomeMae
            // 
            this.TXB_NomeMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_NomeMae.Location = new System.Drawing.Point(6, 77);
            this.TXB_NomeMae.Name = "TXB_NomeMae";
            this.TXB_NomeMae.Size = new System.Drawing.Size(501, 20);
            this.TXB_NomeMae.TabIndex = 2;
            // 
            // LBL_NomeMae
            // 
            this.LBL_NomeMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_NomeMae.AutoSize = true;
            this.LBL_NomeMae.Location = new System.Drawing.Point(5, 60);
            this.LBL_NomeMae.Name = "LBL_NomeMae";
            this.LBL_NomeMae.Size = new System.Drawing.Size(74, 13);
            this.LBL_NomeMae.TabIndex = 10;
            this.LBL_NomeMae.Text = "Nome da Mãe";
            // 
            // LBL_Gemero
            // 
            this.LBL_Gemero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Gemero.AutoSize = true;
            this.LBL_Gemero.Location = new System.Drawing.Point(521, 140);
            this.LBL_Gemero.Name = "LBL_Gemero";
            this.LBL_Gemero.Size = new System.Drawing.Size(42, 13);
            this.LBL_Gemero.TabIndex = 8;
            this.LBL_Gemero.Text = "Gênero";
            // 
            // TXB_CPF
            // 
            this.TXB_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_CPF.Location = new System.Drawing.Point(524, 37);
            this.TXB_CPF.Name = "TXB_CPF";
            this.TXB_CPF.Size = new System.Drawing.Size(244, 20);
            this.TXB_CPF.TabIndex = 5;
            // 
            // LBL_CPF
            // 
            this.LBL_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CPF.AutoSize = true;
            this.LBL_CPF.Location = new System.Drawing.Point(521, 20);
            this.LBL_CPF.Name = "LBL_CPF";
            this.LBL_CPF.Size = new System.Drawing.Size(27, 13);
            this.LBL_CPF.TabIndex = 6;
            this.LBL_CPF.Text = "CPF";
            // 
            // TXB_Nome
            // 
            this.TXB_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXB_Nome.Location = new System.Drawing.Point(6, 37);
            this.TXB_Nome.Name = "TXB_Nome";
            this.TXB_Nome.Size = new System.Drawing.Size(501, 20);
            this.TXB_Nome.TabIndex = 1;
            // 
            // LBL_Nome
            // 
            this.LBL_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Nome.AutoSize = true;
            this.LBL_Nome.Location = new System.Drawing.Point(5, 20);
            this.LBL_Nome.Name = "LBL_Nome";
            this.LBL_Nome.Size = new System.Drawing.Size(85, 13);
            this.LBL_Nome.TabIndex = 0;
            this.LBL_Nome.Text = "Nome do Cliente";
            // 
            // GP_Endereco
            // 
            this.GP_Endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_Endereco.Controls.Add(this.TXB_Cep);
            this.GP_Endereco.Controls.Add(this.LBL_CEP);
            this.GP_Endereco.Controls.Add(this.TXB_Estado);
            this.GP_Endereco.Controls.Add(this.LBL_Estado);
            this.GP_Endereco.Controls.Add(this.TXB_Complemento);
            this.GP_Endereco.Controls.Add(this.LBL_Complemento);
            this.GP_Endereco.Controls.Add(this.TXB_Numero);
            this.GP_Endereco.Controls.Add(this.LBL_Numero);
            this.GP_Endereco.Controls.Add(this.TXB_Municipio);
            this.GP_Endereco.Controls.Add(this.LBL_Municipio);
            this.GP_Endereco.Controls.Add(this.TXB_Bairro);
            this.GP_Endereco.Controls.Add(this.LBL_Bairro);
            this.GP_Endereco.Controls.Add(this.TXB_Logradouro);
            this.GP_Endereco.Controls.Add(this.LBL_Logradouro);
            this.GP_Endereco.Location = new System.Drawing.Point(12, 210);
            this.GP_Endereco.Name = "GP_Endereco";
            this.GP_Endereco.Size = new System.Drawing.Size(774, 148);
            this.GP_Endereco.TabIndex = 12;
            this.GP_Endereco.TabStop = false;
            this.GP_Endereco.Text = "Endereço";
            // 
            // TXB_Cep
            // 
            this.TXB_Cep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_Cep.Location = new System.Drawing.Point(8, 32);
            this.TXB_Cep.Name = "TXB_Cep";
            this.TXB_Cep.Size = new System.Drawing.Size(129, 20);
            this.TXB_Cep.TabIndex = 9;
            this.TXB_Cep.Leave += new System.EventHandler(this.TXB_Cep_Leave);
            // 
            // LBL_CEP
            // 
            this.LBL_CEP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CEP.AutoSize = true;
            this.LBL_CEP.Location = new System.Drawing.Point(5, 16);
            this.LBL_CEP.Name = "LBL_CEP";
            this.LBL_CEP.Size = new System.Drawing.Size(28, 13);
            this.LBL_CEP.TabIndex = 16;
            this.LBL_CEP.Text = "CEP";
            // 
            // TXB_Estado
            // 
            this.TXB_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_Estado.Location = new System.Drawing.Point(409, 117);
            this.TXB_Estado.Name = "TXB_Estado";
            this.TXB_Estado.Size = new System.Drawing.Size(359, 20);
            this.TXB_Estado.TabIndex = 15;
            // 
            // LBL_Estado
            // 
            this.LBL_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Estado.AutoSize = true;
            this.LBL_Estado.Location = new System.Drawing.Point(408, 100);
            this.LBL_Estado.Name = "LBL_Estado";
            this.LBL_Estado.Size = new System.Drawing.Size(63, 13);
            this.LBL_Estado.TabIndex = 10;
            this.LBL_Estado.Text = "Estado (UF)";
            // 
            // TXB_Complemento
            // 
            this.TXB_Complemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_Complemento.Location = new System.Drawing.Point(409, 77);
            this.TXB_Complemento.Name = "TXB_Complemento";
            this.TXB_Complemento.Size = new System.Drawing.Size(359, 20);
            this.TXB_Complemento.TabIndex = 13;
            // 
            // LBL_Complemento
            // 
            this.LBL_Complemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Complemento.AutoSize = true;
            this.LBL_Complemento.Location = new System.Drawing.Point(408, 60);
            this.LBL_Complemento.Name = "LBL_Complemento";
            this.LBL_Complemento.Size = new System.Drawing.Size(71, 13);
            this.LBL_Complemento.TabIndex = 8;
            this.LBL_Complemento.Text = "Complemento";
            // 
            // TXB_Numero
            // 
            this.TXB_Numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_Numero.Location = new System.Drawing.Point(672, 32);
            this.TXB_Numero.Name = "TXB_Numero";
            this.TXB_Numero.Size = new System.Drawing.Size(96, 20);
            this.TXB_Numero.TabIndex = 11;
            // 
            // LBL_Numero
            // 
            this.LBL_Numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Numero.AutoSize = true;
            this.LBL_Numero.Location = new System.Drawing.Point(669, 15);
            this.LBL_Numero.Name = "LBL_Numero";
            this.LBL_Numero.Size = new System.Drawing.Size(44, 13);
            this.LBL_Numero.TabIndex = 6;
            this.LBL_Numero.Text = "Número";
            // 
            // TXB_Municipio
            // 
            this.TXB_Municipio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXB_Municipio.Location = new System.Drawing.Point(6, 117);
            this.TXB_Municipio.Name = "TXB_Municipio";
            this.TXB_Municipio.Size = new System.Drawing.Size(359, 20);
            this.TXB_Municipio.TabIndex = 14;
            // 
            // LBL_Municipio
            // 
            this.LBL_Municipio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Municipio.AutoSize = true;
            this.LBL_Municipio.Location = new System.Drawing.Point(5, 100);
            this.LBL_Municipio.Name = "LBL_Municipio";
            this.LBL_Municipio.Size = new System.Drawing.Size(54, 13);
            this.LBL_Municipio.TabIndex = 4;
            this.LBL_Municipio.Text = "Município";
            // 
            // TXB_Bairro
            // 
            this.TXB_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXB_Bairro.Location = new System.Drawing.Point(6, 77);
            this.TXB_Bairro.Name = "TXB_Bairro";
            this.TXB_Bairro.Size = new System.Drawing.Size(359, 20);
            this.TXB_Bairro.TabIndex = 12;
            // 
            // LBL_Bairro
            // 
            this.LBL_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Bairro.AutoSize = true;
            this.LBL_Bairro.Location = new System.Drawing.Point(5, 60);
            this.LBL_Bairro.Name = "LBL_Bairro";
            this.LBL_Bairro.Size = new System.Drawing.Size(34, 13);
            this.LBL_Bairro.TabIndex = 2;
            this.LBL_Bairro.Text = "Bairro";
            // 
            // TXB_Logradouro
            // 
            this.TXB_Logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXB_Logradouro.Location = new System.Drawing.Point(154, 32);
            this.TXB_Logradouro.Name = "TXB_Logradouro";
            this.TXB_Logradouro.Size = new System.Drawing.Size(501, 20);
            this.TXB_Logradouro.TabIndex = 10;
            // 
            // LBL_Logradouro
            // 
            this.LBL_Logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Logradouro.AutoSize = true;
            this.LBL_Logradouro.Location = new System.Drawing.Point(153, 15);
            this.LBL_Logradouro.Name = "LBL_Logradouro";
            this.LBL_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.LBL_Logradouro.TabIndex = 0;
            this.LBL_Logradouro.Text = "Logradouro";
            // 
            // GP_Contatos
            // 
            this.GP_Contatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_Contatos.Controls.Add(this.TXB_OutroContato);
            this.GP_Contatos.Controls.Add(this.LBL_Outro);
            this.GP_Contatos.Controls.Add(this.TXB_Telefone);
            this.GP_Contatos.Controls.Add(this.LBL_Telefone);
            this.GP_Contatos.Controls.Add(this.TXB_Email);
            this.GP_Contatos.Controls.Add(this.LBL_Email);
            this.GP_Contatos.Controls.Add(this.TXB_Celular);
            this.GP_Contatos.Controls.Add(this.LBL_Celular);
            this.GP_Contatos.Location = new System.Drawing.Point(12, 369);
            this.GP_Contatos.Name = "GP_Contatos";
            this.GP_Contatos.Size = new System.Drawing.Size(774, 112);
            this.GP_Contatos.TabIndex = 13;
            this.GP_Contatos.TabStop = false;
            this.GP_Contatos.Text = "Informações de Contato";
            // 
            // TXB_OutroContato
            // 
            this.TXB_OutroContato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_OutroContato.Location = new System.Drawing.Point(409, 77);
            this.TXB_OutroContato.Name = "TXB_OutroContato";
            this.TXB_OutroContato.Size = new System.Drawing.Size(359, 20);
            this.TXB_OutroContato.TabIndex = 19;
            // 
            // LBL_Outro
            // 
            this.LBL_Outro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Outro.AutoSize = true;
            this.LBL_Outro.Location = new System.Drawing.Point(408, 60);
            this.LBL_Outro.Name = "LBL_Outro";
            this.LBL_Outro.Size = new System.Drawing.Size(72, 13);
            this.LBL_Outro.TabIndex = 8;
            this.LBL_Outro.Text = "Outro contato";
            // 
            // TXB_Telefone
            // 
            this.TXB_Telefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_Telefone.Location = new System.Drawing.Point(409, 37);
            this.TXB_Telefone.Name = "TXB_Telefone";
            this.TXB_Telefone.Size = new System.Drawing.Size(359, 20);
            this.TXB_Telefone.TabIndex = 17;
            // 
            // LBL_Telefone
            // 
            this.LBL_Telefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Telefone.AutoSize = true;
            this.LBL_Telefone.Location = new System.Drawing.Point(408, 20);
            this.LBL_Telefone.Name = "LBL_Telefone";
            this.LBL_Telefone.Size = new System.Drawing.Size(49, 13);
            this.LBL_Telefone.TabIndex = 6;
            this.LBL_Telefone.Text = "Telefone";
            // 
            // TXB_Email
            // 
            this.TXB_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXB_Email.Location = new System.Drawing.Point(6, 77);
            this.TXB_Email.Name = "TXB_Email";
            this.TXB_Email.Size = new System.Drawing.Size(359, 20);
            this.TXB_Email.TabIndex = 18;
            // 
            // LBL_Email
            // 
            this.LBL_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Location = new System.Drawing.Point(5, 60);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(35, 13);
            this.LBL_Email.TabIndex = 2;
            this.LBL_Email.Text = "E-mail";
            // 
            // TXB_Celular
            // 
            this.TXB_Celular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TXB_Celular.Location = new System.Drawing.Point(6, 37);
            this.TXB_Celular.Name = "TXB_Celular";
            this.TXB_Celular.Size = new System.Drawing.Size(359, 20);
            this.TXB_Celular.TabIndex = 16;
            // 
            // LBL_Celular
            // 
            this.LBL_Celular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Celular.AutoSize = true;
            this.LBL_Celular.Location = new System.Drawing.Point(5, 20);
            this.LBL_Celular.Name = "LBL_Celular";
            this.LBL_Celular.Size = new System.Drawing.Size(39, 13);
            this.LBL_Celular.TabIndex = 0;
            this.LBL_Celular.Text = "Celular";
            // 
            // GP_Acoes
            // 
            this.GP_Acoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GP_Acoes.Controls.Add(this.BTN_Descartar);
            this.GP_Acoes.Controls.Add(this.BTN_Salvar);
            this.GP_Acoes.Location = new System.Drawing.Point(276, 487);
            this.GP_Acoes.Name = "GP_Acoes";
            this.GP_Acoes.Size = new System.Drawing.Size(243, 57);
            this.GP_Acoes.TabIndex = 14;
            this.GP_Acoes.TabStop = false;
            // 
            // BTN_Descartar
            // 
            this.BTN_Descartar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Descartar.Location = new System.Drawing.Point(126, 13);
            this.BTN_Descartar.Name = "BTN_Descartar";
            this.BTN_Descartar.Size = new System.Drawing.Size(111, 35);
            this.BTN_Descartar.TabIndex = 21;
            this.BTN_Descartar.Text = "Descartar";
            this.BTN_Descartar.UseVisualStyleBackColor = true;
            this.BTN_Descartar.Click += new System.EventHandler(this.BTN_Descartar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Salvar.Location = new System.Drawing.Point(6, 13);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(111, 35);
            this.BTN_Salvar.TabIndex = 20;
            this.BTN_Salvar.Text = "Salvar";
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // CB_Genero
            // 
            this.CB_Genero.FormattingEnabled = true;
            this.CB_Genero.Location = new System.Drawing.Point(524, 156);
            this.CB_Genero.Name = "CB_Genero";
            this.CB_Genero.Size = new System.Drawing.Size(244, 21);
            this.CB_Genero.TabIndex = 19;
            // 
            // FRM_CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 555);
            this.ControlBox = false;
            this.Controls.Add(this.GP_Acoes);
            this.Controls.Add(this.GP_Contatos);
            this.Controls.Add(this.GP_Endereco);
            this.Controls.Add(this.GP_Identificacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FRM_CadastroClientes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FRM_CadastroClientes_Load);
            this.GP_Identificacao.ResumeLayout(false);
            this.GP_Identificacao.PerformLayout();
            this.GP_Endereco.ResumeLayout(false);
            this.GP_Endereco.PerformLayout();
            this.GP_Contatos.ResumeLayout(false);
            this.GP_Contatos.PerformLayout();
            this.GP_Acoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GP_Identificacao;
        private System.Windows.Forms.TextBox TXB_NomeMae;
        private System.Windows.Forms.Label LBL_NomeMae;
        private System.Windows.Forms.Label LBL_Gemero;
        private System.Windows.Forms.TextBox TXB_CPF;
        private System.Windows.Forms.Label LBL_CPF;
        private System.Windows.Forms.TextBox TXB_Nome;
        private System.Windows.Forms.Label LBL_Nome;
        private System.Windows.Forms.GroupBox GP_Endereco;
        private System.Windows.Forms.TextBox TXB_Estado;
        private System.Windows.Forms.Label LBL_Estado;
        private System.Windows.Forms.TextBox TXB_Complemento;
        private System.Windows.Forms.Label LBL_Complemento;
        private System.Windows.Forms.TextBox TXB_Numero;
        private System.Windows.Forms.Label LBL_Numero;
        private System.Windows.Forms.TextBox TXB_Municipio;
        private System.Windows.Forms.Label LBL_Municipio;
        private System.Windows.Forms.TextBox TXB_Bairro;
        private System.Windows.Forms.Label LBL_Bairro;
        private System.Windows.Forms.TextBox TXB_Logradouro;
        private System.Windows.Forms.Label LBL_Logradouro;
        private System.Windows.Forms.GroupBox GP_Contatos;
        private System.Windows.Forms.TextBox TXB_OutroContato;
        private System.Windows.Forms.Label LBL_Outro;
        private System.Windows.Forms.TextBox TXB_Telefone;
        private System.Windows.Forms.Label LBL_Telefone;
        private System.Windows.Forms.TextBox TXB_Email;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.TextBox TXB_Celular;
        private System.Windows.Forms.Label LBL_Celular;
        private System.Windows.Forms.TextBox TXB_NomePai;
        private System.Windows.Forms.Label LBL_NomePai;
        private System.Windows.Forms.GroupBox GP_Acoes;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Descartar;
        private System.Windows.Forms.TextBox TXB_DataNascimento;
        private System.Windows.Forms.Label LBL_DataNascimento;
        private System.Windows.Forms.TextBox TXB_RG;
        private System.Windows.Forms.Label LBL_RG;
        private System.Windows.Forms.CheckBox CHK_SemPaternidade;
        private System.Windows.Forms.TextBox TXB_Cep;
        private System.Windows.Forms.Label LBL_CEP;
        private System.Windows.Forms.ComboBox CB_Genero;
    }
}