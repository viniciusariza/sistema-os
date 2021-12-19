using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os
{
    public partial class frmPrincipal : Form
    {
        private Form objForm;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnOrdemDeServico_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmOrdemServico
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelTela.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmProdutos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelTela.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmClientes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelTela.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmFornecedores
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelTela.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmFuncionarios
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelTela.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmVendas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelTela.Controls.Add(objForm);
            objForm.Show();
        }

        public void btnRelatorios_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmRelatorios
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelTela.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
        }
    }
}
