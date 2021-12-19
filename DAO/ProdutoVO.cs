using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProdutoVO
    {
        public string Produto { get; set; }
        public string Marca { get; set; }
        public decimal PrecoDeVenda { get; set; }
        public int Estoque { get; set; }
        public tb_produto ObjProduto { get; set; }
    }
}
