using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os
{
    public partial class frmOrdemDeServico : Form
    {
        private Form objForm;

        public frmOrdemDeServico()
        {
            InitializeComponent();
        }

        private void frmOrdemDeServico_Load(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmOrdemDeServicoCliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelGerenciarOs.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmOrdemDeServicoCliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelGerenciarOs.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnOrdemDeServico_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmOrdemDeServicoOs
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelGerenciarOs.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnItensDaOs_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmOrdemDeServicoFinalizar
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelGerenciarOs.Controls.Add(objForm);
            objForm.Show();
        }
    }
}
