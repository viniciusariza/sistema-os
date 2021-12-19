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
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Data.Objects;

namespace os
{
    public partial class frmOrdemServico : Form
    {
        public frmOrdemServico()
        {
            InitializeComponent();
        }

        List<tb_item_os> lstItem = new List<tb_item_os>();
        List<tb_item_os> lstItemAuxiliar = new List<tb_item_os>();
        private void frmOrdemServico_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(grdOS);
            Util.ConfigurarCombo(cbTecnico, "nome_funcionario", "id_funcionario");
            ValidarFinalizado();
            CarregarCombo();
            EstadoInicial();
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                OrdemServicoDAO ObjDAO = new OrdemServicoDAO();
                tb_os ObjOS = new tb_os();
                ProdutoDAO ObjProdutoDAO = new ProdutoDAO();
                ItemDAO ObjItemDAO = new ItemDAO();

                ObjOS.data_entrada_os = dtEntrada.Value.Date;
                ObjOS.data_saida_os = dtSaida.Value.Date;
                ObjOS.defeito_constatado_os = txtDefeitoConstatado.Text.Trim();
                ObjOS.defeito_relatado_os = txtDefeitoRelatado.Text.Trim();
                ObjOS.equipamento_os = txtEquipamento.Text.Trim();
                ObjOS.finalizado_os = chkFinalizado.Checked;
                ObjOS.id_cliente = Convert.ToInt32(txtCodCliente.Text);
                ObjOS.id_funcionario = Convert.ToInt32(cbTecnico.SelectedValue);
                ObjOS.id_usuario = Usuario.CodigoUsuarioLogado;
                ObjOS.marca_os = txtMarca.Text.Trim();
                ObjOS.modelo_os = txtModelo.Text.Trim();
                ObjOS.observacoes_os = txtObservacoes.Text.Trim();
                ObjOS.preco_servico_os = txtPrecoServico.Text == "" ? 0 : Convert.ToDecimal(txtPrecoServico.Text.Trim());
                ObjOS.retorno_os = chkRetorno.Checked;
                ObjOS.senha_os = txtSenha.Text.Trim();
                ObjOS.servico_executado_os = txtServicoExecutado.Text.Trim();

                if (txtCodOS.Text == "")
                {
                    try
                    {
                        for (int i = 0; i < lstItem.Count; i++)
                        {
                            tb_item_os item = new tb_item_os();
                            item.id_produto = lstItem[i].id_produto;
                            item.qtd_item_os = lstItem[i].qtd_item_os;
                            ObjOS.tb_item_os.Add(item);
                        }

                        ObjDAO.InserirOS(ObjOS);

                        for (int i = 0; i < lstItem.Count; i++)
                        {
                            ObjProdutoDAO.DiminuirQtdProduto(lstItem[i].id_produto, lstItem[i].qtd_item_os);
                        }
                    }
                    catch
                    {
                        Util.ExibirMsg(Util.TipoMsg.Erro);
                    }
                }
                else
                {
                    try
                    {
                        ObjOS.id_os = Convert.ToInt32(txtCodOS.Text);
                        ObjItemDAO.ExcluirItens(ObjOS.id_os);

                        for (int i = 0; i < lstItem.Count; i++)
                        {
                            tb_item_os item = new tb_item_os();
                            item.id_produto = lstItem[i].id_produto;
                            item.qtd_item_os = lstItem[i].qtd_item_os;
                            item.id_os = Convert.ToInt32(txtCodOS.Text);
                            ObjDAO.AlterarOSItem(item);
                        }
                        for (int i = 0; i < lstItemAuxiliar.Count; i++)
                        {
                            tb_item_os item = new tb_item_os();
                            item.id_produto = lstItemAuxiliar[i].id_produto;
                            item.qtd_item_os = lstItemAuxiliar[i].qtd_item_os;
                            item.id_os = Convert.ToInt32(txtCodOS.Text);
                            ObjDAO.AlterarOSItem(item);
                        }

                        ObjDAO.AlterarOS(ObjOS);

                        for (int i = 0; i < lstItemAuxiliar.Count; i++)
                        {
                            ObjProdutoDAO.DiminuirQtdProduto(lstItemAuxiliar[i].id_produto, lstItemAuxiliar[i].qtd_item_os);
                        }
                    }
                    catch
                    {
                        Util.ExibirMsg(Util.TipoMsg.Erro);
                    }
                }
                EstadoInicial();
                CarregarGrid();
                lstItem.Clear();
                lstItemAuxiliar.Clear();
                Util.ExibirMsg(Util.TipoMsg.Sucesso);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Imprimir();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            EstadoOS();
            txtFiltro.Focus();
            grdOS.ClearSelection();
        }

