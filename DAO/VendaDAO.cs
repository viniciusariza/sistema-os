using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VendaDAO
    {
        public void InserirVenda(tb_venda ObjVenda)
        {
            banco ObjBanco = new banco();
            ObjBanco.AddTotb_venda(ObjVenda);
            ObjBanco.SaveChanges();
        }

        public List<VendaVO> ConsultarVendas(int codUsuario, string filtro, bool pesquisarData, DateTime dtInicial, DateTime dtFinal)
        {
            banco ObjBanco = new banco();
            List<tb_venda> lstConsulta = new List<tb_venda>();
            List<VendaVO> lstRetorno = new List<VendaVO>();
            
                if (filtro.Trim() == "" && !pesquisarData)
            {
                lstConsulta = ObjBanco.tb_venda.Include("tb_cliente").Where(v => v.id_usuario == codUsuario).ToList();
            }
            else if(filtro.Trim() == "" && pesquisarData)
            {
                lstConsulta = ObjBanco.tb_venda.Include("tb_cliente").Where(v => v.id_usuario == codUsuario && v.data_venda >= dtInicial && v.data_venda <= dtFinal).ToList();
            }
            else if(filtro.Trim() != "" && !pesquisarData)
            {
                lstConsulta = ObjBanco.tb_venda.Include("tb_cliente").Where(v => v.id_usuario == codUsuario && v.tb_cliente.nome_cliente.Contains(filtro)).ToList();
            }
            else
            {
                lstConsulta = ObjBanco.tb_venda.Include("tb_cliente").Where(v => v.id_usuario == codUsuario && v.tb_cliente.nome_cliente.Contains(filtro) && v.data_venda >= dtInicial && v.data_venda <= dtFinal).ToList();
            }

            for (int i = 0; i < lstConsulta.Count; i++)
            {
                VendaVO vo = new VendaVO();
                vo.Data = lstConsulta[i].data_venda;
                vo.Cliente = lstConsulta[i].tb_cliente.nome_cliente;
                vo.Operacao = lstConsulta[i].operacao_venda;
                vo.idVenda = lstConsulta[i].id_venda;

                int idVenda = lstConsulta[i].id_venda;
                decimal valor = 0;
                vo.Total = 0;

                List<tb_item_venda> lstItens = ObjBanco.tb_item_venda.Include("tb_produto").Where(it => it.id_venda == idVenda).ToList();

                for (int j = 0; j < lstItens.Count; j++)
                {
                    valor += lstItens[j].qtd_item_venda * lstItens[j].tb_produto.venda_produto; 
                }

                vo.Total = valor + lstConsulta[i].acrescimo_venda - lstConsulta[i].desconto_venda;
                lstItens = null;
                lstRetorno.Add(vo);
            }
            return lstRetorno.OrderByDescending(v => v.Data).ToList();
        }
    }
}
