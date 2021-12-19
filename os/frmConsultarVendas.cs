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
    public partial class frmConsultarVendas : Form
    {
        public frmConsultarVendas()
        {
            InitializeComponent();
        }

        private void frmConsultarVendas_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdVendas);
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            VendaDAO ObjDAO = new VendaDAO();
            grdVendas.DataSource = ObjDAO.ConsultarVendas(Usuario.CodigoUsuarioLogado,txtConsultaNome.Text,chkPesquisarData.Checked,dtpInicial.Value.Date,dtpFinal.Value.Date);

            grdVendas.Columns["idVenda"].Visible = false;
            grdVendas.Columns["Operacao"].HeaderText = "Operação";
        }

        private void txtConsultaNome_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void chkPesquisarData_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void grdVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdVendas.Rows.Count > 0)
            {
                VendaVO ObjLinha = (VendaVO)grdVendas.CurrentRow.DataBoundItem;
                int idVenda = ObjLinha.idVenda;

                frmConsultarItensVenda frmConsultarItens = new frmConsultarItensVenda(idVenda);
                frmConsultarItens.ShowDialog();
            }
        }
    }
}
