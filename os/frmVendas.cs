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
using Microsoft.VisualBasic;

namespace os
{
    public partial class frmVendas : Form
    {
        List<ItemVO> lstItem = new List<ItemVO>();
        decimal qtdDesconto = 0;
        decimal qtdAcrescimo = 0;
        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdVenda);
            Util.ConfigurarCombo(cbVendedor, "nome_funcionario", "id_funcionario");
            CarregarCombo();
            EstadoInicial();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarClientes consultarClientes = new frmConsultarClientes(this);
            consultarClientes.ShowDialog();
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos consultarProdutos = new frmConsultarProdutos(this);
            consultarProdutos.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (ValidarItem(Convert.ToInt32(txtCodigoProduto.Text)))
                {
                    ProdutoDAO ObjProdutoDAO = new ProdutoDAO();
                    int estoque = ObjProdutoDAO.ConsultarQtdProduto(Convert.ToInt32(txtCodigoProduto.Text));
                    if (estoque >= Convert.ToInt32(txtQuantidade.Text))
                    {
                        ItemVO objVO = new ItemVO();
                        objVO.idProd = Convert.ToInt32(txtCodigoProduto.Text);
                        objVO.Produto = txtProduto.Text;
                        objVO.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                        objVO.Preco = new ProdutoDAO().ConsultarPrecoProduto(Convert.ToInt32(txtCodigoProduto.Text));

                        lstItem.Add(objVO);
                        CarregarGrid();
                        MostrarTotal();
                    }
                    else
                    {
                        Util.ExibirMsg(Util.TipoMsg.SemEstoque);
                    }
                }
            }
        }

        private void MostrarTotal()
        {
            decimal preco = 0;
            for (int i = 0; i < lstItem.Count; i++)
            {
                preco += (lstItem[i].Quantidade * lstItem[i].Preco);
            }
            preco = preco - qtdDesconto + qtdAcrescimo;
            txtTotal.Text = preco.ToString("N2");
            txtParcelmento.Text = (preco / Convert.ToDecimal(cbParcelamento.Text)).ToString("N2");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            if (lstItem.Count != 0)
            {
                tb_venda ObjVenda = new tb_venda();
                VendaDAO ObjDAO = new VendaDAO();
                ProdutoDAO ObjProdutoDAO = new ProdutoDAO();

                if (chkVenda.Checked)
                {
                    ObjVenda.operacao_venda = chkVenda.Text;
                }

                if (chkOrcamento.Checked)
                {
                    ObjVenda.operacao_venda = chkOrcamento.Text;
                }

                ObjVenda.data_venda = dtData.Value.Date;
                ObjVenda.parcelamento_venda = Convert.ToInt32(cbParcelamento.SelectedItem);
                ObjVenda.vencimento_venda = dtVencimento.Value.Date;
                ObjVenda.desconto_venda = qtdDesconto;
                ObjVenda.acrescimo_venda = qtdAcrescimo;
                ObjVenda.id_funcionario = Convert.ToInt32(cbVendedor.SelectedValue);
                ObjVenda.id_cliente = Convert.ToInt32(txtCodigoCliente.Text);
                ObjVenda.id_usuario = Usuario.CodigoUsuarioLogado;

                for (int i = 0; i < lstItem.Count; i++)
                {
                    tb_item_venda item = new tb_item_venda();
                    item.qtd_item_venda = lstItem[i].Quantidade;
                    item.id_produto = lstItem[i].idProd;
                    ObjVenda.tb_item_venda.Add(item);
                }

                try
                {
                    ObjDAO.InserirVenda(ObjVenda);

                    for (int i = 0; i < lstItem.Count; i++)
                    {
                        tb_item_venda item = new tb_item_venda();
                        item.qtd_item_venda = lstItem[i].Quantidade;
                        item.id_produto = lstItem[i].idProd;

                        ObjProdutoDAO.DiminuirQtdProduto(lstItem[i].idProd, lstItem[i].Quantidade);
                    }

                    EstadoInicial();
                    lstItem.Clear();
                    CarregarGrid();
                    MostrarTotal();

                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
            else
            {
                Util.ExibirMsg(Util.TipoMsg.ListaVazia);
            }
        }

        private void btnConsultarVendas_Click(object sender, EventArgs e)
        {
            frmConsultarVendas consultarVendas = new frmConsultarVendas();
            consultarVendas.ShowDialog();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Trim() != "")
            {
                int quantidade = Convert.ToInt32(txtQuantidade.Text);

                if (quantidade == 0)
                {
                    quantidade = 1;
                    txtQuantidade.Text = Convert.ToString(quantidade);
                }
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campo = "";

            if (cbVendedor.SelectedIndex == -1)
            {
                ret = false;
                campo = "- Vendedor";
            }

            if (cbParcelamento.SelectedIndex == -1)
            {
                ret = false;
                campo += "\n- Parcelamento";
            }

            if (txtCliente.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Cliente";
            }

            if (txtProduto.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Produto";
            }

            if (txtQuantidade.Text.Trim() == "" || Convert.ToInt32(txtQuantidade.Text) <= 0)
            {
                ret = false;
                campo += "\n- Quantidade";
            }

            if (!ret)
            {
                Util.ExibirMsgValidarCampos(campo);
            }
            return ret;
        }

        private bool ValidarItem(int idProduto)
        {
            bool ret = true;

            for (int i = 0; i < lstItem.Count; i++)
            {
                if (idProduto == lstItem[i].idProd)
                {
                    ret = false;
                    Util.ExibirMsg(Util.TipoMsg.ProdutoRepetido);
                }
            }
            return ret;
        }

        private void EstadoInicial()
        {
            cbVendedor.SelectedIndex = 0;
            chkVenda.Checked = true;
            chkOrcamento.Checked = false;
            cbParcelamento.SelectedIndex = 0;
            txtCliente.Clear();
            txtProduto.Clear();
            txtQuantidade.Text = "1";
            qtdAcrescimo = 0;
            qtdDesconto = 0;
        }

        private void LimparCampos()
        {
            chkVenda.Checked = true;
            chkOrcamento.Checked = false;
            cbParcelamento.SelectedIndex = 0;
            txtProduto.Clear();
            txtCodigoProduto.Clear();
            txtQuantidade.Text = "1";
            txtTotal.Text = "";
            txtParcelmento.Text = "";
            lstItem.Clear();
            grdVenda.DataSource = null;
            qtdAcrescimo = 0;
            qtdDesconto = 0;
        }

        private void CarregarGrid()
        {
            grdVenda.DataSource = null;
            grdVenda.DataSource = lstItem;
            grdVenda.Columns["idProd"].Visible = false;
            grdVenda.Columns["Preco"].HeaderText = "Preço";
        }

        private void CarregarCombo()
        {
            FuncionarioDAO ObjDAO = new FuncionarioDAO();
            cbVendedor.DataSource = ObjDAO.FiltrarFuncionarioAtivo(Usuario.CodigoUsuarioLogado);
        }

        public void SelecionarCliente(tb_cliente objCliente)
        {
            txtCliente.Text = objCliente.nome_cliente;
            txtCodigoCliente.Text = objCliente.id_cliente.ToString();
        }

        public void SelecionarProduto(tb_produto objProduto)
        {
            txtProduto.Text = objProduto.nome_produto;
            txtCodigoProduto.Text = objProduto.id_produto.ToString();
            txtQuantidade.Text = "1";
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnAcrescimo_Click(object sender, EventArgs e)
        {
            if (qtdAcrescimo == 0 && qtdDesconto == 0)
            {
                try
                {
                    qtdAcrescimo = Convert.ToDecimal(Interaction.InputBox("Informe o valor do acréscimo", "Venda").Trim());
                    txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + qtdAcrescimo).ToString();
                    MostrarTotal();
                }
                catch
                {
                }
            }
            else
            {
                Util.ExibirMsg(Util.TipoMsg.ErroAcrescimoDesconto);
            }

        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            if (qtdAcrescimo == 0 && qtdDesconto == 0)
            {
                try
                {
                    qtdDesconto = Convert.ToDecimal(Interaction.InputBox("Informe o valor do desconto", "Desconto").Trim());
                    txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - qtdDesconto).ToString();
                    MostrarTotal();
                }
                catch
                {
                }
            }
            else
            {
                Util.ExibirMsg(Util.TipoMsg.ErroAcrescimoDesconto);
            }

        }

        private void cbParcelamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarTotal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void grdVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdVenda.RowCount > 0)
            {
                if (MessageBox.Show("Deseja excluir o item da venda?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstItem.RemoveAt(e.RowIndex);
                    CarregarGrid();
                    MostrarTotal();
                }
            }
        }
    }
}
