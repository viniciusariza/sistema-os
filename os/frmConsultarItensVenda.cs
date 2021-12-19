using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace os
{
    public partial class frmConsultarItensVenda : Form
    {
        int idVenda;
        public frmConsultarItensVenda()
        {
            InitializeComponent();
        }
        public frmConsultarItensVenda(int codVenda)
        {
            InitializeComponent();
            idVenda = codVenda;
        }
        private void frmConsultarItensVenda_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdItens);
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ItemDAO ObjDAO = new ItemDAO();
            grdItens.DataSource = ObjDAO.ConsultarItens(idVenda);

            grdItens.Columns["idProd"].Visible = false;
            grdItens.Columns["Preco"].HeaderText = "Preço";
        }
    }
}
