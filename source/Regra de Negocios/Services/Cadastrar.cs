using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using Regra_de_Negocios;
using Regra_de_Negocios.Entity;

namespace Gabriel_TCM
{
    public class Cadastrar
    {
        private DBSessao db;
        public void Insert(USUARIO usuario)
        {
            var query = "";
            query += "insert into USUARIO(NOME_USUARIO,LOGIN,SENHA,EMAIL)";
            query += string.Format("values ('{0}', '{1}', '{2}', '{3}');", usuario.NOME_USUARIO, usuario.LOGIN, usuario.SENHA, usuario.EMAIL);

            using (db = new DBSessao())
            {
                db.ExecutaComando(query);
            }
        }
        public void InsereDadosCartao(Produto produto)
        {
            var query = "";
            query += "insert into InfoCartao(NumCartao,CodCardSegu,NomeProp,DataValid)";
            query += string.Format("values('{0}', '{1}', '{2}', '{3}');", produto.NumCartao, produto.CodCardSegu, produto.NomeProp, produto.DataValid);

            using (db = new DBSessao())
            {
                db.ExecutaComando(query);
            }
        }
        public void InsereDadosParaAgendamento(Agendamento agendamento)
        {
            var query = "";
            query += "insert into Agendamento(Nome_usuario,EMAIL)";
            query += string.Format("values ('{0}', '{1}');", agendamento.Nome_Usuario, agendamento.EMAIL);

            using (db = new DBSessao())
            {
                db.ExecutaComando(query);
            }
        }

    }
}