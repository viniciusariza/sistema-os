using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClienteDAO
    {
        public void InserirCliente(tb_cliente ObjCliente)
        {
            banco ObjBanco = new banco();
            ObjBanco.AddTotb_cliente(ObjCliente);
            ObjBanco.SaveChanges();
        }

        public void AlterarCliente(tb_cliente ObjCliente)
        {
            banco ObjBanco = new banco();
            tb_cliente ObjResgate = ObjBanco.tb_cliente.Where(cliente => cliente.id_cliente == ObjCliente.id_cliente).FirstOrDefault();
            
            ObjResgate.nome_cliente = ObjCliente.nome_cliente;
            ObjResgate.endereco_cliente = ObjCliente.endereco_cliente;
            ObjResgate.bairro_cliente = ObjCliente.bairro_cliente;
            ObjResgate.cidade_cliente = ObjCliente.cidade_cliente;
            ObjResgate.telefone_cliente = ObjCliente.telefone_cliente;
            ObjResgate.celular_cliente = ObjCliente.celular_cliente;
            ObjResgate.cpf_cliente = ObjCliente.cpf_cliente;
            ObjResgate.email_cliente = ObjCliente.email_cliente;

            ObjBanco.SaveChanges();
        }

        public void ExcluirCliente(int codCliente)
        {
            banco ObjBanco = new banco();
            tb_cliente ObjResgate = ObjBanco.tb_cliente.Where(cliente => cliente.id_cliente == codCliente).FirstOrDefault();

            ObjBanco.DeleteObject(ObjResgate);
            ObjBanco.SaveChanges();
        }

        public List<tb_cliente> ConsultarCliente(int codLogado, string filtro, int cbIndex)
        {
            banco ObjBanco = new banco();

            List<tb_cliente> lstCliente = new List<tb_cliente>();

            if(filtro.Trim() == "")
            {
                lstCliente = ObjBanco.tb_cliente.Where(cliente => cliente.id_usuario == codLogado).OrderBy(cliente => cliente.nome_cliente).ToList();
            }
            else
            {
                if (cbIndex == 0)
                {
                    lstCliente = ObjBanco.tb_cliente.Where(cliente => cliente.id_usuario == codLogado && cliente.nome_cliente.Contains(filtro)).OrderBy(cliente => cliente.nome_cliente).ToList();
                }
                if (cbIndex == 1)
                {
                    lstCliente = ObjBanco.tb_cliente.Where(cliente => cliente.id_usuario == codLogado && cliente.endereco_cliente.Contains(filtro)).OrderBy(cliente => cliente.nome_cliente).ToList();
                }
                if (cbIndex == 2)
                {
                    lstCliente = ObjBanco.tb_cliente.Where(cliente => cliente.id_usuario == codLogado && cliente.cidade_cliente.Contains(filtro)).OrderBy(cliente => cliente.nome_cliente).ToList();
                }
                if (cbIndex == 3)
                {
                    lstCliente = ObjBanco.tb_cliente.Where(cliente => cliente.id_usuario == codLogado && cliente.telefone_cliente.Contains(filtro)).OrderBy(cliente => cliente.nome_cliente).ToList();
                }
                if (cbIndex == 4)
                {
                    lstCliente = ObjBanco.tb_cliente.Where(cliente => cliente.id_usuario == codLogado && cliente.celular_cliente.Contains(filtro)).OrderBy(cliente => cliente.nome_cliente).ToList();
                }
                if (cbIndex == 5)
                {
                    lstCliente = ObjBanco.tb_cliente.Where(cliente => cliente.id_usuario == codLogado && cliente.cpf_cliente.Contains(filtro)).OrderBy(cliente => cliente.nome_cliente).ToList();
                }
            }
            
            return lstCliente;
        }

        public tb_cliente ConsultarImpressao(int codCliente)
        {
            banco ObjBanco = new banco();
            tb_cliente cliente = ObjBanco.tb_cliente.Where(c => c.id_cliente == codCliente).FirstOrDefault();
            return cliente;
        }

    }
}
