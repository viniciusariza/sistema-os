namespace os
{
    partial class frmConsultarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarVendas));
            this.grbVendas = new System.Windows.Forms.GroupBox();
            this.grdVendas = new System.Windows.Forms.DataGridView();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtConsultaNome = new System.Windows.Forms.TextBox();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPesquisarData = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.grbVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbVendas
            // 
            this.grbVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbVendas.Controls.Add(this.chkPesquisarData);
            this.grbVendas.Controls.Add(this.dtpFinal);
            this.grbVendas.Controls.Add(this.dtpInicial);
            this.grbVendas.Controls.Add(this.label2);
            this.grbVendas.Controls.Add(this.grdVendas);
            this.grbVendas.Controls.Add(this.label1);
            this.grbVendas.Controls.Add(this.labelNome);
            this.grbVendas.Controls.Add(this.txtConsultaNome);
            this.grbVendas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVendas.ForeColor = System.Drawing.Color.White;
            this.grbVendas.Location = new System.Drawing.Point(12, 12);
            this.grbVendas.Name = "grbVendas";
            this.grbVendas.Size = new System.Drawing.Size(609, 405);
            this.grbVendas.TabIndex = 18;
            this.grbVendas.TabStop = false;
            this.grbVendas.Text = "Vendas Realizadas";
            // 
            // grdVendas
            // 
            this.grdVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdVendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVendas.ColumnHeadersHeight = 30;
            this.grdVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdVendas.EnableHeadersVisualStyles = false;
            this.grdVendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(62)))), ((int)(((byte)(191)))));
            this.grdVendas.Location = new System.Drawing.Point(26, 129);
            this.grdVendas.MultiSelect = false;
            this.grdVendas.Name = "grdVendas";
            this.grdVendas.ReadOnly = true;
            this.grdVendas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.grdVendas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVendas.Size = new System.Drawing.Size(555, 256);
            this.grdVendas.TabIndex = 17;
            this.grdVendas.TabStop = false;
            this.grdVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVendas_CellClick);
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(23, 47);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 16);
            this.labelNome.TabIndex = 10;
            this.labelNome.Text = "Nome:";
            // 
            // txtConsultaNome
            // 
            this.txtConsultaNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConsultaNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultaNome.ForeColor = System.Drawing.Color.White;
            this.txtConsultaNome.Location = new System.Drawing.Point(92, 45);
            this.txtConsultaNome.MaxLength = 80;
            this.txtConsultaNome.Name = "txtConsultaNome";
            this.txtConsultaNome.Size = new System.Drawing.Size(489, 22);
            this.txtConsultaNome.TabIndex = 0;
            this.txtConsultaNome.TextChanged += new System.EventHandler(this.txtConsultaNome_TextChanged);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(286, 83);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(90, 22);
            this.dtpInicial.TabIndex = 18;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Inicial:";
            // 
            // chkPesquisarData
            // 
            this.chkPesquisarData.AutoSize = true;
            this.chkPesquisarData.Location = new System.Drawing.Point(26, 87);
            this.chkPesquisarData.Name = "chkPesquisarData";
            this.chkPesquisarData.Size = new System.Drawing.Size(146, 20);
            this.chkPesquisarData.TabIndex = 19;
            this.chkPesquisarData.Text = "Pesquisar por data";
            this.chkPesquisarData.UseVisualStyleBackColor = true;
            this.chkPesquisarData.CheckedChanged += new System.EventHandler(this.chkPesquisarData_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Final:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(491, 83);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(90, 22);
            this.dtpFinal.TabIndex = 18;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
            // 
            // frmConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(633, 429);
            this.Controls.Add(this.grbVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Vendas";
            this.Load += new System.EventHandler(this.frmConsultarVendas_Load);
            this.grbVendas.ResumeLayout(false);
            this.grbVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbVendas;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtConsultaNome;
        private System.Windows.Forms.DataGridView grdVendas;
        private System.Windows.Forms.CheckBox chkPesquisarData;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}