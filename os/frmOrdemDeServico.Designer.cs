namespace os
{
    partial class frmOrdemDeServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdemDeServico));
            this.grbGerenciarOrdemDeServico = new System.Windows.Forms.GroupBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.labelNomePesquisar = new System.Windows.Forms.Label();
            this.txtConsultaNome = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelGerenciarOs = new System.Windows.Forms.Panel();
            this.btnItensDaOs = new System.Windows.Forms.Button();
            this.btnOrdemDeServico = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.grbGerenciarOrdemDeServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGerenciarOrdemDeServico
            // 
            this.grbGerenciarOrdemDeServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbGerenciarOrdemDeServico.Controls.Add(this.grdClientes);
            this.grbGerenciarOrdemDeServico.Controls.Add(this.labelNomePesquisar);
            this.grbGerenciarOrdemDeServico.Controls.Add(this.txtConsultaNome);
            this.grbGerenciarOrdemDeServico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGerenciarOrdemDeServico.ForeColor = System.Drawing.Color.White;
            this.grbGerenciarOrdemDeServico.Location = new System.Drawing.Point(27, 357);
            this.grbGerenciarOrdemDeServico.Name = "grbGerenciarOrdemDeServico";
            this.grbGerenciarOrdemDeServico.Size = new System.Drawing.Size(814, 254);
            this.grbGerenciarOrdemDeServico.TabIndex = 19;
            this.grbGerenciarOrdemDeServico.TabStop = false;
            this.grbGerenciarOrdemDeServico.Text = "Gerenciar Ordens de Serviço";
            // 
            // grdClientes
            // 
            this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grdClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(59, 100);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(703, 132);
            this.grdClientes.TabIndex = 12;
            // 
            // labelNomePesquisar
            // 
            this.labelNomePesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNomePesquisar.AutoSize = true;
            this.labelNomePesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomePesquisar.Location = new System.Drawing.Point(56, 49);
            this.labelNomePesquisar.Name = "labelNomePesquisar";
            this.labelNomePesquisar.Size = new System.Drawing.Size(46, 16);
            this.labelNomePesquisar.TabIndex = 10;
            this.labelNomePesquisar.Text = "Nome:";
            // 
            // txtConsultaNome
            // 
            this.txtConsultaNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConsultaNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultaNome.ForeColor = System.Drawing.Color.White;
            this.txtConsultaNome.Location = new System.Drawing.Point(125, 49);
            this.txtConsultaNome.Name = "txtConsultaNome";
            this.txtConsultaNome.Size = new System.Drawing.Size(637, 22);
            this.txtConsultaNome.TabIndex = 11;
            // 
            // panelGerenciarOs
            // 
            this.panelGerenciarOs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGerenciarOs.Location = new System.Drawing.Point(27, 48);
            this.panelGerenciarOs.Name = "panelGerenciarOs";
            this.panelGerenciarOs.Size = new System.Drawing.Size(814, 292);
            this.panelGerenciarOs.TabIndex = 21;
            // 
            // btnItensDaOs
            // 
            this.btnItensDaOs.BackColor = System.Drawing.Color.Transparent;
            this.btnItensDaOs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItensDaOs.FlatAppearance.BorderSize = 0;
            this.btnItensDaOs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnItensDaOs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.btnItensDaOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItensDaOs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItensDaOs.ForeColor = System.Drawing.Color.White;
            this.btnItensDaOs.Image = ((System.Drawing.Image)(resources.GetObject("btnItensDaOs.Image")));
            this.btnItensDaOs.Location = new System.Drawing.Point(349, 6);
            this.btnItensDaOs.Name = "btnItensDaOs";
            this.btnItensDaOs.Size = new System.Drawing.Size(160, 40);
            this.btnItensDaOs.TabIndex = 0;
            this.btnItensDaOs.UseVisualStyleBackColor = false;
            this.btnItensDaOs.Click += new System.EventHandler(this.btnItensDaOs_Click);
            // 
            // btnOrdemDeServico
            // 
            this.btnOrdemDeServico.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdemDeServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdemDeServico.FlatAppearance.BorderSize = 0;
            this.btnOrdemDeServico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrdemDeServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.btnOrdemDeServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdemDeServico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdemDeServico.ForeColor = System.Drawing.Color.White;
            this.btnOrdemDeServico.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdemDeServico.Image")));
            this.btnOrdemDeServico.Location = new System.Drawing.Point(188, 6);
            this.btnOrdemDeServico.Name = "btnOrdemDeServico";
            this.btnOrdemDeServico.Size = new System.Drawing.Size(160, 40);
            this.btnOrdemDeServico.TabIndex = 0;
            this.btnOrdemDeServico.UseVisualStyleBackColor = false;
            this.btnOrdemDeServico.Click += new System.EventHandler(this.btnOrdemDeServico_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(510, 6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(160, 40);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(27, 6);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(160, 40);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // frmOrdemDeServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(868, 633);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnItensDaOs);
            this.Controls.Add(this.btnOrdemDeServico);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.panelGerenciarOs);
            this.Controls.Add(this.grbGerenciarOrdemDeServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOrdemDeServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orde de Serviço";
            this.Load += new System.EventHandler(this.frmOrdemDeServico_Load);
            this.grbGerenciarOrdemDeServico.ResumeLayout(false);
            this.grbGerenciarOrdemDeServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbGerenciarOrdemDeServico;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Label labelNomePesquisar;
        private System.Windows.Forms.TextBox txtConsultaNome;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelGerenciarOs;
        private System.Windows.Forms.Button btnOrdemDeServico;
        private System.Windows.Forms.Button btnItensDaOs;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCliente;
    }
}