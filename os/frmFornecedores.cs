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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdFornecedores);
            EstadoInicial();
            cbFiltro.SelectedIndex = 0;
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tb_fornecedor ObjFornecedor = new tb_fornecedor();
                FornecedorDAO ObjDAO = new FornecedorDAO();

                ObjFornecedor.nome_fornecedor = txtNome.Text.Trim();
                ObjFornecedor.endereco_fornecedor = txtEndereco.Text.Trim();
                ObjFornecedor.bairro_fornecedor = txtBairro.Text.Trim();
                ObjFornecedor.cidade_fornecedor = txtCidade.Text.Trim();
                ObjFornecedor.telefone_fornecedor = txtTelefoneFixo.Text.Trim();
                ObjFornecedor.celular_fornecedor = txtCelular.Text.Trim();
                ObjFornecedor.cpfcnpj_fornecedor = txtCpfCnpj.Text.Trim();
                ObjFornecedor.email_fornecedor = txtEmail.Text.Trim();
                ObjFornecedor.id_usuario = Usuario.CodigoUsuarioLogado;

                try
                {
                    if (txtCodigo.Text == "")
                    {
                        ObjDAO.InserirFornecedor(ObjFornecedor);
                    }
                    else
                    {
                        ObjFornecedor.id_fornecedor = Convert.ToInt32(txtCodigo.Text);
                        ObjDAO.AlterarFornecedor(ObjFornecedor);
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
                FornecedorDAO ObjDAO = new FornecedorDAO();

                try
                {
                    ObjDAO.ExcluirFornecedor(Convert.ToInt32(txtCodigo.Text));
                    EstadoInicial();
                    CarregarGrid();
                }
                catch (Exception)
                {
                    Util.ExibirMsg(Util.TipoMsg.ErroExcluir);
                }
            }
        }

        private void EstadoInicial()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtCpfCnpj.Clear();
            txtCodigo.Clear();
            txtFiltro.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtTelefoneFixo.Clear();
            txtCelular.Clear();

            btnSalvar.Text = "Cadastrar";
            panelExcluir.Enabled = false;
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

            if (txtEndereco.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Endereço";
            }

            if (txtBairro.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Bairro";
            }

            if (txtCidade.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Cidade";
            }

            if (txtTelefoneFixo.Text.Trim() == "" && txtCelular.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Telefone Fixo ou Celular";
            }

            if (!ret)
            {
                MessageBox.Show("Preencha o(s) campo(s):\n\n" + campo, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ret;

        }

        private void CarregarGrid()
        {
            FornecedorDAO ObjDAO = new FornecedorDAO();
            List<tb_fornecedor> lstFornecedor = ObjDAO.ConsultarFornecedor(Usuario.CodigoUsuarioLogado, txtFiltro.Text,cbFiltro.SelectedIndex);

            grdFornecedores.DataSource = lstFornecedor;

            grdFornecedores.Columns["nome_fornecedor"].HeaderText = "Nome";
            grdFornecedores.Columns["endereco_fornecedor"].HeaderText = "Endereço";
            grdFornecedores.Columns["cidade_fornecedor"].HeaderText = "Cidade";
            grdFornecedores.Columns["telefone_fornecedor"].HeaderText = "Telefone";
            grdFornecedores.Columns["celular_fornecedor"].HeaderText = "Celular";

            grdFornecedores.Columns["id_fornecedor"].Visible = false;
            grdFornecedores.Columns["bairro_fornecedor"].Visible = false;
            grdFornecedores.Columns["cpfcnpj_fornecedor"].Visible = false;
            grdFornecedores.Columns["email_fornecedor"].Visible = false;
            grdFornecedores.Columns["id_usuario"].Visible = false;
            grdFornecedores.Columns["tb_usuario"].Visible = false;
            grdFornecedores.Columns["tb_produto"].Visible = false;
        }

        private void grdFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdFornecedores.SelectedRows.Count > 0)
            {
                tb_fornecedor ObjLinha = (tb_fornecedor)grdFornecedores.CurrentRow.DataBoundItem;

                txtCodigo.Text = ObjLinha.id_fornecedor.ToString();
                txtNome.Text = ObjLinha.nome_fornecedor;
                txtEndereco.Text = ObjLinha.endereco_fornecedor;
                txtBairro.Text = ObjLinha.bairro_fornecedor;
                txtCidade.Text = ObjLinha.cidade_fornecedor;
                txtTelefoneFixo.Text = ObjLinha.telefone_fornecedor;
                txtCelular.Text = ObjLinha.celular_fornecedor;
                txtCpfCnpj.Text = ObjLinha.cpfcnpj_fornecedor;
                txtEmail.Text = ObjLinha.email_fornecedor;

                panelExcluir.Enabled = true;
                btnSalvar.Text = "Alterar";
                txtNome.Focus();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
