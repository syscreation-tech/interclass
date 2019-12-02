using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entity
{
    public class Usuario
    {
        public int Usuario_Id { get; set; }
        public string Nome_Usuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

    }
    public class UsuarioCad
    {
        public int Usuario_Id { get; set; }
        public string Nome { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string End { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Dt { get; set; }
        public string Uf { get; set; }
        public int Npass { get; set; }
        public string Login { get; set; }

        public string Senha { get; set; }

    }
}
