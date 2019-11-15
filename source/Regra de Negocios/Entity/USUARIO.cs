using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regra_de_Negocios.Entity
{
    public class USUARIO
    {
        public int USUARIO_ID { get; set; }
        public string NOME_USUARIO { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public string EMAIL { get; set; }

    }
}
