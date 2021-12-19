namespace os
{
    partial class frmOrdemDeServicoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdemDeServicoCliente));
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.PictureBox();
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
            this.panelSalvar = new System.Windows.Forms.Panel();
            this.btnEditarSalvar = new System.Windows.Forms.Button();
            this.panelCancelar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).BeginInit();
            this.panelSalvar.SuspendLayout();
            this.panelCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDados.Controls.Add(this.btnBuscarCliente);
            this.grbDados.Controls.Add(this.txtCelular);
            this.grbDados.Controls.Add(this.txtTelefoneFixo);
            this.grbDados.Controls.Add(this.txtEndereco);
            this.grbDados.Controls.Add(this.txtCidade);
            this.grbDados.Controls.Add(this.txtBairro);
            this.grbDados.Controls.Add(this.txtEmail);
            this.grbDados.Controls.Add(this.txtCpfCnpj);
            this.grbDados.Controls.Add(this.txtNome);
            this.grbDados.Controls.Add(this.labelEndereco);
            this.grbDados.Controls.Add(this.labelEmail);
            this.grbDados.Controls.Add(this.labelCPFCNPJ);
            this.grbDados.Controls.Add(this.labelCelular);
            this.grbDados.Controls.Add(this.labelTelefoneFixo);
            this.grbDados.Controls.Add(this.labelCidade);
            this.grbDados.Controls.Add(this.labelBairro);
            this.grbDados.Controls.Add(this.labelNome);
            this.grbDados.Controls.Add(this.panelSalvar);
            this.grbDados.Controls.Add(this.panelCancelar);
            this.grbDados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.ForeColor = System.Drawing.Color.White;
            this.grbDados.Location = new System.Drawing.Point(0, 1);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(814, 292);
            this.grbDados.TabIndex = 15;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(484, 54);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(22, 22);
            this.btnBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarCliente.TabIndex = 22;
            this.btnBuscarCliente.TabStop = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.Enabled = false;
            this.txtCelular.ForeColor = System.Drawing.Color.White;
            this.txtCelular.Location = new System.Drawing.Point(663, 92);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(114, 22);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefoneFixo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneFixo.Enabled = false;
            this.txtTelefoneFixo.ForeColor = System.Drawing.Color.White;
            this.txtTelefoneFixo.Location = new System.Drawing.Point(663, 54);
            this.txtTelefoneFixo.Mask = "(99) 0000-0000";
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Size = new System.Drawing.Size(114, 22);
            this.txtTelefoneFixo.TabIndex = 4;
            this.txtTelefoneFixo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.ForeColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(140, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(333, 22);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Enabled = false;
            this.txtCidade.ForeColor = System.Drawing.Color.White;
            this.txtCidade.Location = new System.Drawing.Point(140, 168);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(333, 22);
            this.txtCidade.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Enabled = false;
            this.txtBairro.ForeColor = System.Drawing.Color.White;
            this.txtBairro.Location = new System.Drawing.Point(140, 130);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(333, 22);
            this.txtBairro.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(663, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(114, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpfCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfCnpj.Enabled = false;
            this.txtCpfCnpj.ForeColor = System.Drawing.Color.White;
            this.txtCpfCnpj.Location = new System.Drawing.Point(663, 130);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(114, 22);
            this.txtCpfCnpj.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(140, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 22);
            this.txtNome.TabIndex = 0;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(50, 94);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(67, 16);
            this.labelEndereco.TabIndex = 0;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(590, 172);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 16);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPFCNPJ.Location = new System.Drawing.Point(564, 133);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(75, 16);
            this.labelCPFCNPJ.TabIndex = 0;
            this.labelCPFCNPJ.Text = "CPF/CNPJ:";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelular.Location = new System.Drawing.Point(587, 95);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(52, 16);
            this.labelCelular.TabIndex = 0;
            this.labelCelular.Text = "Celular:";
            // 
            // labelTelefoneFixo
            // 
            this.labelTelefoneFixo.AutoSize = true;
            this.labelTelefoneFixo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefoneFixo.Location = new System.Drawing.Point(551, 56);
            this.labelTelefoneFixo.Name = "labelTelefoneFixo";
            this.labelTelefoneFixo.Size = new System.Drawing.Size(88, 16);
            this.labelTelefoneFixo.TabIndex = 0;
            this.labelTelefoneFixo.Text = "Telefone Fixo:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(65, 170);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(52, 16);
            this.labelCidade.TabIndex = 0;
            this.labelCidade.Text = "Cidade:";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(71, 132);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(46, 16);
            this.labelBairro.TabIndex = 0;
            this.labelBairro.Text = "Bairro:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(71, 56);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // panelSalvar
            // 
            this.panelSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSalvar.BackgroundImage")));
            this.panelSalvar.Controls.Add(this.btnEditarSalvar);
            this.panelSalvar.Location = new System.Drawing.Point(222, 228);
            this.panelSalvar.Name = "panelSalvar";
            this.panelSalvar.Size = new System.Drawing.Size(190, 40);
            this.panelSalvar.TabIndex = 14;
            this.panelSalvar.Visible = false;
            // 
            // btnEditarSalvar
            // 
            this.btnEditarSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarSalvar.FlatAppearance.BorderSize = 0;
            this.btnEditarSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditarSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnEditarSalvar.Name = "btnEditarSalvar";
            this.btnEditarSalvar.Size = new System.Drawing.Size(190, 40);
            this.btnEditarSalvar.TabIndex = 8;
            this.btnEditarSalvar.Text = "Editar";
            this.btnEditarSalvar.UseVisualStyleBackColor = false;
            // 
            // panelCancelar
            // 
            this.panelCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCancelar.BackgroundImage")));
            this.panelCancelar.Controls.Add(this.btnCancelar);
            this.panelCancelar.Location = new System.Drawing.Point(478, 228);
            this.panelCancelar.Name = "panelCancelar";
            this.panelCancelar.Size = new System.Drawing.Size(190, 40);
            this.panelCancelar.TabIndex = 15;
            this.panelCancelar.Visible = false;
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
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmOrdemDeServicoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(814, 292);
            this.Controls.Add(this.grbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrdemDeServicoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ordem de Serviço Cliente";
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).EndInit();
            this.panelSalvar.ResumeLayout(false);
            this.panelCancelar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
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
        private System.Windows.Forms.PictureBox btnBuscarCliente;
        private System.Windows.Forms.Panel panelSalvar;
        private System.Windows.Forms.Button btnEditarSalvar;
        private System.Windows.Forms.Panel panelCancelar;
        private System.Windows.Forms.Button btnCancelar;
    }
}