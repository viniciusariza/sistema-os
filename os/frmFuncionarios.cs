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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdFuncionarios);
            EstadoInicial();
            cbFiltro.SelectedIndex = 0;
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tb_funcionario ObjFuncionario = new tb_funcionario();
                FuncionarioDAO ObjDAO = new FuncionarioDAO();

                ObjFuncionario.nome_funcionario = txtNome.Text.Trim();
                ObjFuncionario.endereco_funcionario = txtEndereco.Text.Trim();
                ObjFuncionario.bairro_funcionario = txtBairro.Text.Trim();
                ObjFuncionario.cidade_funcionario = txtCidade.Text.Trim();
                ObjFuncionario.celular_funcionario = txtCelular.Text.Trim();
                ObjFuncionario.cpf_funcionario = txtCpfCnpj.Text.Trim();
                ObjFuncionario.data_ad_funcionario = dtAdmissao.Value;
                ObjFuncionario.situacao_funcionario = chkSituacao.Checked;
                ObjFuncionario.id_usuario = Usuario.CodigoUsuarioLogado;

                try
                {
                    if (txtCodigo.Text == "")
                    {
                        ObjDAO.InserirFuncionario(ObjFuncionario);
                    }
                    else
                    {
                        ObjFuncionario.id_funcionario = Convert.ToInt32(txtCodigo.Text);
                        ObjDAO.AlterarFuncionario(ObjFuncionario);
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
            if(Util.ExibirMsgDesejaExcluir())
            {
                FuncionarioDAO ObjDAO = new FuncionarioDAO();
                try
                {
                    ObjDAO.ExcluirFuncionario(Convert.ToInt32(txtCodigo.Text));
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
            txtCelular.Clear();
            txtCidade.Clear();
            txtCodigo.Clear();
            txtCpfCnpj.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            chkSituacao.Checked = true;

            btnSalvar.Text = "Cadastrar";
            btnExcluir.Enabled = false;
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

            if (txtCelular.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Celular";
            }

            if (!ret)
            {
                Util.ExibirMsgValidarCampos(campo);
            }

            return ret;
        }

        private void CarregarGrid()
        {
            FuncionarioDAO ObjDAO = new FuncionarioDAO();

            List<tb_funcionario> lstFuncionario =  ObjDAO.ConsultarFuncionario(Usuario.CodigoUsuarioLogado,txtFiltro.Text,cbFiltro.SelectedIndex);

            grdFuncionarios.DataSource = lstFuncionario;

            grdFuncionarios.Columns["nome_funcionario"].HeaderText = "Nome";
            grdFuncionarios.Columns["endereco_funcionario"].HeaderText = "Endereço";
            grdFuncionarios.Columns["cidade_funcionario"].HeaderText = "Cidade";
            grdFuncionarios.Columns["celular_funcionario"].HeaderText = "Celular";
            grdFuncionarios.Columns["situacao_funcionario"].HeaderText = "Situação";
            grdFuncionarios.Columns["data_ad_funcionario"].HeaderText = "Admissão";

            grdFuncionarios.Columns["bairro_funcionario"].Visible = false;
            grdFuncionarios.Columns["cpf_funcionario"].Visible = false;
            grdFuncionarios.Columns["id_funcionario"].Visible = false;
            grdFuncionarios.Columns["id_usuario"].Visible = false;
            grdFuncionarios.Columns["tb_usuario"].Visible = false;
            grdFuncionarios.Columns["tb_os"].Visible = false;
            grdFuncionarios.Columns["tb_venda"].Visible = false;
        }

        private void grdFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdFuncionarios.RowCount > 0)
            {
                tb_funcionario ObjLinha = (tb_funcionario) grdFuncionarios.CurrentRow.DataBoundItem;

                txtCodigo.Text = ObjLinha.id_funcionario.ToString() ;
                txtNome.Text = ObjLinha.nome_funcionario;
                txtEndereco.Text = ObjLinha.endereco_funcionario;
                txtBairro.Text = ObjLinha.bairro_funcionario;
                txtCidade.Text = ObjLinha.cidade_funcionario;
                txtCelular.Text = ObjLinha.celular_funcionario;
                txtCpfCnpj.Text = ObjLinha.cpf_funcionario;
                dtAdmissao.Value = (DateTime) ObjLinha.data_ad_funcionario;
                chkSituacao.Checked = (bool)ObjLinha.situacao_funcionario;

                btnSalvar.Text = "Alterar";
                btnExcluir.Enabled = true;
                txtNome.Focus();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
