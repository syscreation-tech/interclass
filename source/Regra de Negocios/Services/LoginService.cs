using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regra_de_Negocios.Entity;
using MySql.Data.MySqlClient;
namespace Regra_de_Negocios.Services
{
    public class LoginService
    {
        DBSessao con = new DBSessao();
        public bool validarUsuairo(string login, string senha)
        {
            StringBuilder query = new StringBuilder();
            var session = new DBSessao();
            
            query.Append(" SELECT U.LOGIN,");
            query.Append("        U.SENHA");
            query.Append(" FROM USUARIO U");
            query.Append(" WHERE (1=1)");
            query.AppendFormat(" AND U.LOGIN = '{0}'",login);
            query.AppendFormat(" AND U.SENHA = '{0}'",senha);
            Query executar = session.CreateQuery(query.ToString());
            IDataReader reader = executar.ExecuteQuery();

            using (reader)
            {
                if (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["LOGIN"].ToString()))
                        return true;
                }
                return false;
            }
        }
        public static string mail;

        public void TestarUsuario(Login user)
        {
            MySqlCommand cmd = new MySqlCommand("select * from usuario where login = @usuario and senha = @Senha ", con.MyConectarBD());

            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.usuario;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = user.Senha;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = user.tipo;
            MySqlDataReader leitor;

            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {

                    {
                        user.usuario = Convert.ToString(leitor["login"]);
                        user.Senha = Convert.ToString(leitor["Senha"]);
                        user.tipo = Convert.ToString(leitor["tipo"]);
                    }
                }

            }

            else
            {
                user.usuario = null;
                user.Senha = null;
                user.tipo = null;
            }

            con.MyDesconectarBD();
        }
        //public void testaSession()
        //{
        //    if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

        //    {
        //        return RedirectToAction("semAcesso", "Home");
        //    }
        //    else
        //    {
        //        ViewBag.teste = Session["tipoLogado"];

        //        return View();
        //    }
        //}

    }
}
