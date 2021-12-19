namespace os
{
    partial class frmOrdemDeServicoOs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdemDeServicoOs));
            this.txtEquipamento = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.labelEquipamento = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbSenha = new System.Windows.Forms.ComboBox();
            this.txtDefeito = new System.Windows.Forms.RichTextBox();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelObservacoes = new System.Windows.Forms.Label();
            this.labelDefeito = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEquipamento
            // 
            this.txtEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEquipamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipamento.ForeColor = System.Drawing.Color.White;
            this.txtEquipamento.Location = new System.Drawing.Point(178, 115);
            this.txtEquipamento.Name = "txtEquipamento";
            this.txtEquipamento.Size = new System.Drawing.Size(121, 22);
            this.txtEquipamento.TabIndex = 0;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.Location = new System.Drawing.Point(178, 183);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 22);
            this.txtModelo.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(178, 149);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // labelEquipamento
            // 
            this.labelEquipamento.AutoSize = true;
            this.labelEquipamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipamento.Location = new System.Drawing.Point(70, 117);
            this.labelEquipamento.Name = "labelEquipamento";
            this.labelEquipamento.Size = new System.Drawing.Size(88, 16);
            this.labelEquipamento.TabIndex = 0;
            this.labelEquipamento.Text = "Equipamento:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(104, 185);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(54, 16);
            this.labelModelo.TabIndex = 0;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(110, 151);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(48, 16);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(52, 52);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(106, 16);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data de Entrada:";
            // 
            // grbDados
            // 
            this.grbDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDados.Controls.Add(this.checkBox1);
            this.grbDados.Controls.Add(this.cbSenha);
            this.grbDados.Controls.Add(this.txtDefeito);
            this.grbDados.Controls.Add(this.txtObservacoes);
            this.grbDados.Controls.Add(this.dtData);
            this.grbDados.Controls.Add(this.txtEquipamento);
            this.grbDados.Controls.Add(this.txtSenha);
            this.grbDados.Controls.Add(this.txtModelo);
            this.grbDados.Controls.Add(this.labelSenha);
            this.grbDados.Controls.Add(this.txtMarca);
            this.grbDados.Controls.Add(this.labelEquipamento);
            this.grbDados.Controls.Add(this.labelModelo);
            this.grbDados.Controls.Add(this.labelMarca);
            this.grbDados.Controls.Add(this.labelObservacoes);
            this.grbDados.Controls.Add(this.labelDefeito);
            this.grbDados.Controls.Add(this.labelData);
            this.grbDados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.ForeColor = System.Drawing.Color.White;
            this.grbDados.Location = new System.Drawing.Point(0, 1);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(814, 292);
            this.grbDados.TabIndex = 16;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(178, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 20);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Retorno";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbSenha
            // 
            this.cbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSenha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSenha.ForeColor = System.Drawing.Color.White;
            this.cbSenha.FormattingEnabled = true;
            this.cbSenha.Items.AddRange(new object[] {
            "Padrão",
            "Alfanumérica"});
            this.cbSenha.Location = new System.Drawing.Point(178, 217);
            this.cbSenha.Name = "cbSenha";
            this.cbSenha.Size = new System.Drawing.Size(121, 24);
            this.cbSenha.TabIndex = 31;
            this.cbSenha.SelectedIndexChanged += new System.EventHandler(this.cbSenha_SelectedIndexChanged);
            // 
            // txtDefeito
            // 
            this.txtDefeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefeito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDefeito.ForeColor = System.Drawing.Color.White;
            this.txtDefeito.Location = new System.Drawing.Point(483, 46);
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(290, 79);
            this.txtDefeito.TabIndex = 5;
            this.txtDefeito.Text = "";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservacoes.ForeColor = System.Drawing.Color.White;
            this.txtObservacoes.Location = new System.Drawing.Point(483, 162);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(290, 79);
            this.txtObservacoes.TabIndex = 6;
            this.txtObservacoes.Text = "";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(178, 49);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(121, 22);
            this.dtData.TabIndex = 30;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(178, 253);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(121, 22);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.Visible = false;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(109, 220);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(49, 16);
            this.labelSenha.TabIndex = 0;
            this.labelSenha.Text = "Senha:";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservacoes.Location = new System.Drawing.Point(371, 165);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(87, 16);
            this.labelObservacoes.TabIndex = 0;
            this.labelObservacoes.Text = "Observações:";
            // 
            // labelDefeito
            // 
            this.labelDefeito.AutoSize = true;
            this.labelDefeito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefeito.Location = new System.Drawing.Point(351, 49);
            this.labelDefeito.Name = "labelDefeito";
            this.labelDefeito.Size = new System.Drawing.Size(107, 16);
            this.labelDefeito.TabIndex = 0;
            this.labelDefeito.Text = "Defeito Relatado:";
            // 
            // frmOrdemDeServicoOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(814, 292);
            this.Controls.Add(this.grbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOrdemDeServicoOs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OS";
            this.Load += new System.EventHandler(this.frmOrdemDeServicoOs_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEquipamento;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label labelEquipamento;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label labelDefeito;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Label labelObservacoes;
        private System.Windows.Forms.RichTextBox txtDefeito;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.ComboBox cbSenha;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}