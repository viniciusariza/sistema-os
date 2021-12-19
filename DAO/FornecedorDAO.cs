using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FornecedorDAO
    {
        public void InserirFornecedor(tb_fornecedor ObjFornecedor)
        {
            banco ObjBanco = new banco();
            ObjBanco.AddTotb_fornecedor(ObjFornecedor);
            ObjBanco.SaveChanges();
        }

        public void AlterarFornecedor(tb_fornecedor ObjFornecedor)
        {
            banco ObjBanco = new banco();
            tb_fornecedor ObjResgate = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_fornecedor == ObjFornecedor.id_fornecedor).FirstOrDefault();

            ObjResgate.nome_fornecedor = ObjFornecedor.nome_fornecedor;
            ObjResgate.endereco_fornecedor = ObjFornecedor.endereco_fornecedor;
            ObjResgate.bairro_fornecedor = ObjFornecedor.bairro_fornecedor;
            ObjResgate.cidade_fornecedor = ObjFornecedor.cidade_fornecedor;
            ObjResgate.telefone_fornecedor = ObjFornecedor.telefone_fornecedor;
            ObjResgate.celular_fornecedor = ObjFornecedor.celular_fornecedor;
            ObjResgate.cpfcnpj_fornecedor = ObjFornecedor.cpfcnpj_fornecedor;
            ObjResgate.email_fornecedor = ObjFornecedor.email_fornecedor;

            ObjBanco.SaveChanges();
        }

        public void ExcluirFornecedor(int codFornecedor)
        {
            banco ObjBanco = new banco();
            tb_fornecedor ObjResgate = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_fornecedor == codFornecedor).FirstOrDefault();

            ObjBanco.DeleteObject(ObjResgate);
            ObjBanco.SaveChanges();
        }

        public List<tb_fornecedor> ConsultarFornecedor(int codLogado, string filtro, int cbIndex)
        {
            banco ObjBanco = new banco();

            List<tb_fornecedor> lstFornecedor = new List<tb_fornecedor>();

            if (filtro.Trim() == "")
            {
                lstFornecedor = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_usuario == codLogado).OrderBy(fornecedor => fornecedor.nome_fornecedor).ToList();
            }
            else
            {
                if (cbIndex == 0)
                {
                    lstFornecedor = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_usuario == codLogado && fornecedor.nome_fornecedor.Contains(filtro)).OrderBy(fornecedor => fornecedor.nome_fornecedor).ToList();
                }
                if (cbIndex == 1)
                {
                    lstFornecedor = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_usuario == codLogado && fornecedor.endereco_fornecedor.Contains(filtro)).OrderBy(fornecedor => fornecedor.nome_fornecedor).ToList();
                }
                if (cbIndex == 2)
                {
                    lstFornecedor = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_usuario == codLogado && fornecedor.cidade_fornecedor.Contains(filtro)).OrderBy(fornecedor => fornecedor.nome_fornecedor).ToList();
                }
                if (cbIndex == 3)
                {
                    lstFornecedor = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_usuario == codLogado && fornecedor.telefone_fornecedor.Contains(filtro)).OrderBy(fornecedor => fornecedor.nome_fornecedor).ToList();
                }
                if (cbIndex == 4)
                {
                    lstFornecedor = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_usuario == codLogado && fornecedor.celular_fornecedor.Contains(filtro)).OrderBy(fornecedor => fornecedor.nome_fornecedor).ToList();
                }
                if (cbIndex == 5)
                {
                    lstFornecedor = ObjBanco.tb_fornecedor.Where(fornecedor => fornecedor.id_usuario == codLogado && fornecedor.cpfcnpj_fornecedor.Contains(filtro)).OrderBy(fornecedor => fornecedor.nome_fornecedor).ToList();
                }
            }

            return lstFornecedor;
        }
    }
}