        private void EstadoOS()
        {
            panelOS.Visible = false;
            panelConsultaOS.Visible = true;
        }

        private void Imprimir()
        {
            string nome_empresa = "Teste Informática LTDA";
            string telefone_empresa = "(43) 3258-8987";
            string celular_empresa = "(43) 98448-8595";
            string email_empresa = "vinicusarizaibi@gmail.com";

            tb_cliente ObjImpressaoCliente = new ClienteDAO().ConsultarImpressao(Convert.ToInt32(txtCodCliente.Text));

            string nome_cliente = txtCliente.Text;
            string cpf_cliente = ObjImpressaoCliente.cpf_cliente;
            string endereco_cliente = ObjImpressaoCliente.endereco_cliente;
            string bairro_cliente = ObjImpressaoCliente.bairro_cliente;
            string cidade_cliente = ObjImpressaoCliente.cidade_cliente;
            string telefone_cliente = ObjImpressaoCliente.telefone_cliente;
            string celular_cliente = ObjImpressaoCliente.celular_cliente;
            string data_entrada = dtEntrada.Text;
            bool retorno_entrada = chkRetorno.Checked;
            string senha_entrada = txtSenha.Text;
            string defeito_relatado = txtDefeitoRelatado.Text;
            string observacoes_entrada = txtObservacoes.Text;
            string equipamento_entrada = txtEquipamento.Text;
            string marca_entrada = txtMarca.Text;
            string modelo_entrada = txtModelo.Text;
            string data_saida = dtSaida.Text;
            string tecnico_saida = cbTecnico.Text;
            string defeito_saida = txtDefeitoConstatado.Text;
            string servico_saida = txtServicoExecutado.Text;
            string pecas_saida = txtPecas.Text;
            string precoserv_saida = txtPrecoServico.Text;
            string precopecas_saida = txtPrecoPecas.Text;
            string total_saida = txtTotal.Text;
            bool finalizado_saida = chkFinalizado.Checked;

            Impressao.OrdemServico(nome_empresa, telefone_empresa, celular_empresa, email_empresa,
                                    nome_cliente, cpf_cliente, endereco_cliente, bairro_cliente, cidade_cliente,
                                    telefone_cliente, celular_cliente, data_entrada, retorno_entrada, senha_entrada,
                                    defeito_relatado, observacoes_entrada, equipamento_entrada, marca_entrada, modelo_entrada,
                                    data_saida, tecnico_saida, defeito_saida, servico_saida, pecas_saida, finalizado_saida, precoserv_saida,
                                    precopecas_saida, total_saida);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            EstadoAlterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.ExibirMsgDesejaExcluir())
            {
                if (Util.ExibirMsgRetornarEstoque())
                {
                    ProdutoDAO ObjProdutoDAO = new ProdutoDAO();

                    for (int i = 0; i < lstItem.Count; i++)
                    {
                        ObjProdutoDAO.AumentarQtdProduto(lstItem[i].id_produto, lstItem[i].qtd_item_os);
                    }
                }
                OrdemServicoDAO ObjDAOOS = new OrdemServicoDAO();
                ItemDAO ObjDAOItem = new ItemDAO();
                try
                {
                    ObjDAOItem.ExcluirItens(Convert.ToInt32(txtCodOS.Text));
                    ObjDAOOS.ExcluirOS(Convert.ToInt32(txtCodOS.Text));
                    EstadoInicial();
                    EstadoOS();
                    CarregarGrid();
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }

        private void btnImprimirConsulta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Imprimir();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarClientes consultarClientes = new frmConsultarClientes(this);
            consultarClientes.ShowDialog();
        }

