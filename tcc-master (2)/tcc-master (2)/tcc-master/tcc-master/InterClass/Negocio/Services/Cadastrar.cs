using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using MySql.Data.MySqlClient;
using Negocio.DBSessao;
using Negocio.Entity;

namespace Negocio.Services
{
    public class Cadastrar
    {
        conexao con = new conexao();
        public void Insert(UsuarioCad usuariocad)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tb_cliente(nmclie,telclie,emailclie,endclie,cpfclie,rgclie,dtnasc,ufclie,npassporte,loginclie,senhaclie,tipousuario) values (@Nome, @Tel, @Email, @End, @Cpf, @Rg, @Dt, @Uf, @Npass, @Login, @Senha,'c');", con.MyConectarBD());

            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = usuariocad.Nome;
            cmd.Parameters.Add("@Tel", MySqlDbType.VarChar).Value = usuariocad.Tel;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = usuariocad.Email;
            cmd.Parameters.Add("@End", MySqlDbType.VarChar).Value = usuariocad.End;
            cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar).Value = usuariocad.Cpf;
            cmd.Parameters.Add("@Rg", MySqlDbType.VarChar).Value = usuariocad.Rg;
            cmd.Parameters.Add("@Dt", MySqlDbType.VarChar).Value = usuariocad.Dt;
            cmd.Parameters.Add("@Uf", MySqlDbType.VarChar).Value = usuariocad.Uf;
            cmd.Parameters.Add("@Npass", MySqlDbType.VarChar).Value = usuariocad.Npass;
            cmd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = usuariocad.Login;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = usuariocad.Senha;

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
        public void InserirAgendas(int id, string dt)
        {
            MySqlCommand cmd = new MySqlCommand("Insert into tb_agenda(data_age,hora,idpaccomprado) values ('" + dt + "',''," + id + ");", con.MyConectarBD());

            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }

    }
}