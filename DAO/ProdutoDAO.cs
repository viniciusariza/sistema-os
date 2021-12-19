using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProdutoDAO
    {
        public void InserirProduto(tb_produto ObjProduto)
        {
            banco ObjBanco = new banco();
            ObjBanco.AddTotb_produto(ObjProduto);
            ObjBanco.SaveChanges();
        }

        public void AlterarProduto(tb_produto ObjProduto)
        {
            banco ObjBanco = new banco();
            tb_produto ObjResgate = ObjBanco.tb_produto.Where(prod => prod.id_produto == ObjProduto.id_produto).FirstOrDefault();

            ObjResgate.nome_produto = ObjProduto.nome_produto;
            ObjResgate.marca_produto = ObjProduto.marca_produto;
            ObjResgate.categoria_produto = ObjProduto.categoria_produto;
            ObjResgate.id_fornecedor = ObjProduto.id_fornecedor;
            ObjResgate.custo_produto = ObjProduto.custo_produto;
            ObjResgate.venda_produto = ObjProduto.venda_produto;
            ObjResgate.estoque_produto = ObjProduto.estoque_produto;

            ObjBanco.SaveChanges();
        }

        public void ExcluirProduto(int codProduto)
        {
            banco ObjBanco = new banco();
            tb_produto ObjResgate = ObjBanco.tb_produto.Where(prod => prod.id_produto == codProduto).FirstOrDefault();

            ObjBanco.DeleteObject(ObjResgate);
            ObjBanco.SaveChanges();
        }
        
        public decimal ConsultarPrecoProduto(int idProduto)
        {
            banco objBanco = new banco();
            decimal preco = objBanco.tb_produto.Where(p => p.id_produto == idProduto).FirstOrDefault().venda_produto;
            return preco;
        }

        public void DiminuirQtdProduto(int codProduto, int qtdVendida)
        {
            banco ObjBanco = new banco();
            tb_produto ObjProduto = ObjBanco.tb_produto.Where(p => p.id_produto == codProduto).FirstOrDefault();
            ObjProduto.estoque_produto -= qtdVendida;
            ObjBanco.SaveChanges();

        }

        public void AumentarQtdProduto(int codProduto, int qtdRetorno)
        {
            banco ObjBanco = new banco();
            tb_produto ObjProduto = ObjBanco.tb_produto.Where(p => p.id_produto == codProduto).FirstOrDefault();
            ObjProduto.estoque_produto += qtdRetorno;
            ObjBanco.SaveChanges();
        }

        public int ConsultarQtdProduto(int codProduto)
        {
            banco ObjBanco = new banco();
            tb_produto ObjProduto = ObjBanco.tb_produto.Where(p => p.id_produto == codProduto).FirstOrDefault();
            return ObjProduto.estoque_produto;
        }

        public List<tb_produto> ConsultarProduto(int codLogado, string filtro, int indexCombo)
        {
            banco ObjBanco = new banco();
            List<tb_produto> lstProduto = new List<tb_produto>();

            if (filtro.Trim() == "")
            {
                lstProduto = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado).OrderBy(prod => prod.nome_produto).ToList();
            }
            else
            {
                if (indexCombo == 0)
                {
                    lstProduto = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado && prod.nome_produto.Contains(filtro)).OrderBy(prod => prod.nome_produto).ToList();
                }
                if (indexCombo == 1)
                {
                    lstProduto = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado && prod.marca_produto.Contains(filtro)).OrderBy(prod => prod.nome_produto).ToList();
                }
                if (indexCombo == 2)
                {
                    lstProduto = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado && prod.categoria_produto.Contains(filtro)).OrderBy(prod => prod.nome_produto).ToList();
                }
                if (indexCombo == 3)
                {
                    lstProduto = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado && prod.tb_fornecedor.nome_fornecedor.Contains(filtro)).OrderBy(prod => prod.nome_produto).ToList();
                }
            }
            return lstProduto;
        }

        public List<ProdutoVO> ConsultarProdutoEditado(int codLogado, string filtro, int indexCombo)
        {
            banco ObjBanco = new banco();
            List<tb_produto> lstConsulta = new List<tb_produto>();
            List<ProdutoVO> lstRetorno = new List<ProdutoVO>();

            if (filtro.Trim() == "")
            {
                lstConsulta = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado).ToList();
            }
            else
            {
                if (indexCombo == 0)
                {
                    lstConsulta = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado && prod.nome_produto.Contains(filtro)).OrderBy(prod => prod.nome_produto).ToList();
                }
                if (indexCombo == 1)
                {
                    lstConsulta = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado && prod.marca_produto.Contains(filtro)).OrderBy(prod => prod.nome_produto).ToList();
                }
                if (indexCombo == 2)
                {
                    lstConsulta = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado && prod.categoria_produto.Contains(filtro)).OrderBy(prod => prod.nome_produto).ToList();
                }
                if (indexCombo == 3)
                {
                    lstConsulta = ObjBanco.tb_produto.Where(prod => prod.id_usuario == codLogado && prod.tb_fornecedor.nome_fornecedor.Contains(filtro)).OrderBy(prod => prod.nome_produto).ToList();
                }
            }


            for (int i = 0; i < lstConsulta.Count; i++)
            {
                ProdutoVO vo = new ProdutoVO();

                vo.Produto = lstConsulta[i].nome_produto;
                vo.Marca = lstConsulta[i].marca_produto;
                vo.PrecoDeVenda = lstConsulta[i].venda_produto;
                vo.Estoque = lstConsulta[i].estoque_produto;
                vo.ObjProduto = lstConsulta[i];

                lstRetorno.Add(vo);
            }

            return lstRetorno.OrderBy(prod => prod.Produto).ToList();
        }
    }
}
