using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrdemServicoDAO
    {
        public void InserirOS(tb_os ObjOS)
        {
            banco ObjBanco = new banco();
            ObjBanco.AddTotb_os(ObjOS);
            ObjBanco.SaveChanges();
        }

        public void AlterarOSItem(tb_item_os item)
        {
            banco ObjBanco = new banco();
            ObjBanco.AddTotb_item_os(item);
            ObjBanco.SaveChanges();
        }

        public void AlterarOS(tb_os ObjOS)
        {
            banco ObjBanco = new banco();
            tb_os ObjResgate = ObjBanco.tb_os.Where(os => os.id_os == ObjOS.id_os).FirstOrDefault();

            ObjResgate.id_cliente = ObjOS.id_cliente;
            ObjResgate.retorno_os = ObjOS.retorno_os;
            ObjResgate.defeito_relatado_os = ObjOS.defeito_relatado_os;
            ObjResgate.observacoes_os = ObjOS.observacoes_os;
            ObjResgate.data_entrada_os = ObjOS.data_entrada_os;
            ObjResgate.equipamento_os = ObjOS.equipamento_os;
            ObjResgate.marca_os = ObjOS.marca_os;
            ObjResgate.modelo_os = ObjOS.modelo_os;
            ObjResgate.senha_os = ObjOS.senha_os;
            ObjResgate.finalizado_os = ObjOS.finalizado_os;
            ObjResgate.defeito_constatado_os = ObjOS.defeito_constatado_os;
            ObjResgate.servico_executado_os = ObjOS.servico_executado_os;
            ObjResgate.data_saida_os = ObjOS.data_saida_os;
            ObjResgate.id_funcionario = ObjOS.id_funcionario;
            ObjResgate.preco_servico_os = ObjOS.preco_servico_os;

            ObjBanco.SaveChanges();
        }

        public void ExcluirOS(int codOS)
        {
            banco ObjBanco = new banco();
            tb_os ObjResgate = ObjBanco.tb_os.Where(os => os.id_os == codOS).FirstOrDefault();

            ObjBanco.DeleteObject(ObjResgate);
            ObjBanco.SaveChanges();
        }

        public List<OrdemServicoVO> ConsutarOS(int codLogado, string filtro)
        {
            banco ObjBanco = new banco();
            List<tb_os> lstConsulta = new List<tb_os>();
            List<OrdemServicoVO> lstRetorno = new List<OrdemServicoVO>();

            if (filtro == "")
            {
                lstConsulta = ObjBanco.tb_os.Include("tb_cliente").Where(os => os.id_usuario == codLogado).ToList();
            }
            else
            {
                lstConsulta = ObjBanco.tb_os.Include("tb_cliente").Where(os => os.id_usuario == codLogado && os.tb_cliente.nome_cliente.Contains(filtro)).ToList();
            }

            for (int i = 0; i < lstConsulta.Count; i++)
            {
                OrdemServicoVO ObjOs = new OrdemServicoVO();

                ObjOs.Cliente = lstConsulta[i].tb_cliente.nome_cliente;
                ObjOs.DataEntrada = lstConsulta[i].data_entrada_os;
                ObjOs.Equipamento = lstConsulta[i].equipamento_os;
                ObjOs.Finalizado = lstConsulta[i].finalizado_os;
                ObjOs.Marca = lstConsulta[i].marca_os;
                ObjOs.Modelo = lstConsulta[i].modelo_os;
                ObjOs.Retorno = lstConsulta[i].retorno_os;
                ObjOs.ObjOS = lstConsulta[i];

                lstRetorno.Add(ObjOs);
            }
            return lstRetorno.OrderByDescending(os => os.DataEntrada).ToList();
        }

        public List<tb_item_os> ConsultarListaProdutos(int codOS)
        {
            banco ObjBanco = new banco();
            List<tb_item_os> lstItem = ObjBanco.tb_item_os.Include("tb_produto").Where(i => i.id_os == codOS).ToList();
            return lstItem;
        }
    }
}
