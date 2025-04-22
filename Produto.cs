using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace ConexaoBD

{
    class Produto
    {
        

        public int id { get; set; }
        public string nome { get; set; }
        public float preco {get; set;}
        public DateTime registro { get; set; }

        Conexao conexao { get; set; }   

        public Produto()
        {
            conexao = new Conexao();
        }

        public void Insere()
        {
            string query = $"INSERT INTO produto (nome, preco) VALUES ( '{nome}', {preco.ToString().Replace(",",".")} );" ;
            conexao.ExecutaComando(query);
            Console.WriteLine("Produto inserido com sucesso!");
        }

        public List<Produto> BuscaTodos()
        {
            DataTable dt = conexao.ExecutaSelect("SELECT * FROM produto;");

            List<Produto> lista = new List<Produto>(); 

            foreach (DataRow linha in dt.Rows)
            {
                Produto p = new Produto();

                p.id = int.Parse( linha["id"].ToString() );
                p.nome = linha["nome"].ToString();
                p.preco = float.Parse(linha["preco"].ToString());
                p.registro = DateTime.Parse(linha["registro"].ToString());

                lista.Add(p);
                
            }

            return lista;
        }



    }
}