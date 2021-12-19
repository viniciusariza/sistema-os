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
    public partial class frmOrdemDeServicoCliente : Form
    {
        public frmOrdemDeServicoCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarClientes clientes = new frmConsultarClientes();
            clientes.ShowDialog();
        }
    }
}
