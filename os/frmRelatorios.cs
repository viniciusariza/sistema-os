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
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private Form objForm;

        private void btnOS_Click(object sender, EventArgs e)
        {
            OcultarPaineis();

            objForm?.Close();
            objForm = new frmRelatorioOS()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None
            };
            panelRelatorio.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            OcultarPaineis();

            objForm?.Close();
            objForm = new frmMapa(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None
            };
            panelRelatorio.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void VoltarMenu()
        {
            objForm?.Close();
            objForm = new frmRelatorios()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None
            };
            panelRelatorio.Controls.Add(objForm);
            objForm.Show();
        }

        private void OcultarPaineis()
        {
            panelOS.Visible = false;
            panelVendas.Visible = false;
            panelMapa.Visible = false;
            panelEmail.Visible = false;
        }
    }
}
