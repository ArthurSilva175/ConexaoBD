using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ConexaoTeste
{
    class Conexao 
    {
        string dadosConexao = "server=localhost;user=root;database=teste_ti42;port=3306;passsword=";

        public int ExecutaComando( string query )
        {
            // Cria e abre conexão com o banco
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();

            //Rodar o query dentro do banco
            MySqlCommand comando = new MySqlCommand(query, conexao);
            int linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas;

        }


        public DataTable ExecutaSelect(string query)
        {
            // Cria e abre conexão com o banco
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();

            //Rodar o query dentro do banco
            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            dados.Fill(dt);
            conexao.Close();
            return dt;

        }


    }
}