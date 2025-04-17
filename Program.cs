using System;
using System.Collections.Generic;
using System.Data;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();
            List<Produto> lista = p.BuscaTodos();

            foreach (Produto produto in lista)
            {
                Console.WriteLine("ID: " + produto.id + " | Nome: " + produto.nome);
            }

        }
    }
}
