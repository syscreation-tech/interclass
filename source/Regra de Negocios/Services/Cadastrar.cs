using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using MySql.Data.MySqlClient;
using Regra_de_Negocios;
using Regra_de_Negocios.Entity;

namespace Gabriel_TCM
{
    public class Cadastrar
    {
        conexao con = new conexao();
        public void Insert(USUARIO usuario)
        {
            MySqlCommand cmd = new MySqlCommand("insert into USUARIO(NOME_USUARIO,LOGIN,SENHA,EMAIL values ('@Nome', '@Login', '@Senha', '@Email');",con.MyConectarBD());
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = usuario.NOME_USUARIO;
            cmd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = usuario.LOGIN;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = usuario.SENHA;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = usuario.EMAIL;

            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }
        public void InsereDadosCartao(Produto produto)
        {
            MySqlCommand cmd = new MySqlCommand("insert into InfoCartao(NumCartao,CodCardSegu,NomeProp,DataValid) values('@NumCartao', '@CodCardSegu', '@NomeProp', '@DataValid');",con.MyConectarBD());

            cmd.Parameters.Add("@NumCartao", MySqlDbType.VarChar).Value = produto.NumCartao;
            cmd.Parameters.Add("@CodCartao",MySqlDbType.Int16).Value = produto.CodCardSegu;
            cmd.Parameters.Add("@NomeProp",MySqlDbType.VarChar).Value = produto.NomeProp;
            cmd.Parameters.Add("@DataValid",MySqlDbType.VarChar).Value = produto.DataValid;

        }
        //public void InsereDadosParaAgendamento(Agendamento agendamento)
        //{
        //    MySqlCommand cmd = new MySqlCommand("insert into Agendamento(Nome_usuario,EMAIL) values ('@Nome_usuario', '{1}');");

        //    using (db = new DBSessao())
        //    {
        //        db.ExecutaComando(query);
        //    }
        //}

    }
}