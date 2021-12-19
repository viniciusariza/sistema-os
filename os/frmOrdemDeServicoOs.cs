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
    public partial class frmOrdemDeServicoOs : Form
    {
        public frmOrdemDeServicoOs()
        {
            InitializeComponent();
        }

        private void cbSenha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSenha.SelectedIndex == 1)
            {
                txtSenha.Visible = true;
            }
            else
            {
                txtSenha.Visible = false;
            }
        }

        private void frmOrdemDeServicoOs_Load(object sender, EventArgs e)
        {
            cbSenha.SelectedIndex = 0;
        }
    }
}
