using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ItemDAO
    {
        public void ExcluirItens(int codOS)
        {
            banco ObjBanco = new banco();
            List<tb_item_os> lstItem = ObjBanco.tb_item_os.Where(i => i.id_os == codOS).ToList();

            for (int i = 0; i < lstItem.Count; i++)
            {
                tb_item_os ObjResgate = lstItem[i];
                ObjBanco.DeleteObject(ObjResgate);
            }
            ObjBanco.SaveChanges();
        }
        public List<ItemVO> ConsultarItens (int codVenda)
        {
            banco ObjBanco = new banco();
            List<tb_item_venda> lstConsulta = new List<tb_item_venda>();
            List<ItemVO> lstRetorno = new List<ItemVO>();

            lstConsulta = ObjBanco.tb_item_venda.Include("tb_produto").Where(it => it.id_venda == codVenda).ToList();

            for (int i = 0; i < lstConsulta.Count; i++)
            {
                ItemVO vo = new ItemVO();

                vo.Produto = lstConsulta[i].tb_produto.nome_produto;
                vo.Quantidade = lstConsulta[i].qtd_item_venda;
                vo.Preco = lstConsulta[i].tb_produto.venda_produto;

                lstRetorno.Add(vo);
            }
            return lstRetorno;
        }
    }
}
