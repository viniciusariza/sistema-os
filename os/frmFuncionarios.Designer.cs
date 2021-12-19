namespace os
{
    partial class frmFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grbFuncionariosCadastrados = new System.Windows.Forms.GroupBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.grdFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.grbFuncionarios = new System.Windows.Forms.GroupBox();
            this.dtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.chkSituacao = new System.Windows.Forms.CheckBox();
            this.panelExcluir = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelSituacao = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panelSalvar = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelCancelar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbFuncionariosCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionarios)).BeginInit();
            this.grbFuncionarios.SuspendLayout();
            this.panelExcluir.SuspendLayout();
            this.panelSalvar.SuspendLayout();
            this.panelCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.grbFuncionariosCadastrados);
            this.panel1.Controls.Add(this.grbFuncionarios);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 609);
            this.panel1.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(15, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(44, 20);
            this.txtCodigo.TabIndex = 20;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // grbFuncionariosCadastrados
            // 
            this.grbFuncionariosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFuncionariosCadastrados.Controls.Add(this.cbFiltro);
            this.grbFuncionariosCadastrados.Controls.Add(this.grdFuncionarios);
            this.grbFuncionariosCadastrados.Controls.Add(this.txtFiltro);
            this.grbFuncionariosCadastrados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFuncionariosCadastrados.ForeColor = System.Drawing.Color.White;
            this.grbFuncionariosCadastrados.Location = new System.Drawing.Point(15, 345);
            this.grbFuncionariosCadastrados.Name = "grbFuncionariosCadastrados";
            this.grbFuncionariosCadastrados.Size = new System.Drawing.Size(814, 254);
            this.grbFuncionariosCadastrados.TabIndex = 22;
            this.grbFuncionariosCadastrados.TabStop = false;
            this.grbFuncionariosCadastrados.Text = "Funcionários Cadastrados";
            // 
            // cbFiltro
            // 
            this.cbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.ForeColor = System.Drawing.Color.White;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nome",
            "Endereço",
            "Cidade",
            "Celular",
            "CPF/CNPJ"});
            this.cbFiltro.Location = new System.Drawing.Point(47, 34);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(72, 24);
            this.cbFiltro.TabIndex = 1;
            // 
            // grdFuncionarios
            // 
            this.grdFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFuncionarios.ColumnHeadersHeight = 30;
            this.grdFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdFuncionarios.EnableHeadersVisualStyles = false;
            this.grdFuncionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.grdFuncionarios.Location = new System.Drawing.Point(47, 76);
            this.grdFuncionarios.MultiSelect = false;
            this.grdFuncionarios.Name = "grdFuncionarios";
            this.grdFuncionarios.ReadOnly = true;
            this.grdFuncionarios.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.grdFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFuncionarios.Size = new System.Drawing.Size(723, 160);
            this.grdFuncionarios.TabIndex = 15;
            this.grdFuncionarios.TabStop = false;
            this.grdFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFuncionarios_CellClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.ForeColor = System.Drawing.Color.White;
            this.txtFiltro.Location = new System.Drawing.Point(127, 36);
            this.txtFiltro.MaxLength = 80;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(643, 22);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // grbFuncionarios
            // 
            this.grbFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFuncionarios.Controls.Add(this.dtAdmissao);
            this.grbFuncionarios.Controls.Add(this.chkSituacao);
            this.grbFuncionarios.Controls.Add(this.panelExcluir);
            this.grbFuncionarios.Controls.Add(this.txtCelular);
            this.grbFuncionarios.Controls.Add(this.txtEndereco);
            this.grbFuncionarios.Controls.Add(this.txtCidade);
            this.grbFuncionarios.Controls.Add(this.txtBairro);
            this.grbFuncionarios.Controls.Add(this.txtCpfCnpj);
            this.grbFuncionarios.Controls.Add(this.txtNome);
            this.grbFuncionarios.Controls.Add(this.labelEndereco);
            this.grbFuncionarios.Controls.Add(this.labelSituacao);
            this.grbFuncionarios.Controls.Add(this.labelData);
            this.grbFuncionarios.Controls.Add(this.labelCPFCNPJ);
            this.grbFuncionarios.Controls.Add(this.labelCelular);
            this.grbFuncionarios.Controls.Add(this.labelCidade);
            this.grbFuncionarios.Controls.Add(this.labelBairro);
            this.grbFuncionarios.Controls.Add(this.labelNome);
            this.grbFuncionarios.Controls.Add(this.panelSalvar);
            this.grbFuncionarios.Controls.Add(this.panelCancelar);
            this.grbFuncionarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFuncionarios.ForeColor = System.Drawing.Color.White;
            this.grbFuncionarios.Location = new System.Drawing.Point(15, 36);
            this.grbFuncionarios.Name = "grbFuncionarios";
            this.grbFuncionarios.Size = new System.Drawing.Size(814, 292);
            this.grbFuncionarios.TabIndex = 21;
            this.grbFuncionarios.TabStop = false;
            this.grbFuncionarios.Text = "Gerenciar Funcionários";
            // 
            // dtAdmissao
            // 
            this.dtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdmissao.Location = new System.Drawing.Point(653, 113);
            this.dtAdmissao.Name = "dtAdmissao";
            this.dtAdmissao.Size = new System.Drawing.Size(110, 22);
            this.dtAdmissao.TabIndex = 9;
            // 
            // chkSituacao
            // 
            this.chkSituacao.AutoSize = true;
            this.chkSituacao.Location = new System.Drawing.Point(653, 155);
            this.chkSituacao.Name = "chkSituacao";
            this.chkSituacao.Size = new System.Drawing.Size(59, 20);
            this.chkSituacao.TabIndex = 10;
            this.chkSituacao.Text = "Ativo";
            this.chkSituacao.UseVisualStyleBackColor = true;
            // 
            // panelExcluir
            // 
            this.panelExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelExcluir.BackgroundImage")));
            this.panelExcluir.Controls.Add(this.btnExcluir);
            this.panelExcluir.Location = new System.Drawing.Point(580, 214);
            this.panelExcluir.Name = "panelExcluir";
            this.panelExcluir.Size = new System.Drawing.Size(190, 40);
            this.panelExcluir.TabIndex = 54;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(0, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(190, 40);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.ForeColor = System.Drawing.Color.White;
            this.txtCelular.Location = new System.Drawing.Point(653, 39);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(114, 22);
            this.txtCelular.TabIndex = 7;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.ForeColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(134, 78);
            this.txtEndereco.MaxLength = 120;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(333, 22);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.ForeColor = System.Drawing.Color.White;
            this.txtCidade.Location = new System.Drawing.Point(134, 154);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(333, 22);
            this.txtCidade.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.ForeColor = System.Drawing.Color.White;
            this.txtBairro.Location = new System.Drawing.Point(134, 116);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(333, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpfCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfCnpj.ForeColor = System.Drawing.Color.White;
            this.txtCpfCnpj.Location = new System.Drawing.Point(653, 77);
            this.txtCpfCnpj.MaxLength = 14;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(114, 22);
            this.txtCpfCnpj.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(134, 40);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 22);
            this.txtNome.TabIndex = 3;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(44, 80);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(67, 16);
            this.labelEndereco.TabIndex = 36;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelSituacao
            // 
            this.labelSituacao.AutoSize = true;
            this.labelSituacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSituacao.Location = new System.Drawing.Point(566, 156);
            this.labelSituacao.Name = "labelSituacao";
            this.labelSituacao.Size = new System.Drawing.Size(63, 16);
            this.labelSituacao.TabIndex = 40;
            this.labelSituacao.Text = "Situação:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(511, 117);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(118, 16);
            this.labelData.TabIndex = 41;
            this.labelData.Text = "Data de Admissão:";
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPFCNPJ.Location = new System.Drawing.Point(591, 80);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(38, 16);
            this.labelCPFCNPJ.TabIndex = 42;
            this.labelCPFCNPJ.Text = "CPF:";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelular.Location = new System.Drawing.Point(577, 42);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(52, 16);
            this.labelCelular.TabIndex = 43;
            this.labelCelular.Text = "Celular:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(59, 156);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(52, 16);
            this.labelCidade.TabIndex = 44;
            this.labelCidade.Text = "Cidade:";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(65, 118);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(46, 16);
            this.labelBairro.TabIndex = 39;
            this.labelBairro.Text = "Bairro:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(65, 42);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 16);
            this.labelNome.TabIndex = 37;
            this.labelNome.Text = "Nome:";
            // 
            // panelSalvar
            // 
            this.panelSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSalvar.BackgroundImage")));
            this.panelSalvar.Controls.Add(this.btnSalvar);
            this.panelSalvar.Location = new System.Drawing.Point(134, 214);
            this.panelSalvar.Name = "panelSalvar";
            this.panelSalvar.Size = new System.Drawing.Size(190, 40);
            this.panelSalvar.TabIndex = 52;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(190, 40);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panelCancelar
            // 
            this.panelCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCancelar.BackgroundImage")));
            this.panelCancelar.Controls.Add(this.btnCancelar);
            this.panelCancelar.Location = new System.Drawing.Point(357, 214);
            this.panelCancelar.Name = "panelCancelar";
            this.panelCancelar.Size = new System.Drawing.Size(190, 40);
            this.panelCancelar.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(868, 633);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbFuncionariosCadastrados.ResumeLayout(false);
            this.grbFuncionariosCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionarios)).EndInit();
            this.grbFuncionarios.ResumeLayout(false);
            this.grbFuncionarios.PerformLayout();
            this.panelExcluir.ResumeLayout(false);
            this.panelSalvar.ResumeLayout(false);
            this.panelCancelar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grbFuncionariosCadastrados;
        private System.Windows.Forms.GroupBox grbFuncionarios;
        private System.Windows.Forms.CheckBox chkSituacao;
        private System.Windows.Forms.Panel panelExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelSituacao;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panelSalvar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panelCancelar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridView grdFuncionarios;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DateTimePicker dtAdmissao;
    }
}