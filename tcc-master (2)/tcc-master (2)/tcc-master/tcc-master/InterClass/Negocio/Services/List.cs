using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Negocio.DBSessao;
using Negocio.Entity;

namespace Negocio.Services
{
    public class List
    {
        conexao con = new conexao();
        public List<Seguros> ListarSeguros(Seguros seguros)
        {
            List<Seguros> seg = new List<Seguros>();
            MySqlCommand cmd = new MySqlCommand("select * from tb_seguros", con.MyConectarBD());
            MySqlDataReader leitor;
            leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                seg.Add(new Seguros
                {
                    Idseg = int.Parse(leitor["idseg"].ToString()),
                    Tiposeg = leitor["tiposeg"].ToString(),
                    Valorseg = decimal.Parse(leitor["valorseg"].ToString())
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
                pac.Add(new Pacotes
                {
                    Idpac = int.Parse(leitor["idpac"].ToString()),
                    Tipopac = leitor["tipopac"].ToString(),
                    Valor = leitor["valorpac"].ToString(),
                    Destino = leitor["destinopac"].ToString()
                });

            }
            leitor.Close();

            return pac;
        }
        public List<Pacotes> ListarPacotesById(string identlocal)
        {
            List<Pacotes> pac = new List<Pacotes>();
            Pacotes pacotes = new Pacotes();
            MySqlCommand cmd = new MySqlCommand("select * from tb_pacotes where idpac = @id", con.MyConectarBD());

            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = identlocal;
            MySqlDataReader leitor;
            leitor = cmd.ExecuteReader();
            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    pac.Add(new Pacotes
                    {
                    Idpac = Convert.ToInt32(leitor["Idpac"]),
                    Destino = Convert.ToString(leitor["destinopac"]),
                    Tipopac = Convert.ToString(leitor["tipopac"]),
                    Valor = Convert.ToString(leitor["valorpac"])
                    });
                }
            }
            leitor.Close();
            return pac;
        }

    }
}
