namespace os
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdVenda = new System.Windows.Forms.DataGridView();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtParcelmento = new System.Windows.Forms.Button();
            this.labelTotalParcela = new System.Windows.Forms.Label();
            this.grbNovaVenda = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.chkOrcamento = new System.Windows.Forms.RadioButton();
            this.chkVenda = new System.Windows.Forms.RadioButton();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConsultarVendas = new System.Windows.Forms.Button();
            this.cbParcelamento = new System.Windows.Forms.ComboBox();
            this.panelSalvar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelParcelamento = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.PictureBox();
            this.btnBuscarProduto = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.Button();
            this.btnDesconto = new System.Windows.Forms.PictureBox();
            this.btnAcrescimo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVenda)).BeginInit();
            this.panel3.SuspendLayout();
            this.grbNovaVenda.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelSalvar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProduto)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcrescimo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dtData);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtCodigoProduto);
            this.panel1.Controls.Add(this.txtCodigoCliente);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labelTotalParcela);
            this.panel1.Controls.Add(this.grbNovaVenda);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnDesconto);
            this.panel1.Controls.Add(this.btnAcrescimo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 594);
            this.panel1.TabIndex = 0;
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(188, 3);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(105, 20);
            this.dtData.TabIndex = 37;
            this.dtData.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.grdVenda);
            this.panel2.Location = new System.Drawing.Point(378, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 340);
            this.panel2.TabIndex = 38;
            // 
            // grdVenda
            // 
            this.grdVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.grdVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdVenda.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grdVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdVenda.EnableHeadersVisualStyles = false;
            this.grdVenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.grdVenda.Location = new System.Drawing.Point(10, 9);
            this.grdVenda.MultiSelect = false;
            this.grdVenda.Name = "grdVenda";
            this.grdVenda.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVenda.RowHeadersVisible = false;
            this.grdVenda.RowHeadersWidth = 70;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.grdVenda.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVenda.Size = new System.Drawing.Size(444, 320);
            this.grdVenda.TabIndex = 9;
            this.grdVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVenda_CellClick);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoProduto.Enabled = false;
            this.txtCodigoProduto.ForeColor = System.Drawing.Color.White;
            this.txtCodigoProduto.Location = new System.Drawing.Point(98, 3);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoProduto.TabIndex = 39;
            this.txtCodigoProduto.Visible = false;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCliente.Enabled = false;
            this.txtCodigoCliente.ForeColor = System.Drawing.Color.White;
            this.txtCodigoCliente.Location = new System.Drawing.Point(30, 3);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoCliente.TabIndex = 39;
            this.txtCodigoCliente.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.txtParcelmento);
            this.panel3.Location = new System.Drawing.Point(635, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 63);
            this.panel3.TabIndex = 42;
            // 
            // txtParcelmento
            // 
            this.txtParcelmento.BackColor = System.Drawing.Color.Transparent;
            this.txtParcelmento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtParcelmento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtParcelmento.FlatAppearance.BorderSize = 0;
            this.txtParcelmento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.txtParcelmento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.txtParcelmento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtParcelmento.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcelmento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtParcelmento.Location = new System.Drawing.Point(0, 0);
            this.txtParcelmento.Name = "txtParcelmento";
            this.txtParcelmento.Size = new System.Drawing.Size(182, 63);
            this.txtParcelmento.TabIndex = 6;
            this.txtParcelmento.UseVisualStyleBackColor = false;
            // 
            // labelTotalParcela
            // 
            this.labelTotalParcela.AutoSize = true;
            this.labelTotalParcela.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalParcela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotalParcela.Location = new System.Drawing.Point(434, 502);
            this.labelTotalParcela.Name = "labelTotalParcela";
            this.labelTotalParcela.Size = new System.Drawing.Size(195, 32);
            this.labelTotalParcela.TabIndex = 43;
            this.labelTotalParcela.Text = "Total Parcela:";
            // 
            // grbNovaVenda
            // 
            this.grbNovaVenda.Controls.Add(this.panel7);
            this.grbNovaVenda.Controls.Add(this.chkOrcamento);
            this.grbNovaVenda.Controls.Add(this.chkVenda);
            this.grbNovaVenda.Controls.Add(this.dtVencimento);
            this.grbNovaVenda.Controls.Add(this.panel5);
            this.grbNovaVenda.Controls.Add(this.panel4);
            this.grbNovaVenda.Controls.Add(this.cbParcelamento);
            this.grbNovaVenda.Controls.Add(this.panelSalvar);
            this.grbNovaVenda.Controls.Add(this.labelParcelamento);
            this.grbNovaVenda.Controls.Add(this.btnBuscarCliente);
            this.grbNovaVenda.Controls.Add(this.btnBuscarProduto);
            this.grbNovaVenda.Controls.Add(this.txtQuantidade);
            this.grbNovaVenda.Controls.Add(this.txtCliente);
            this.grbNovaVenda.Controls.Add(this.labelQuantidade);
            this.grbNovaVenda.Controls.Add(this.labelCliente);
            this.grbNovaVenda.Controls.Add(this.txtProduto);
            this.grbNovaVenda.Controls.Add(this.labelProduto);
            this.grbNovaVenda.Controls.Add(this.cbVendedor);
            this.grbNovaVenda.Controls.Add(this.labelVendedor);
            this.grbNovaVenda.Controls.Add(this.labelOperacao);
            this.grbNovaVenda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNovaVenda.ForeColor = System.Drawing.Color.White;
            this.grbNovaVenda.Location = new System.Drawing.Point(18, 27);
            this.grbNovaVenda.Name = "grbNovaVenda";
            this.grbNovaVenda.Size = new System.Drawing.Size(352, 524);
            this.grbNovaVenda.TabIndex = 36;
            this.grbNovaVenda.TabStop = false;
            this.grbNovaVenda.Text = "Nova Venda";
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Controls.Add(this.btnFinalizar);
            this.panel7.Location = new System.Drawing.Point(107, 338);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(203, 40);
            this.panel7.TabIndex = 32;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Location = new System.Drawing.Point(0, 0);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(203, 40);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // chkOrcamento
            // 
            this.chkOrcamento.AutoSize = true;
            this.chkOrcamento.Location = new System.Drawing.Point(214, 52);
            this.chkOrcamento.Name = "chkOrcamento";
            this.chkOrcamento.Size = new System.Drawing.Size(96, 20);
            this.chkOrcamento.TabIndex = 36;
            this.chkOrcamento.TabStop = true;
            this.chkOrcamento.Text = "Orçamento";
            this.chkOrcamento.UseVisualStyleBackColor = true;
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(107, 52);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(66, 20);
            this.chkVenda.TabIndex = 36;
            this.chkVenda.TabStop = true;
            this.chkVenda.Text = "Venda";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // dtVencimento
            // 
            this.dtVencimento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtVencimento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dtVencimento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.dtVencimento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtVencimento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(182, 139);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(128, 22);
            this.dtVencimento.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.btnAdicionar);
            this.panel5.Location = new System.Drawing.Point(170, 273);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 40);
            this.panel5.TabIndex = 30;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(140, 40);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.btnConsultarVendas);
            this.panel4.Location = new System.Drawing.Point(107, 470);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 40);
            this.panel4.TabIndex = 32;
            // 
            // btnConsultarVendas
            // 
            this.btnConsultarVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultarVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarVendas.FlatAppearance.BorderSize = 0;
            this.btnConsultarVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConsultarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVendas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVendas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarVendas.Location = new System.Drawing.Point(0, 0);
            this.btnConsultarVendas.Name = "btnConsultarVendas";
            this.btnConsultarVendas.Size = new System.Drawing.Size(203, 40);
            this.btnConsultarVendas.TabIndex = 8;
            this.btnConsultarVendas.Text = "Consultar";
            this.btnConsultarVendas.UseVisualStyleBackColor = false;
            this.btnConsultarVendas.Click += new System.EventHandler(this.btnConsultarVendas_Click);
            // 
            // cbParcelamento
            // 
            this.cbParcelamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbParcelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParcelamento.ForeColor = System.Drawing.Color.White;
            this.cbParcelamento.FormattingEnabled = true;
            this.cbParcelamento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "24",
            "36"});
            this.cbParcelamento.Location = new System.Drawing.Point(107, 138);
            this.cbParcelamento.Name = "cbParcelamento";
            this.cbParcelamento.Size = new System.Drawing.Size(49, 24);
            this.cbParcelamento.TabIndex = 2;
            this.cbParcelamento.SelectedIndexChanged += new System.EventHandler(this.cbParcelamento_SelectedIndexChanged);
            // 
            // panelSalvar
            // 
            this.panelSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSalvar.BackgroundImage")));
            this.panelSalvar.Controls.Add(this.btnCancelar);
            this.panelSalvar.Location = new System.Drawing.Point(107, 404);
            this.panelSalvar.Name = "panelSalvar";
            this.panelSalvar.Size = new System.Drawing.Size(203, 40);
            this.panelSalvar.TabIndex = 31;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelParcelamento
            // 
            this.labelParcelamento.AutoSize = true;
            this.labelParcelamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParcelamento.Location = new System.Drawing.Point(9, 141);
            this.labelParcelamento.Name = "labelParcelamento";
            this.labelParcelamento.Size = new System.Drawing.Size(92, 16);
            this.labelParcelamento.TabIndex = 32;
            this.labelParcelamento.Text = "Parcelamento:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(319, 183);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(22, 22);
            this.btnBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarCliente.TabIndex = 21;
            this.btnBuscarCliente.TabStop = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProduto.Image")));
            this.btnBuscarProduto.Location = new System.Drawing.Point(319, 226);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(22, 22);
            this.btnBuscarProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarProduto.TabIndex = 21;
            this.btnBuscarProduto.TabStop = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.ForeColor = System.Drawing.Color.White;
            this.txtQuantidade.Location = new System.Drawing.Point(107, 280);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(49, 22);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Enabled = false;
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(107, 183);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(203, 22);
            this.txtCliente.TabIndex = 3;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(23, 282);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(78, 16);
            this.labelQuantidade.TabIndex = 16;
            this.labelQuantidade.Text = "Quantidade:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(49, 185);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(52, 16);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente:";
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Enabled = false;
            this.txtProduto.ForeColor = System.Drawing.Color.White;
            this.txtProduto.Location = new System.Drawing.Point(107, 226);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(203, 22);
            this.txtProduto.TabIndex = 4;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.Location = new System.Drawing.Point(44, 228);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(57, 16);
            this.labelProduto.TabIndex = 16;
            this.labelProduto.Text = "Produto:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendedor.ForeColor = System.Drawing.Color.White;
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(107, 94);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(203, 24);
            this.cbVendedor.TabIndex = 0;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.Location = new System.Drawing.Point(35, 97);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(66, 16);
            this.labelVendedor.TabIndex = 0;
            this.labelVendedor.Text = "Vendedor:";
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperacao.Location = new System.Drawing.Point(33, 54);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(68, 16);
            this.labelOperacao.TabIndex = 0;
            this.labelOperacao.Text = "Operação:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotal.Location = new System.Drawing.Point(539, 411);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(90, 32);
            this.labelTotal.TabIndex = 41;
            this.labelTotal.Text = "Total:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.txtTotal);
            this.panel6.Location = new System.Drawing.Point(635, 396);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(182, 63);
            this.panel6.TabIndex = 40;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotal.FlatAppearance.BorderSize = 0;
            this.txtTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.txtTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.txtTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Location = new System.Drawing.Point(0, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(182, 63);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.UseVisualStyleBackColor = false;
            // 
            // btnDesconto
            // 
            this.btnDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnDesconto.Image")));
            this.btnDesconto.Location = new System.Drawing.Point(820, 428);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(22, 22);
            this.btnDesconto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDesconto.TabIndex = 21;
            this.btnDesconto.TabStop = false;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // btnAcrescimo
            // 
            this.btnAcrescimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcrescimo.Image = ((System.Drawing.Image)(resources.GetObject("btnAcrescimo.Image")));
            this.btnAcrescimo.Location = new System.Drawing.Point(820, 405);
            this.btnAcrescimo.Name = "btnAcrescimo";
            this.btnAcrescimo.Size = new System.Drawing.Size(22, 22);
            this.btnAcrescimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAcrescimo.TabIndex = 21;
            this.btnAcrescimo.TabStop = false;
            this.btnAcrescimo.Click += new System.EventHandler(this.btnAcrescimo_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(852, 594);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVenda)).EndInit();
            this.panel3.ResumeLayout(false);
            this.grbNovaVenda.ResumeLayout(false);
            this.grbNovaVenda.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelSalvar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProduto)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcrescimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdVenda;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button txtParcelmento;
        private System.Windows.Forms.Label labelTotalParcela;
        private System.Windows.Forms.GroupBox grbNovaVenda;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConsultarVendas;
        private System.Windows.Forms.ComboBox cbParcelamento;
        private System.Windows.Forms.Panel panelSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelParcelamento;
        private System.Windows.Forms.PictureBox btnBuscarCliente;
        private System.Windows.Forms.PictureBox btnBuscarProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelOperacao;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button txtTotal;
        private System.Windows.Forms.RadioButton chkOrcamento;
        private System.Windows.Forms.RadioButton chkVenda;
        private System.Windows.Forms.PictureBox btnDesconto;
        private System.Windows.Forms.PictureBox btnAcrescimo;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnFinalizar;
    }
}