using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdProdutos);
            Util.ConfigurarCombo(cbFornecedor, "nome_fornecedor", "id_fornecedor");
            CarregarComboFornecedor();
            EstadoInicial();
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ProdutoDAO ObjDao = new ProdutoDAO();
                tb_produto ObjProduto = new tb_produto();

                ObjProduto.nome_produto = txtNome.Text.Trim();
                ObjProduto.marca_produto = txtMarca.Text.Trim();
                ObjProduto.categoria_produto = cbCategoria.Text;
                ObjProduto.id_fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                ObjProduto.custo_produto = Convert.ToDecimal(txtCusto.Text);
                ObjProduto.venda_produto = Convert.ToDecimal(txtVenda.Text);
                ObjProduto.estoque_produto = Convert.ToInt32(txtEstoque.Text);
                ObjProduto.id_usuario = Usuario.CodigoUsuarioLogado;

                try
                {
                    if (txtCodigo.Text == "")
                    {
                        ObjDao.InserirProduto(ObjProduto);
                    }
                    else
                    {
                        ObjProduto.id_produto = Convert.ToInt32(txtCodigo.Text);
                        ObjDao.AlterarProduto(ObjProduto);
                    }
                    EstadoInicial();
                    CarregarGrid();
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.ExibirMsgDesejaExcluir())
            {
                ProdutoDAO ObjDAO = new ProdutoDAO();
                try
                {
                    ObjDAO.ExcluirProduto(Convert.ToInt32(txtCodigo.Text));
                    EstadoInicial();
                    CarregarGrid();
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.ErroExcluir);
                }
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void CarregarGrid()
        {
            ProdutoDAO ObjDAO = new ProdutoDAO();
            List<ProdutoVO> lstProduto = ObjDAO.ConsultarProdutoEditado(Usuario.CodigoUsuarioLogado, txtFiltro.Text, cbFiltro.SelectedIndex);
            grdProdutos.DataSource = lstProduto;

            grdProdutos.Columns["ObjProduto"].Visible = false;
            grdProdutos.Columns["PrecoDeVenda"].HeaderText = "Preço de Venda";
        }

        private void CarregarComboFornecedor()
        {
            FornecedorDAO ObjDAO = new FornecedorDAO();
            List<tb_fornecedor> lstFornecedor = ObjDAO.ConsultarFornecedor(Usuario.CodigoUsuarioLogado, "", 0);
            cbFornecedor.DataSource = lstFornecedor;
        }

        private void EstadoInicial()
        {
            txtCodigo.Clear();
            txtCusto.Clear();
            txtEstoque.Clear();
            txtMarca.Clear();
            txtNome.Clear();
            txtVenda.Clear();

            cbCategoria.SelectedIndex = -1;
            cbFornecedor.SelectedIndex = -1;
            cbFiltro.SelectedIndex = 0;
            btnSalvar.Text = "Cadastrar";
            btnExcluir.Enabled = false;
            txtEstoque.Text = "0";
            txtFiltro.Focus();
        }

        private bool ValidarCampos()
        {

            bool ret = true;
            string campo = "";

            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campo = "- Nome";
            }

            if (txtMarca.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Marca";
            }

            if (cbCategoria.SelectedIndex == -1)
            {
                ret = false;
                campo += "\n- Categoria";
            }

            if (cbFornecedor.SelectedIndex == -1)
            {
                ret = false;
                campo += "\n- Fornecedor";
            }

            if (txtCusto.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Preço de Custo";
            }

            if (txtVenda.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Preço de Venda";
            }

            if (!ret)
            {
                Util.ExibirMsgValidarCampos(campo);
            }

            return ret;
        }

        private void grdProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProdutos.Rows.Count > 0)
            {
                ProdutoVO ObjResgate = (ProdutoVO)grdProdutos.CurrentRow.DataBoundItem;
                tb_produto ObjLinha = ObjResgate.ObjProduto;

                txtCodigo.Text = ObjLinha.id_produto.ToString();
                txtNome.Text = ObjLinha.nome_produto;
                txtMarca.Text = ObjLinha.marca_produto;
                cbCategoria.Text = ObjLinha.categoria_produto;
                cbFornecedor.SelectedValue = ObjLinha.id_fornecedor;
                txtCusto.Text = ObjLinha.custo_produto.ToString();
                txtVenda.Text = ObjLinha.venda_produto.ToString();
                txtEstoque.Text = ObjLinha.estoque_produto.ToString();

                btnExcluir.Enabled = true;
                btnSalvar.Text = "Alterar";
                txtNome.Focus();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCusto.Text.IndexOf(",") == -1 && txtCusto.Text != "")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtVenda.Text.IndexOf(",") == -1 && txtVenda.Text != "")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
