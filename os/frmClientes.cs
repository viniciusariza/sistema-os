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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdClientes);
            EstadoInicial();
            cbFiltro.SelectedIndex = 0;
            CarregarGridCliente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tb_cliente ObjCliente = new tb_cliente();
                ClienteDAO ObjDAO = new ClienteDAO();

                ObjCliente.nome_cliente = txtNome.Text.Trim();
                ObjCliente.endereco_cliente = txtEndereco.Text.Trim();
                ObjCliente.bairro_cliente = txtBairro.Text.Trim();
                ObjCliente.cidade_cliente = txtCidade.Text.Trim();
                ObjCliente.telefone_cliente = txtTelefoneFixo.Text.Trim();
                ObjCliente.celular_cliente = txtCelular.Text.Trim();
                ObjCliente.cpf_cliente = txtCpfCnpj.Text.Trim();
                ObjCliente.email_cliente = txtEmail.Text.Trim();
                ObjCliente.id_usuario = Usuario.CodigoUsuarioLogado;

                try
                {
                    if (txtCodigo.Text == "")
                    {
                        ObjDAO.InserirCliente(ObjCliente);
                    }
                    else
                    {
                        ObjCliente.id_cliente = Convert.ToInt32(txtCodigo.Text);
                        ObjDAO.AlterarCliente(ObjCliente);
                    }
                    EstadoInicial();
                    CarregarGridCliente();
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
                ClienteDAO ObjDAO = new ClienteDAO();

                try
                {
                    ObjDAO.ExcluirCliente(Convert.ToInt32(txtCodigo.Text));
                    EstadoInicial();
                    CarregarGridCliente();
                }
                catch
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
                Util.ExibirMsgValidarCampos(campo);
            }
            return ret;
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdClientes.RowCount > 0)
            {

                tb_cliente ObjLinha = (tb_cliente)grdClientes.CurrentRow.DataBoundItem;

                txtCodigo.Text = ObjLinha.id_cliente.ToString();
                txtNome.Text = ObjLinha.nome_cliente;
                txtEndereco.Text = ObjLinha.endereco_cliente;
                txtBairro.Text = ObjLinha.bairro_cliente;
                txtCidade.Text = ObjLinha.cidade_cliente;
                txtTelefoneFixo.Text = ObjLinha.telefone_cliente;
                txtCelular.Text = ObjLinha.celular_cliente;
                txtCpfCnpj.Text = ObjLinha.cpf_cliente;
                txtEmail.Text = ObjLinha.email_cliente;

                panelExcluir.Enabled = true;
                btnSalvar.Text = "Alterar";
                txtNome.Focus();
            }
        }

        private void CarregarGridCliente()
        {
            ClienteDAO ObjDAO = new ClienteDAO();
            List<tb_cliente> lstClientes = ObjDAO.ConsultarCliente(Usuario.CodigoUsuarioLogado, txtFiltro.Text, cbFiltro.SelectedIndex);

            grdClientes.DataSource = lstClientes;

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
    }
}