        private void btnPecas_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos consultarProdutos = new frmConsultarProdutos(this);
            consultarProdutos.ShowDialog();
        }

        private void CalcularTotal()
        {
            decimal precoServ = txtPrecoServico.Text == "" ? 0 : Convert.ToDecimal(txtPrecoServico.Text);
            decimal precoPecas = txtPrecoPecas.Text == "" ? 0 : Convert.ToDecimal(txtPrecoPecas.Text);
            txtTotal.Text = (precoServ + precoPecas).ToString("N2");
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campo = "";

            if (txtCliente.Text.Trim() == "")
            {
                ret = false;
                campo = "- Cliente";
            }

            if (txtDefeitoRelatado.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Defeito Relatado";
            }

            if (txtEquipamento.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Equipamento";
            }

            if (txtMarca.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Marca";
            }

            if (txtModelo.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Modelo";
            }

            if (!ret)
            {
                Util.ExibirMsgValidarCampos(campo);
            }

            return ret;
        }

        private void ValidarFinalizado()
        {
            if (!chkFinalizado.Checked)
            {
                btnPecas.Enabled = false;
                btnRemoverPecas.Enabled = false;
                txtDefeitoConstatado.Enabled = false;
                txtServicoExecutado.Enabled = false;
                dtSaida.Enabled = false;
                cbTecnico.Enabled = false;
                txtPrecoServico.Enabled = false;
            }
            else
            {
                btnPecas.Enabled = true;
                btnRemoverPecas.Enabled = true;
                txtDefeitoConstatado.Enabled = true;
                txtServicoExecutado.Enabled = true;
                dtSaida.Enabled = true;
                cbTecnico.Enabled = true;
                txtPrecoServico.Enabled = true;
            }
        }

        private void CarregarCombo()
        {
            FuncionarioDAO ObjDAO = new FuncionarioDAO();
            cbTecnico.DataSource = ObjDAO.FiltrarFuncionarioAtivo(Usuario.CodigoUsuarioLogado);
        }

        private void CarregarGrid()
        {
            OrdemServicoDAO ObjDAO = new OrdemServicoDAO();
            grdOS.DataSource = ObjDAO.ConsutarOS(Usuario.CodigoUsuarioLogado, txtFiltro.Text);

            grdOS.Columns["ObjOS"].Visible = false;
            grdOS.Columns["DataEntrada"].HeaderText = "Data de Entrada";
        }

        private void EstadoInicial()
        {
            panelConsultaOS.Visible = false;
            panelOS.Visible = true;

            txtCodCliente.Clear();
            txtCodOS.Clear();
            txtCliente.Clear();
            txtDefeitoRelatado.Clear();
            txtObservacoes.Clear();
            txtEquipamento.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtSenha.Clear();

            txtPecas.Clear();
            txtDefeitoConstatado.Clear();
            txtServicoExecutado.Clear();
            txtPrecoServico.Clear();
            txtPrecoPecas.Clear();
            txtTotal.Clear();
            lstItem.Clear();
            lstItemAuxiliar.Clear();
            cbTecnico.SelectedIndex = 0;

            btnSalvar.Text = "Cadastrar";
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnImprimirConsulta.Enabled = false;
            chkRetorno.Checked = false;
            chkFinalizado.Checked = false;
        }

        private void EstadoAlterar()
        {
            panelConsultaOS.Visible = false;
            panelOS.Visible = true;
        }

        private bool ValidarItem(int idProduto)
        {
            bool ret = true;

            for (int i = 0; i < lstItem.Count; i++)
            {
                if (idProduto == lstItem[i].id_produto)
                {
                    ret = false;
                    Util.ExibirMsg(Util.TipoMsg.ProdutoRepetido);
                }
            }
            return ret;
        }

        public void SelecionarCliente(tb_cliente objCliente)
        {
            txtCliente.Text = objCliente.nome_cliente;
            txtCodCliente.Text = objCliente.id_cliente.ToString();
        }

        public void SelecionarProduto(tb_produto objProduto)
        {
            try
            {
                int qtd = Convert.ToInt32(Interaction.InputBox("Quantidade", objProduto.nome_produto));
                while (qtd < 1)
                {
                    MessageBox.Show("Quantidade inválida");
                    qtd = Convert.ToInt32(Interaction.InputBox("Quantidade", objProduto.nome_produto));
                }
                InformacoesProduto.qtdProduto = qtd;
                InformacoesProduto.codProduto = objProduto.id_produto;
                InformacoesProduto.nomeProduto = objProduto.nome_produto;
                if (ValidarItem(InformacoesProduto.codProduto))
                {
                    ProdutoDAO ObjProdutoDAO = new ProdutoDAO();
                    int estoque = ObjProdutoDAO.ConsultarQtdProduto(InformacoesProduto.codProduto);
                    if (estoque >= InformacoesProduto.qtdProduto)
                    {
                        if (txtPecas.Text == "")
                        {
                            txtPecas.Text += InformacoesProduto.qtdProduto + " " + InformacoesProduto.nomeProduto;
                        }
                        else
                        {
                            txtPecas.Text += ", " + InformacoesProduto.qtdProduto + " " + InformacoesProduto.nomeProduto;
                        }
                        tb_item_os ObjItem = new tb_item_os();
                        ObjItem.id_produto = InformacoesProduto.codProduto;
                        ObjItem.qtd_item_os = InformacoesProduto.qtdProduto;

                        if (txtCodOS.Text == "")
                        {
                            lstItem.Add(ObjItem);
                        }
                        else
                        {
                            lstItemAuxiliar.Add(ObjItem);
                        }

                        CalcularPrecoPecas();
                        CalcularTotal();
                        CarregarGrid();
                    }
                    else
                    {
                        Util.ExibirMsg(Util.TipoMsg.SemEstoque);
                    }
                }
            }
            catch
            {
                MessageBox.Show("O produto não foi adicionado");
            }
        }

        public void CalcularPrecoPecas()
        {
            if (txtPecas.Text == "")
            {
                txtPrecoPecas.Text = "";
            }
            else
            {
                decimal precoPecas = 0;
                for (int i = 0; i < lstItem.Count; i++)
                {
                    precoPecas += lstItem[i].qtd_item_os * new ProdutoDAO().ConsultarPrecoProduto(lstItem[i].id_produto);
                }
                for (int i = 0; i < lstItemAuxiliar.Count; i++)
                {
                    precoPecas += lstItemAuxiliar[i].qtd_item_os * new ProdutoDAO().ConsultarPrecoProduto(lstItemAuxiliar[i].id_produto);

                }
                txtPrecoPecas.Text = precoPecas.ToString("N2");
            }
        }

        private void btnRemoverPecas_Click(object sender, EventArgs e)
        {
            if (txtCodOS.Text == "")
            {
                if (Util.ExibirMsgDesejaRemoverItens())
                {
                    lstItem.Clear();
                    lstItemAuxiliar.Clear();
                    CalcularPrecoPecas();
                    txtPecas.Clear();
                    CalcularPrecoPecas();
                    CalcularTotal();
                    CarregarGrid();
                }
            }
            else
            {
                Util.ExibirMsg(Util.TipoMsg.ExcluirItemOSEditada);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txtPrecoServico_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void grdOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdOS.RowCount > 0)
            {
                OrdemServicoVO ObjResgate = new OrdemServicoVO();
                OrdemServicoDAO ObjDAO = new OrdemServicoDAO();

                ObjResgate = (OrdemServicoVO)grdOS.CurrentRow.DataBoundItem;
                tb_os ObjLinha = ObjResgate.ObjOS;

                txtCodOS.Text = ObjLinha.id_os.ToString();
                txtCodCliente.Text = ObjLinha.id_cliente.ToString();
                txtCliente.Text = ObjLinha.tb_cliente.nome_cliente;
                chkRetorno.Checked = ObjLinha.retorno_os;
                txtDefeitoRelatado.Text = ObjLinha.defeito_relatado_os;
                txtObservacoes.Text = ObjLinha.observacoes_os;
                dtEntrada.Value = ObjLinha.data_entrada_os;
                txtEquipamento.Text = ObjLinha.equipamento_os;
                txtMarca.Text = ObjLinha.marca_os;
                txtModelo.Text = ObjLinha.modelo_os;
                txtSenha.Text = ObjLinha.senha_os;

                chkFinalizado.Checked = ObjLinha.finalizado_os;
                txtDefeitoConstatado.Text = ObjLinha.defeito_constatado_os;
                txtServicoExecutado.Text = ObjLinha.servico_executado_os;
                dtSaida.Value = (DateTime)ObjLinha.data_saida_os;
                cbTecnico.SelectedValue = ObjLinha.id_funcionario;
                txtPrecoServico.Text = ObjLinha.preco_servico_os.ToString();
                lstItem = ObjDAO.ConsultarListaProdutos(Convert.ToInt32(txtCodOS.Text));

                for (int i = 0; i < lstItem.Count; i++)
                {
                    if (txtPecas.Text == "")
                    {
                        txtPecas.Text += lstItem[i].qtd_item_os + " " + lstItem[i].tb_produto.nome_produto;
                    }
                    else
                    {
                        txtPecas.Text += ", " + lstItem[i].qtd_item_os + " " + lstItem[i].tb_produto.nome_produto;
                    }
                }
                CalcularPrecoPecas();
                CalcularTotal();
                btnSalvar.Text = "Salvar";
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnImprimirConsulta.Enabled = true;
                txtFiltro.Focus();
            }
        }

        private void txtPrecoServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrecoServico.Text.IndexOf(",") == -1 && txtPrecoServico.Text != "")
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

        private void chkFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            ValidarFinalizado();
        }

        private void grdOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in grdOS.Rows)
            {
                if (!Convert.ToBoolean(row.Cells["Finalizado"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkOrange;
                }
            }
        }
    }
}
