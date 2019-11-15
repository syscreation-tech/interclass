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
        conexao con = new conexao();

        public static string mail;

        public void TestarUsuario(Login user)
        {
            MySqlCommand cmd = new MySqlCommand("select * from tb_login where usuario = @usuario and senha = @Senha ", con.MyConectarBD());

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
                        user.usuario = Convert.ToString(leitor["usuario"]);
                        user.Senha = Convert.ToString(leitor["Senha"]);
                        user.tipo = Convert.ToString(leitor["tipousuario"]);
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
