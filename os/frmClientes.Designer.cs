namespace os
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grbClientesCadastrados = new System.Windows.Forms.GroupBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grbGerenciarClientes = new System.Windows.Forms.GroupBox();
            this.panelExcluir = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panelSalvar = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelCancelar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelTelefoneFixo = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbClientesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.grbGerenciarClientes.SuspendLayout();
            this.panelExcluir.SuspendLayout();
            this.panelSalvar.SuspendLayout();
            this.panelCancelar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbClientesCadastrados
            // 
            this.grbClientesCadastrados.Controls.Add(this.cbFiltro);
            this.grbClientesCadastrados.Controls.Add(this.grdClientes);
            this.grbClientesCadastrados.Controls.Add(this.txtFiltro);
            this.grbClientesCadastrados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbClientesCadastrados.ForeColor = System.Drawing.Color.White;
            this.grbClientesCadastrados.Location = new System.Drawing.Point(15, 345);
            this.grbClientesCadastrados.Name = "grbClientesCadastrados";
            this.grbClientesCadastrados.Size = new System.Drawing.Size(814, 254);
            this.grbClientesCadastrados.TabIndex = 19;
            this.grbClientesCadastrados.TabStop = false;
            this.grbClientesCadastrados.Text = "Clientes Cadastrados";
            // 
            // cbFiltro
            // 
            this.cbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.ForeColor = System.Drawing.Color.White;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.ItemHeight = 16;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nome",
            "Endereço",
            "Cidade",
            "Telefone",
            "Celular",
            "CPF/CNPJ"});
            this.cbFiltro.Location = new System.Drawing.Point(47, 34);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(72, 24);
            this.cbFiltro.TabIndex = 1;
            // 
            // grdClientes
            // 
            this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdClientes.ColumnHeadersHeight = 30;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdClientes.EnableHeadersVisualStyles = false;
            this.grdClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.grdClientes.Location = new System.Drawing.Point(47, 76);
            this.grdClientes.MultiSelect = false;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.grdClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(722, 160);
            this.grdClientes.TabIndex = 12;
            this.grdClientes.TabStop = false;
            this.grdClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.ForeColor = System.Drawing.Color.White;
            this.txtFiltro.Location = new System.Drawing.Point(127, 36);
            this.txtFiltro.MaxLength = 80;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(642, 22);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
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
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // grbGerenciarClientes
            // 
            this.grbGerenciarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbGerenciarClientes.Controls.Add(this.panelExcluir);
            this.grbGerenciarClientes.Controls.Add(this.panelSalvar);
            this.grbGerenciarClientes.Controls.Add(this.panelCancelar);
            this.grbGerenciarClientes.Controls.Add(this.txtCelular);
            this.grbGerenciarClientes.Controls.Add(this.txtTelefoneFixo);
            this.grbGerenciarClientes.Controls.Add(this.txtEndereco);
            this.grbGerenciarClientes.Controls.Add(this.txtCidade);
            this.grbGerenciarClientes.Controls.Add(this.txtBairro);
            this.grbGerenciarClientes.Controls.Add(this.txtEmail);
            this.grbGerenciarClientes.Controls.Add(this.txtCpfCnpj);
            this.grbGerenciarClientes.Controls.Add(this.txtNome);
            this.grbGerenciarClientes.Controls.Add(this.labelEndereco);
            this.grbGerenciarClientes.Controls.Add(this.labelEmail);
            this.grbGerenciarClientes.Controls.Add(this.labelCPFCNPJ);
            this.grbGerenciarClientes.Controls.Add(this.labelCelular);
            this.grbGerenciarClientes.Controls.Add(this.labelTelefoneFixo);
            this.grbGerenciarClientes.Controls.Add(this.labelCidade);
            this.grbGerenciarClientes.Controls.Add(this.labelBairro);
            this.grbGerenciarClientes.Controls.Add(this.labelNome);
            this.grbGerenciarClientes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGerenciarClientes.ForeColor = System.Drawing.Color.White;
            this.grbGerenciarClientes.Location = new System.Drawing.Point(15, 36);
            this.grbGerenciarClientes.Name = "grbGerenciarClientes";
            this.grbGerenciarClientes.Size = new System.Drawing.Size(814, 292);
            this.grbGerenciarClientes.TabIndex = 17;
            this.grbGerenciarClientes.TabStop = false;
            this.grbGerenciarClientes.Text = "Gerenciar Clientes";
            // 
            // panelExcluir
            // 
            this.panelExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelExcluir.BackgroundImage")));
            this.panelExcluir.Controls.Add(this.btnExcluir);
            this.panelExcluir.Location = new System.Drawing.Point(579, 213);
            this.panelExcluir.Name = "panelExcluir";
            this.panelExcluir.Size = new System.Drawing.Size(190, 40);
            this.panelExcluir.TabIndex = 45;
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
            // panelSalvar
            // 
            this.panelSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSalvar.BackgroundImage")));
            this.panelSalvar.Controls.Add(this.btnSalvar);
            this.panelSalvar.Location = new System.Drawing.Point(133, 213);
            this.panelSalvar.Name = "panelSalvar";
            this.panelSalvar.Size = new System.Drawing.Size(190, 40);
            this.panelSalvar.TabIndex = 43;
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
            this.panelCancelar.Location = new System.Drawing.Point(356, 213);
            this.panelCancelar.Name = "panelCancelar";
            this.panelCancelar.Size = new System.Drawing.Size(190, 40);
            this.panelCancelar.TabIndex = 44;
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
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.ForeColor = System.Drawing.Color.White;
            this.txtCelular.Location = new System.Drawing.Point(657, 77);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(114, 22);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefoneFixo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneFixo.ForeColor = System.Drawing.Color.White;
            this.txtTelefoneFixo.Location = new System.Drawing.Point(657, 39);
            this.txtTelefoneFixo.Mask = "(99) 0000-0000";
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Size = new System.Drawing.Size(114, 22);
            this.txtTelefoneFixo.TabIndex = 7;
            this.txtTelefoneFixo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.ForeColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(134, 77);
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
            this.txtCidade.Location = new System.Drawing.Point(134, 153);
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
            this.txtBairro.Location = new System.Drawing.Point(134, 115);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(333, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(657, 153);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(114, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpfCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfCnpj.ForeColor = System.Drawing.Color.White;
            this.txtCpfCnpj.Location = new System.Drawing.Point(657, 115);
            this.txtCpfCnpj.MaxLength = 14;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(114, 22);
            this.txtCpfCnpj.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(134, 39);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 22);
            this.txtNome.TabIndex = 3;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(44, 79);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(67, 16);
            this.labelEndereco.TabIndex = 28;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(584, 157);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 16);
            this.labelEmail.TabIndex = 29;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPFCNPJ.Location = new System.Drawing.Point(558, 118);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(75, 16);
            this.labelCPFCNPJ.TabIndex = 30;
            this.labelCPFCNPJ.Text = "CPF/CNPJ:";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelular.Location = new System.Drawing.Point(581, 80);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(52, 16);
            this.labelCelular.TabIndex = 31;
            this.labelCelular.Text = "Celular:";
            // 
            // labelTelefoneFixo
            // 
            this.labelTelefoneFixo.AutoSize = true;
            this.labelTelefoneFixo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefoneFixo.Location = new System.Drawing.Point(545, 41);
            this.labelTelefoneFixo.Name = "labelTelefoneFixo";
            this.labelTelefoneFixo.Size = new System.Drawing.Size(88, 16);
            this.labelTelefoneFixo.TabIndex = 32;
            this.labelTelefoneFixo.Text = "Telefone Fixo:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(59, 155);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(52, 16);
            this.labelCidade.TabIndex = 33;
            this.labelCidade.Text = "Cidade:";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(65, 117);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(46, 16);
            this.labelBairro.TabIndex = 34;
            this.labelBairro.Text = "Bairro:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(65, 41);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 16);
            this.labelNome.TabIndex = 35;
            this.labelNome.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.grbGerenciarClientes);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.grbClientesCadastrados);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 609);
            this.panel1.TabIndex = 0;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(868, 633);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.grbClientesCadastrados.ResumeLayout(false);
            this.grbClientesCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.grbGerenciarClientes.ResumeLayout(false);
            this.grbGerenciarClientes.PerformLayout();
            this.panelExcluir.ResumeLayout(false);
            this.panelSalvar.ResumeLayout(false);
            this.panelCancelar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox grbClientesCadastrados;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grbGerenciarClientes;
        private System.Windows.Forms.Panel panelExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panelSalvar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panelCancelar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFixo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Label labelTelefoneFixo;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panel1;
    }
}