using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] leitura = new string[3];
            string linha;
            int codigo;

            Produto[] Produtos = new Produto[20];
            int indice = 0;

            Console.WriteLine("Digite o nome do arquivo");
            StreamReader entrada = new StreamReader(Console.ReadLine());

            linha = entrada.ReadLine();
            int j = 0;
            while (linha != null)
            {

                leitura = linha.Split('-');
                Produtos[j] = new Produto();
                Produtos[j].nome = Convert.ToString(leitura[1]);
                Produtos[j].codigoDeBarras = Convert.ToInt32(leitura[0]);
                Produtos[j].precoUnitario = Convert.ToDouble(leitura[2]);
                linha = entrada.ReadLine();
                j++;

            }

            Console.WriteLine("Digite o código de barras do produto");
            codigo = Convert.ToInt32(Console.ReadLine());
            Produto resultado = BuscaProduto(Produtos, codigo, indice);
            Console.WriteLine("nome do Produto " + resultado.nome + " preço" + resultado.precoUnitario);
            Console.ReadKey();

        }

        public static Produto BuscaProduto(Produto[] produto, int codigo, int indice)
        {
            if (produto[indice].codigoDeBarras == codigo)
            {
                return produto[indice];
            }
            else
            {
                Console.WriteLine(indice);
                return BuscaProduto(produto, codigo, (indice + 1));
            }


        }

    }

    class Produto
    {

        public int codigoDeBarras;
        public double precoUnitario;
        public string nome;

        public Produto() { }
        public Produto(int codigoDeBarras, double precoUnitario, string nome)
        {
            this.nome = nome;
            this.precoUnitario = precoUnitario;
            this.codigoDeBarras = codigoDeBarras;
        }

    }

}
