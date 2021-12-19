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
    public partial class frmConsultarProdutos : Form
    {
        frmOrdemServico os;
        frmVendas vendas;

        public frmConsultarProdutos()
        {
            InitializeComponent();
        }

        public frmConsultarProdutos(frmOrdemServico fOs)
        {
            InitializeComponent();
            os = fOs;
        }

        public frmConsultarProdutos(frmVendas fVendas)
        {
            InitializeComponent();
            vendas = fVendas;
        }

        private void frmConsultarProdutos_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdProdutos);
            CarregarGrid();
        }

        private void txtConsultaNome_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ProdutoDAO ObjDAO = new ProdutoDAO();
            List<tb_produto> lstProduto = ObjDAO.ConsultarProduto(Usuario.CodigoUsuarioLogado, txtConsultaNome.Text, 0);
            grdProdutos.DataSource = lstProduto;

            grdProdutos.Columns["nome_produto"].HeaderText = "Nome";
            grdProdutos.Columns["marca_produto"].HeaderText = "Marca";
            grdProdutos.Columns["venda_produto"].HeaderText = "Preço de Venda";
            grdProdutos.Columns["estoque_produto"].HeaderText = "Estoque";

            grdProdutos.Columns["id_produto"].Visible = false;
            grdProdutos.Columns["categoria_produto"].Visible = false;
            grdProdutos.Columns["custo_produto"].Visible = false;
            grdProdutos.Columns["id_produto"].Visible = false;
            grdProdutos.Columns["id_fornecedor"].Visible = false;
            grdProdutos.Columns["id_usuario"].Visible = false;
            grdProdutos.Columns["tb_fornecedor"].Visible = false;
            grdProdutos.Columns["tb_item_venda"].Visible = false;
            grdProdutos.Columns["tb_item_os"].Visible = false;
            grdProdutos.Columns["tb_usuario"].Visible = false;
        }

        private void grdProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProdutos.RowCount > 0)
            {
                tb_produto ObjLinha = (tb_produto)grdProdutos.CurrentRow.DataBoundItem;
                if(os?.GetType().Name == "frmOrdemServico")
                {
                    os.SelecionarProduto(ObjLinha);
                }
                else
                {
                    vendas.SelecionarProduto(ObjLinha);
                }
                this.Close();
            }
        }
    }
}
