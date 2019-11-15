using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Regra_de_Negocios.Entity;

namespace Regra_de_Negocios.Services
{
    public class List
    {
        conexao con = new conexao();
        public List<Seguros>ListarSeguros(Seguros seguros)
        {
            List<Seguros> seg = new List<Seguros>();
            MySqlCommand cmd = new MySqlCommand("select * from tb_seguros", con.MyConectarBD());
            MySqlDataReader leitor;
            leitor = cmd.ExecuteReader();
            while (leitor.Read())
                {
                    seg.Add(new Seguros
                    {
                        idseg = int.Parse(leitor["idseg"].ToString()),
                        tiposeg = leitor["tiposeg"].ToString(),
                        valorseg = decimal.Parse(leitor["valorseg"].ToString())
                    });
                }
                leitor.Close();
                return seg;
            
        }

        public List<Pacotes> ListarPacotes(Pacotes pacotes)
        {
            List<Pacotes> pac = new List<Pacotes>();
            MySqlCommand cmd = new MySqlCommand("select * from tb_pacotes", con.MyConectarBD());
            MySqlDataReader leitor;
            leitor = cmd.ExecuteReader();

            while (leitor.Read())
                {
                    pac.Add( new Pacotes
                    {
                        idpac = int.Parse(leitor["idpac"].ToString()),
                        tipopac = leitor["tipopac"].ToString(),
                        valor = leitor["valorpac"].ToString(),
                        destino = leitor["destinopac"].ToString()
                    });
                   
                }
                leitor.Close();


                return pac;
        }
        //public List<Pacotes> ListaDePacotes(MySqlDataReader retorno)
        //{
        //    var pac = new List<Pacotes>();
        //    while (retorno.Read())
        //    {
        //        var TempUsuario = new Pacotes()
        //        {
        //            idpac = int.Parse(retorno["idpac"].ToString()),
        //            tipopac = retorno["tipopac"].ToString(),
        //            valor = decimal.Parse(retorno["valorpac"].ToString()),
        //            destino = retorno["destinopac"].ToString()
        //        };
        //        pac.Add(TempUsuario);
        //    }
        //    retorno.Close();
        //    return pac;
        //}
        //public List<USUARIO>Listar(USUARIO usuario)
        //{
        //    using (db = new DBSessao())
        //    {
        //        var query = "Select * from USUARIO;";
        //        var Retorno = db.RetornaComando(query);
        //        return ListaDeUsuario(Retorno);
        //    }
        //}
        //public List<USUARIO> ListaDeUsuario(MySqlDataReader Retorno)
        //{
        //    var usuarios = new List<USUARIO>();
        //    while (Retorno.Read())
        //    {
        //        var TempUsuario = new USUARIO()
        //        {
        //            USUARIO_ID = int.Parse(Retorno["USUARIO_ID"].ToString()),
        //            NOME_USUARIO = Retorno["NOME_USUARIO"].ToString(),
        //            LOGIN = Retorno["LOGIN"].ToString(),
        //            SENHA = Retorno["SENHA"].ToString(),
        //            EMAIL = Retorno["EMAIL"].ToString()
        //        };
        //        usuarios.Add(TempUsuario);
        //    }
        //    Retorno.Close();
        //    return usuarios;

        //}
        //public List<Produto> ListarProd(Produto produto)
        //{
        //    using(db = new DBSessao())
        //    {
        //        var query = "Select * from InfoCartao;";
        //        var Retorno = db.RetornaComando(query);
        //        return ListaProdutos(Retorno);
        //    }
        //}

        //public List<Produto> ListaProdutos(MySqlDataReader Retorno)
        //{
        //    var produto = new List<Produto>();
        //    while (Retorno.Read())
        //    {
        //        var TempUsuario = new Produto()
        //        {
        //            NumCartao = long.Parse(Retorno["NumCartao"].ToString()),
        //            CodCardSegu = int.Parse(Retorno["CodCardSegu"].ToString()),
        //            NomeProp = Retorno["NomeProp"].ToString(),
        //            DataValid = Retorno["DataValid"].ToString(),
        //        };
        //        produto.Add(TempUsuario);
        //    }
        //    Retorno.Close();
        //    return produto;

        //}
        //public void Deletar (USUARIO usuario)
        //{
        //     var query = string.Format("delete from USUARIO where USUARIO_ID = {0}", usuario.USUARIO_ID);
            

        //    using (db  =  new DBSessao())
        //    {
        //        db.ExecutaComando(query);
        //    }
        //}
        //public void Alterar(USUARIO usuario)
        //{
        //    var query = "";
        //    query += "UPDATE USUARIO SET ";
        //    query += string.Format(" NOME_USUARIO = '{0}', ", usuario.NOME_USUARIO);
        //    query += string.Format(" LOGIN = '{0}', ", usuario.LOGIN);
        //    query += string.Format(" SENHA = '{0}',", usuario.SENHA);
        //    query += string.Format(" EMAIL = '{0}' ", usuario.EMAIL);
        //    query += string.Format(" WHERE USUARIO_ID = '{0}' ", usuario.USUARIO_ID);

        //    using (db = new DBSessao())
        //    {
        //        db.ExecutaComando(query);
        //    }

        //}

    }
}
