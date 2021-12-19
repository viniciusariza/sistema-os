using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os
{
    public static class Util
    {
        public enum TipoMsg
        {
            Sucesso,
            Erro,
            ErroExcluir,
            ListaVazia,
            ErroAcrescimoDesconto,
            SemEstoque,
            ProdutoRepetido,
            ExcluirItemOSEditada
        }

        public static void ExibirMsg(TipoMsg tipo)
        {
            switch (tipo)
            {
                case TipoMsg.Sucesso:
                    MessageBox.Show("Operação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoMsg.Erro:
                    MessageBox.Show("Ocorreu um erro, tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMsg.ErroExcluir:
                    MessageBox.Show("Não foi possível excluir o item.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMsg.ListaVazia:
                    MessageBox.Show("A venda deve conter no mínimo um item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMsg.ErroAcrescimoDesconto:
                    MessageBox.Show("Você já aplicou um acréscimo/desconto, caso queira aplicar outro valor de acréscimo/desconto inicie uma nova venda", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                case TipoMsg.SemEstoque:
                    MessageBox.Show("Não há estoque suficiente do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoMsg.ProdutoRepetido:
                    MessageBox.Show("O produto já foi adicionado anteriormente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoMsg.ExcluirItemOSEditada:
                    MessageBox.Show("Não é possível remover os itens, pois os mesmos já foram abatidos no estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

        }

        public static bool ExibirMsgDesejaExcluir()
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este item permanentemente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ExibirMsgRetornarEstoque()
        {
            if (MessageBox.Show("Dejea que os itens/peças exluidos retornem ao estoque?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ExibirMsgDesejaRemoverItens()
        {
            if (MessageBox.Show("Tem certeza que deseja remover todas as peças adicionadas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ExibirMsgValidarCampos(string campo)
        {
            MessageBox.Show("Preencha o(s) campo(s):\n\n" + campo, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ConfigurarGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
        }

        public static void ConfigurarCombo(ComboBox cb, string display, string value)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.DisplayMember = display;
            cb.ValueMember = value;
        }

    }
}
