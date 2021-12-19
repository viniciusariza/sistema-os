using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VendaVO
    {
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public string Operacao { get; set; }
        public decimal Total { get; set; }
        public int idVenda { get; set; }
    }
}
