namespace CadastroClientes
{
    partial class FRM_Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TB_Clientes = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseClientesDataSet = new CadastroClientes.BaseClientesDataSet();
            this.GP_TabelaClientes = new System.Windows.Forms.GroupBox();
            this.GP_Previa = new System.Windows.Forms.GroupBox();
            this.TXB_Telefone = new System.Windows.Forms.TextBox();
            this.LBL_Telefone = new System.Windows.Forms.Label();
            this.TXB_Cidade = new System.Windows.Forms.TextBox();
            this.LBL_Cidade = new System.Windows.Forms.Label();
            this.TXB_Email = new System.Windows.Forms.TextBox();
            this.TXB_Celular = new System.Windows.Forms.TextBox();
            this.TXB_Endereco = new System.Windows.Forms.TextBox();
            this.TXB_Nome = new System.Windows.Forms.TextBox();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_Celular = new System.Windows.Forms.Label();
            this.LBL_Endereco = new System.Windows.Forms.Label();
            this.LBL_Nome = new System.Windows.Forms.Label();
            this.GP_Acoes = new System.Windows.Forms.GroupBox();
            this.BTN_Excluir = new System.Windows.Forms.Button();
            this.BTN_Abrir = new System.Windows.Forms.Button();
            this.BTN_Novo = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new CadastroClientes.BaseClientesDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseClientesDataSet)).BeginInit();
            this.GP_TabelaClientes.SuspendLayout();
            this.GP_Previa.SuspendLayout();
            this.GP_Acoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Clientes
            // 
            this.TB_Clientes.AllowUserToAddRows = false;
            this.TB_Clientes.AllowUserToDeleteRows = false;
            this.TB_Clientes.AllowUserToResizeColumns = false;
            this.TB_Clientes.AllowUserToResizeRows = false;
            this.TB_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Clientes.AutoGenerateColumns = false;
            this.TB_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TB_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TB_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TB_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.TB_Clientes.DataSource = this.clientesBindingSource;
            this.TB_Clientes.Location = new System.Drawing.Point(0, 19);
            this.TB_Clientes.MultiSelect = false;
            this.TB_Clientes.Name = "TB_Clientes";
            this.TB_Clientes.ReadOnly = true;
            this.TB_Clientes.RowHeadersVisible = false;
            this.TB_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TB_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TB_Clientes.Size = new System.Drawing.Size(369, 170);
            this.TB_Clientes.TabIndex = 0;
            this.TB_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TB_Clientes_CellContentClick);
            this.TB_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TB_Clientes_CellContentClick);
            this.TB_Clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TB_Clientes_CellContentDoubleClick);
            this.TB_Clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TB_Clientes_CellContentDoubleClick);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idClienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idClienteDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 43;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.baseClientesDataSet;
            // 
            // baseClientesDataSet
            // 
            this.baseClientesDataSet.DataSetName = "BaseClientesDataSet";
            this.baseClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GP_TabelaClientes
            // 
            this.GP_TabelaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_TabelaClientes.Controls.Add(this.TB_Clientes);
            this.GP_TabelaClientes.Location = new System.Drawing.Point(12, 12);
            this.GP_TabelaClientes.Name = "GP_TabelaClientes";
            this.GP_TabelaClientes.Size = new System.Drawing.Size(375, 203);
            this.GP_TabelaClientes.TabIndex = 1;
            this.GP_TabelaClientes.TabStop = false;
            this.GP_TabelaClientes.Text = "Clientes";
            // 
            // GP_Previa
            // 
            this.GP_Previa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_Previa.Controls.Add(this.TXB_Telefone);
            this.GP_Previa.Controls.Add(this.LBL_Telefone);
            this.GP_Previa.Controls.Add(this.TXB_Cidade);
            this.GP_Previa.Controls.Add(this.LBL_Cidade);
            this.GP_Previa.Controls.Add(this.TXB_Email);
            this.GP_Previa.Controls.Add(this.TXB_Celular);
            this.GP_Previa.Controls.Add(this.TXB_Endereco);
            this.GP_Previa.Controls.Add(this.TXB_Nome);
            this.GP_Previa.Controls.Add(this.LBL_Email);
            this.GP_Previa.Controls.Add(this.LBL_Celular);
            this.GP_Previa.Controls.Add(this.LBL_Endereco);
            this.GP_Previa.Controls.Add(this.LBL_Nome);
            this.GP_Previa.Location = new System.Drawing.Point(12, 221);
            this.GP_Previa.Name = "GP_Previa";
            this.GP_Previa.Size = new System.Drawing.Size(531, 112);
            this.GP_Previa.TabIndex = 2;
            this.GP_Previa.TabStop = false;
            this.GP_Previa.Text = "Prévia do Cadastro";
            // 
            // TXB_Telefone
            // 
            this.TXB_Telefone.Location = new System.Drawing.Point(412, 48);
            this.TXB_Telefone.Name = "TXB_Telefone";
            this.TXB_Telefone.Size = new System.Drawing.Size(107, 20);
            this.TXB_Telefone.TabIndex = 17;
            // 
            // LBL_Telefone
            // 
            this.LBL_Telefone.AutoSize = true;
            this.LBL_Telefone.Location = new System.Drawing.Point(363, 51);
            this.LBL_Telefone.Name = "LBL_Telefone";
            this.LBL_Telefone.Size = new System.Drawing.Size(49, 13);
            this.LBL_Telefone.TabIndex = 16;
            this.LBL_Telefone.Text = "Telefone";
            // 
            // TXB_Cidade
            // 
            this.TXB_Cidade.Location = new System.Drawing.Point(75, 74);
            this.TXB_Cidade.Name = "TXB_Cidade";
            this.TXB_Cidade.Size = new System.Drawing.Size(269, 20);
            this.TXB_Cidade.TabIndex = 15;
            // 
            // LBL_Cidade
            // 
            this.LBL_Cidade.AutoSize = true;
            this.LBL_Cidade.Location = new System.Drawing.Point(6, 77);
            this.LBL_Cidade.Name = "LBL_Cidade";
            this.LBL_Cidade.Size = new System.Drawing.Size(63, 13);
            this.LBL_Cidade.TabIndex = 14;
            this.LBL_Cidade.Text = "Cidade - UF";
            // 
            // TXB_Email
            // 
            this.TXB_Email.Location = new System.Drawing.Point(412, 74);
            this.TXB_Email.Name = "TXB_Email";
            this.TXB_Email.Size = new System.Drawing.Size(107, 20);
            this.TXB_Email.TabIndex = 13;
            // 
            // TXB_Celular
            // 
            this.TXB_Celular.Location = new System.Drawing.Point(412, 22);
            this.TXB_Celular.Name = "TXB_Celular";
            this.TXB_Celular.Size = new System.Drawing.Size(107, 20);
            this.TXB_Celular.TabIndex = 12;
            // 
            // TXB_Endereco
            // 
            this.TXB_Endereco.Location = new System.Drawing.Point(75, 48);
            this.TXB_Endereco.Name = "TXB_Endereco";
            this.TXB_Endereco.Size = new System.Drawing.Size(269, 20);
            this.TXB_Endereco.TabIndex = 11;
            // 
            // TXB_Nome
            // 
            this.TXB_Nome.Location = new System.Drawing.Point(75, 22);
            this.TXB_Nome.Name = "TXB_Nome";
            this.TXB_Nome.Size = new System.Drawing.Size(269, 20);
            this.TXB_Nome.TabIndex = 10;
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Location = new System.Drawing.Point(364, 77);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(32, 13);
            this.LBL_Email.TabIndex = 3;
            this.LBL_Email.Text = "Email";
            // 
            // LBL_Celular
            // 
            this.LBL_Celular.AutoSize = true;
            this.LBL_Celular.Location = new System.Drawing.Point(364, 25);
            this.LBL_Celular.Name = "LBL_Celular";
            this.LBL_Celular.Size = new System.Drawing.Size(42, 13);
            this.LBL_Celular.TabIndex = 2;
            this.LBL_Celular.Text = "Celular:";
            // 
            // LBL_Endereco
            // 
            this.LBL_Endereco.AutoSize = true;
            this.LBL_Endereco.Location = new System.Drawing.Point(6, 51);
            this.LBL_Endereco.Name = "LBL_Endereco";
            this.LBL_Endereco.Size = new System.Drawing.Size(53, 13);
            this.LBL_Endereco.TabIndex = 1;
            this.LBL_Endereco.Text = "Endereço";
            // 
            // LBL_Nome
            // 
            this.LBL_Nome.AutoSize = true;
            this.LBL_Nome.Location = new System.Drawing.Point(6, 25);
            this.LBL_Nome.Name = "LBL_Nome";
            this.LBL_Nome.Size = new System.Drawing.Size(35, 13);
            this.LBL_Nome.TabIndex = 0;
            this.LBL_Nome.Text = "Nome";
            // 
            // GP_Acoes
            // 
            this.GP_Acoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_Acoes.Controls.Add(this.BTN_Excluir);
            this.GP_Acoes.Controls.Add(this.BTN_Abrir);
            this.GP_Acoes.Controls.Add(this.BTN_Novo);
            this.GP_Acoes.Location = new System.Drawing.Point(393, 12);
            this.GP_Acoes.Name = "GP_Acoes";
            this.GP_Acoes.Size = new System.Drawing.Size(150, 203);
            this.GP_Acoes.TabIndex = 2;
            this.GP_Acoes.TabStop = false;
            this.GP_Acoes.Text = "Opções";
            // 
            // BTN_Excluir
            // 
            this.BTN_Excluir.Location = new System.Drawing.Point(6, 132);
            this.BTN_Excluir.Name = "BTN_Excluir";
            this.BTN_Excluir.Size = new System.Drawing.Size(138, 44);
            this.BTN_Excluir.TabIndex = 3;
            this.BTN_Excluir.Text = "Excluir";
            this.BTN_Excluir.UseVisualStyleBackColor = true;
            this.BTN_Excluir.Click += new System.EventHandler(this.BTN_Excluir_Click);
            // 
            // BTN_Abrir
            // 
            this.BTN_Abrir.Location = new System.Drawing.Point(6, 82);
            this.BTN_Abrir.Name = "BTN_Abrir";
            this.BTN_Abrir.Size = new System.Drawing.Size(138, 44);
            this.BTN_Abrir.TabIndex = 1;
            this.BTN_Abrir.Text = "Exibir ";
            this.BTN_Abrir.UseVisualStyleBackColor = true;
            this.BTN_Abrir.Click += new System.EventHandler(this.BTN_Abrir_Click);
            // 
            // BTN_Novo
            // 
            this.BTN_Novo.Location = new System.Drawing.Point(6, 32);
            this.BTN_Novo.Name = "BTN_Novo";
            this.BTN_Novo.Size = new System.Drawing.Size(138, 44);
            this.BTN_Novo.TabIndex = 0;
            this.BTN_Novo.Text = "Novo";
            this.BTN_Novo.UseVisualStyleBackColor = true;
            this.BTN_Novo.Click += new System.EventHandler(this.BTN_Novo_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 345);
            this.Controls.Add(this.GP_Acoes);
            this.Controls.Add(this.GP_Previa);
            this.Controls.Add(this.GP_TabelaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRM_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.TB_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseClientesDataSet)).EndInit();
            this.GP_TabelaClientes.ResumeLayout(false);
            this.GP_Previa.ResumeLayout(false);
            this.GP_Previa.PerformLayout();
            this.GP_Acoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView TB_Clientes;
        private System.Windows.Forms.GroupBox GP_TabelaClientes;
        private System.Windows.Forms.GroupBox GP_Previa;
        private System.Windows.Forms.GroupBox GP_Acoes;
        private System.Windows.Forms.Button BTN_Excluir;
        private System.Windows.Forms.Button BTN_Abrir;
        private System.Windows.Forms.Button BTN_Novo;
        private BaseClientesDataSet baseClientesDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BaseClientesDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TXB_Email;
        private System.Windows.Forms.TextBox TXB_Celular;
        private System.Windows.Forms.TextBox TXB_Endereco;
        private System.Windows.Forms.TextBox TXB_Nome;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Celular;
        private System.Windows.Forms.Label LBL_Endereco;
        private System.Windows.Forms.Label LBL_Nome;
        private System.Windows.Forms.TextBox TXB_Telefone;
        private System.Windows.Forms.Label LBL_Telefone;
        private System.Windows.Forms.TextBox TXB_Cidade;
        private System.Windows.Forms.Label LBL_Cidade;
    }
}

