using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrdemServicoVO
    {
        public DateTime DataEntrada { get; set; }
        public string Cliente { get; set; }
        public string Equipamento { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Retorno { get; set; }
        public bool Finalizado { get; set; }
        public tb_os ObjOS { get; set; }
    }
}