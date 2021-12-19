namespace os
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbProdutosCadastrados = new System.Windows.Forms.GroupBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.btnCalculadora = new System.Windows.Forms.PictureBox();
            this.panelExcluir = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.labelPrecoCusto = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.panelSalvar = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.panelCancelar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPrecoVenda = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.labelCalculadora = new System.Windows.Forms.Label();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbProdutosCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculadora)).BeginInit();
            this.panelExcluir.SuspendLayout();
            this.panelSalvar.SuspendLayout();
            this.panelCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.grbProdutosCadastrados);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.grbProdutos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 609);
            this.panel1.TabIndex = 0;
            // 
            // grbProdutosCadastrados
            // 
            this.grbProdutosCadastrados.Controls.Add(this.cbFiltro);
            this.grbProdutosCadastrados.Controls.Add(this.grdProdutos);
            this.grbProdutosCadastrados.Controls.Add(this.txtFiltro);
            this.grbProdutosCadastrados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProdutosCadastrados.ForeColor = System.Drawing.Color.White;
            this.grbProdutosCadastrados.Location = new System.Drawing.Point(15, 345);
            this.grbProdutosCadastrados.Name = "grbProdutosCadastrados";
            this.grbProdutosCadastrados.Size = new System.Drawing.Size(814, 254);
            this.grbProdutosCadastrados.TabIndex = 23;
            this.grbProdutosCadastrados.TabStop = false;
            this.grbProdutosCadastrados.Text = "Produtos Cadastradors";
            // 
            // cbFiltro
            // 
            this.cbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.ForeColor = System.Drawing.Color.White;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nome",
            "Marca",
            "Categoria",
            "Fornecedor"});
            this.cbFiltro.Location = new System.Drawing.Point(47, 34);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(72, 24);
            this.cbFiltro.TabIndex = 1;
            // 
            // grdProdutos
            // 
            this.grdProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProdutos.ColumnHeadersHeight = 30;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProdutos.EnableHeadersVisualStyles = false;
            this.grdProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.grdProdutos.Location = new System.Drawing.Point(47, 76);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.grdProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdutos.Size = new System.Drawing.Size(727, 160);
            this.grdProdutos.TabIndex = 15;
            this.grdProdutos.TabStop = false;
            this.grdProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.ForeColor = System.Drawing.Color.White;
            this.txtFiltro.Location = new System.Drawing.Point(127, 36);
            this.txtFiltro.MaxLength = 80;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(647, 22);
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
            this.txtCodigo.TabIndex = 21;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // grbProdutos
            // 
            this.grbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProdutos.Controls.Add(this.btnCalculadora);
            this.grbProdutos.Controls.Add(this.panelExcluir);
            this.grbProdutos.Controls.Add(this.labelPrecoCusto);
            this.grbProdutos.Controls.Add(this.txtCusto);
            this.grbProdutos.Controls.Add(this.panelSalvar);
            this.grbProdutos.Controls.Add(this.txtMarca);
            this.grbProdutos.Controls.Add(this.txtVenda);
            this.grbProdutos.Controls.Add(this.panelCancelar);
            this.grbProdutos.Controls.Add(this.txtNome);
            this.grbProdutos.Controls.Add(this.labelMarca);
            this.grbProdutos.Controls.Add(this.labelNome);
            this.grbProdutos.Controls.Add(this.labelPrecoVenda);
            this.grbProdutos.Controls.Add(this.cbFornecedor);
            this.grbProdutos.Controls.Add(this.cbCategoria);
            this.grbProdutos.Controls.Add(this.txtEstoque);
            this.grbProdutos.Controls.Add(this.labelCalculadora);
            this.grbProdutos.Controls.Add(this.labelEstoque);
            this.grbProdutos.Controls.Add(this.labelFornecedor);
            this.grbProdutos.Controls.Add(this.labelCategoria);
            this.grbProdutos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProdutos.ForeColor = System.Drawing.Color.White;
            this.grbProdutos.Location = new System.Drawing.Point(15, 36);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(814, 292);
            this.grbProdutos.TabIndex = 22;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "Gerenciar Produtos";
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.Location = new System.Drawing.Point(716, 118);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(46, 55);
            this.btnCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCalculadora.TabIndex = 71;
            this.btnCalculadora.TabStop = false;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // panelExcluir
            // 
            this.panelExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelExcluir.BackgroundImage")));
            this.panelExcluir.Controls.Add(this.btnExcluir);
            this.panelExcluir.Location = new System.Drawing.Point(584, 213);
            this.panelExcluir.Name = "panelExcluir";
            this.panelExcluir.Size = new System.Drawing.Size(190, 40);
            this.panelExcluir.TabIndex = 68;
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
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // labelPrecoCusto
            // 
            this.labelPrecoCusto.AutoSize = true;
            this.labelPrecoCusto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoCusto.Location = new System.Drawing.Point(347, 120);
            this.labelPrecoCusto.Name = "labelPrecoCusto";
            this.labelPrecoCusto.Size = new System.Drawing.Size(102, 16);
            this.labelPrecoCusto.TabIndex = 54;
            this.labelPrecoCusto.Text = "Preço de Custo:";
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusto.ForeColor = System.Drawing.Color.White;
            this.txtCusto.Location = new System.Drawing.Point(465, 118);
            this.txtCusto.MaxLength = 12;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(95, 22);
            this.txtCusto.TabIndex = 7;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            // 
            // panelSalvar
            // 
            this.panelSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSalvar.BackgroundImage")));
            this.panelSalvar.Controls.Add(this.btnSalvar);
            this.panelSalvar.Location = new System.Drawing.Point(138, 213);
            this.panelSalvar.Name = "panelSalvar";
            this.panelSalvar.Size = new System.Drawing.Size(190, 40);
            this.panelSalvar.TabIndex = 66;
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
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(137, 77);
            this.txtMarca.MaxLength = 60;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(424, 22);
            this.txtMarca.TabIndex = 4;
            // 
            // txtVenda
            // 
            this.txtVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVenda.ForeColor = System.Drawing.Color.White;
            this.txtVenda.Location = new System.Drawing.Point(466, 150);
            this.txtVenda.MaxLength = 12;
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(95, 22);
            this.txtVenda.TabIndex = 8;
            this.txtVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenda_KeyPress);
            // 
            // panelCancelar
            // 
            this.panelCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCancelar.BackgroundImage")));
            this.panelCancelar.Controls.Add(this.btnCancelar);
            this.panelCancelar.Location = new System.Drawing.Point(361, 213);
            this.panelCancelar.Name = "panelCancelar";
            this.panelCancelar.Size = new System.Drawing.Size(190, 40);
            this.panelCancelar.TabIndex = 67;
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
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(137, 39);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(424, 22);
            this.txtNome.TabIndex = 3;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(69, 80);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(48, 16);
            this.labelMarca.TabIndex = 64;
            this.labelMarca.Text = "Marca:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(71, 41);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 16);
            this.labelNome.TabIndex = 65;
            this.labelNome.Text = "Nome:";
            // 
            // labelPrecoVenda
            // 
            this.labelPrecoVenda.AutoSize = true;
            this.labelPrecoVenda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoVenda.ForeColor = System.Drawing.Color.White;
            this.labelPrecoVenda.Location = new System.Drawing.Point(347, 152);
            this.labelPrecoVenda.Name = "labelPrecoVenda";
            this.labelPrecoVenda.Size = new System.Drawing.Size(104, 16);
            this.labelPrecoVenda.TabIndex = 57;
            this.labelPrecoVenda.Text = "Preço de Venda:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFornecedor.DisplayMember = "nome_fornecedor";
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.ForeColor = System.Drawing.Color.White;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(137, 149);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(151, 24);
            this.cbFornecedor.TabIndex = 6;
            this.cbFornecedor.ValueMember = "id_fornecedor";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.ForeColor = System.Drawing.Color.White;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Outros",
            "Informática",
            "Telefonia",
            "Papelaria",
            "Acessórios"});
            this.cbCategoria.Location = new System.Drawing.Point(137, 118);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(151, 24);
            this.cbCategoria.TabIndex = 5;
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoque.ForeColor = System.Drawing.Color.White;
            this.txtEstoque.Location = new System.Drawing.Point(704, 39);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(70, 22);
            this.txtEstoque.TabIndex = 9;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            // 
            // labelCalculadora
            // 
            this.labelCalculadora.AutoSize = true;
            this.labelCalculadora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculadora.ForeColor = System.Drawing.Color.White;
            this.labelCalculadora.Location = new System.Drawing.Point(602, 120);
            this.labelCalculadora.Name = "labelCalculadora";
            this.labelCalculadora.Size = new System.Drawing.Size(80, 16);
            this.labelCalculadora.TabIndex = 53;
            this.labelCalculadora.Text = "Calculadora:";
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoque.ForeColor = System.Drawing.Color.White;
            this.labelEstoque.Location = new System.Drawing.Point(622, 41);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(60, 16);
            this.labelEstoque.TabIndex = 52;
            this.labelEstoque.Text = "Estoque:";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.ForeColor = System.Drawing.Color.White;
            this.labelFornecedor.Location = new System.Drawing.Point(40, 152);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(77, 16);
            this.labelFornecedor.TabIndex = 55;
            this.labelFornecedor.Text = "Fornecedor:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(50, 120);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(67, 16);
            this.labelCategoria.TabIndex = 51;
            this.labelCategoria.Text = "Categoria:";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(868, 633);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbProdutosCadastrados.ResumeLayout(false);
            this.grbProdutosCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.grbProdutos.ResumeLayout(false);
            this.grbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculadora)).EndInit();
            this.panelExcluir.ResumeLayout(false);
            this.panelSalvar.ResumeLayout(false);
            this.panelCancelar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbProdutosCadastrados;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.PictureBox btnCalculadora;
        private System.Windows.Forms.Panel panelExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label labelPrecoCusto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Panel panelSalvar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Panel panelCancelar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPrecoVenda;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label labelCalculadora;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}