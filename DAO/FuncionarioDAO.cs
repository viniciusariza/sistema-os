using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FuncionarioDAO
    {
        public void InserirFuncionario(tb_funcionario ObjFuncionario)
        {
            banco ObjBanco = new banco();
            ObjBanco.AddTotb_funcionario(ObjFuncionario);
            ObjBanco.SaveChanges();
        }

        public void AlterarFuncionario(tb_funcionario ObjFuncionario)
        {
            banco ObjBanco = new banco();

            tb_funcionario ObjResgate = ObjBanco.tb_funcionario.Where(func => func.id_funcionario == ObjFuncionario.id_funcionario).FirstOrDefault();

            ObjResgate.nome_funcionario = ObjFuncionario.nome_funcionario;
            ObjResgate.endereco_funcionario = ObjFuncionario.endereco_funcionario;
            ObjResgate.bairro_funcionario = ObjFuncionario.bairro_funcionario;
            ObjResgate.cidade_funcionario = ObjFuncionario.cidade_funcionario;
            ObjResgate.celular_funcionario = ObjFuncionario.celular_funcionario;
            ObjResgate.cpf_funcionario = ObjFuncionario.cpf_funcionario;
            ObjResgate.data_ad_funcionario = ObjFuncionario.data_ad_funcionario;
            ObjResgate.situacao_funcionario = ObjFuncionario.situacao_funcionario;

            ObjBanco.SaveChanges();
        }

        public void ExcluirFuncionario(int codFuncionario)
        {
            banco ObjBanco = new banco();

            tb_funcionario ObjResgate = ObjBanco.tb_funcionario.Where(func => func.id_funcionario == codFuncionario).FirstOrDefault();

            ObjBanco.DeleteObject(ObjResgate);
            ObjBanco.SaveChanges();
        }

        public List<tb_funcionario> ConsultarFuncionario(int codLogado, string filtro, int cbIndex)
        {
            banco ObjBanco = new banco();

            List<tb_funcionario> lstFuncionario = new List<tb_funcionario>();

            if (filtro.Trim() == "")
            {
                lstFuncionario = ObjBanco.tb_funcionario.Where(funcionario => funcionario.id_usuario == codLogado).OrderBy(funcionario => funcionario.nome_funcionario).ToList();
            }
            else
            {
                if (cbIndex == 0)
                {
                    lstFuncionario = ObjBanco.tb_funcionario.Where(funcionario => funcionario.id_usuario == codLogado && funcionario.nome_funcionario.Contains(filtro)).OrderBy(funcionario => funcionario.nome_funcionario).ToList();
                }
                if (cbIndex == 1)
                {
                    lstFuncionario = ObjBanco.tb_funcionario.Where(funcionario => funcionario.id_usuario == codLogado && funcionario.endereco_funcionario.Contains(filtro)).OrderBy(funcionario => funcionario.nome_funcionario).ToList();
                }
                if (cbIndex == 2)
                {
                    lstFuncionario = ObjBanco.tb_funcionario.Where(funcionario => funcionario.id_usuario == codLogado && funcionario.cidade_funcionario.Contains(filtro)).OrderBy(funcionario => funcionario.nome_funcionario).ToList();
                }
                if (cbIndex == 3)
                {
                    lstFuncionario = ObjBanco.tb_funcionario.Where(funcionario => funcionario.id_usuario == codLogado && funcionario.celular_funcionario.Contains(filtro)).OrderBy(funcionario => funcionario.nome_funcionario).ToList();
                }
                if (cbIndex == 4)
                {
                    lstFuncionario = ObjBanco.tb_funcionario.Where(funcionario => funcionario.id_usuario == codLogado && funcionario.cpf_funcionario.Contains(filtro)).OrderBy(funcionario => funcionario.nome_funcionario).ToList();
                }
            }

            return lstFuncionario;
        }

        public List<tb_funcionario> FiltrarFuncionarioAtivo(int codLogado)
        {
            banco ObjBanco = new banco();

            List<tb_funcionario> lstFuncionario = new List<tb_funcionario>();
            lstFuncionario = ObjBanco.tb_funcionario.Where(funcionario => funcionario.id_usuario == codLogado && funcionario.situacao_funcionario == true).OrderBy(funcionario => funcionario.nome_funcionario).ToList();
            return lstFuncionario;
        }
    }
}
