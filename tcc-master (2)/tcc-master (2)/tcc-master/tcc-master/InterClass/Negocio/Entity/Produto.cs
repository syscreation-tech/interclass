using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entity
{
    public class Produto
    {
        public long NumCartao { get; set; }
        public int CodCardSegu { get; set; }
         public string NomeProp { get; set; }
         public string DataValid { get; set; }
    }
}
