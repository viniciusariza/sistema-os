using DAO;
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
    public partial class frmConsultarClientes : Form
    {
        frmOrdemServico os;
        frmVendas vendas;
        public frmConsultarClientes()
        {
            InitializeComponent();
        }
        public frmConsultarClientes(frmOrdemServico fOs)
        {
            InitializeComponent();
            os = fOs;
        }
        public frmConsultarClientes(frmVendas fVendas)
        {
            InitializeComponent();
            vendas = fVendas;
        }
        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdClientes);
            txtFiltro.Focus();
            cbFiltro.SelectedIndex = 0;
            CarregarGridCliente();
        }
        private void CarregarGridCliente()
        {
            ClienteDAO ObjDAO = new ClienteDAO();

            List<tb_cliente> lstCliente = ObjDAO.ConsultarCliente(Usuario.CodigoUsuarioLogado, txtFiltro.Text, cbFiltro.SelectedIndex);

            grdClientes.DataSource = lstCliente;

            grdClientes.Columns["nome_cliente"].HeaderText = "Nome";
            grdClientes.Columns["endereco_cliente"].HeaderText = "Endereço";
            grdClientes.Columns["cidade_cliente"].HeaderText = "Cidade";
            grdClientes.Columns["telefone_cliente"].HeaderText = "Telefone";
            grdClientes.Columns["celular_cliente"].HeaderText = "Celular";

            grdClientes.Columns["bairro_cliente"].Visible = false;
            grdClientes.Columns["cpf_cliente"].Visible = false;
            grdClientes.Columns["email_cliente"].Visible = false;
            grdClientes.Columns["id_cliente"].Visible = false;
            grdClientes.Columns["id_usuario"].Visible = false;
            grdClientes.Columns["tb_usuario"].Visible = false;
            grdClientes.Columns["tb_os"].Visible = false;
            grdClientes.Columns["tb_venda"].Visible = false;
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CarregarGridCliente();
        }
        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdClientes.RowCount > 0)
            {
                tb_cliente ObjLinha = (tb_cliente)grdClientes.CurrentRow.DataBoundItem;

                if(os?.GetType().Name == "frmOrdemServico")
                {
                    os.SelecionarCliente(ObjLinha);
                }
                else
                {
                    vendas.SelecionarCliente(ObjLinha);
                }
                this.Close();
            }
        }
    }
}
