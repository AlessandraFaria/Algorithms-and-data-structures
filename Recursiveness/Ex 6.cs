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
            Console.WriteLine("---Busca Binária---");
            Console.WriteLine("Digite o código de barras do produto");
            codigo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(OrdenacaoBubble(Produtos));

            Produto resultado = BuscaBinaria(Produtos,0,Produtos.Length,codigo);
            Console.WriteLine("nome do Produto " + resultado.nome + " preço" + resultado.precoUnitario);
            Console.ReadKey();
        }


        public static Produto[] OrdenacaoBubble(Produto[] produto)
        {
            int tamanho = produto.Length;
            int comparacoes = 0;
            int trocas = 0;
            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (produto[j].codigoDeBarras > produto[j + 1].codigoDeBarras)
                    {
                        int aux = produto[j].codigoDeBarras;
                        produto[j].codigoDeBarras = produto[j + 1].codigoDeBarras;
                        produto[j + 1].codigoDeBarras = aux;
                        trocas++;
                    }
                }
            }
            return produto;


        }

        public static Produto BuscaBinaria(Produto[] produto,int inicio, int fim , int pesquisa) {
            int i = (produto.Length / 2);

            if (produto[i].codigoDeBarras == pesquisa)
            {
                return produto[i];

            }
            else if (inicio == fim)
            {
                return produto[0];
            }
            else {
                if (produto[i].codigoDeBarras < pesquisa)
                {
                    return BuscaBinaria(produto, (i + 1), fim, pesquisa);
                }
                else {
                    return BuscaBinaria(produto, inicio, (i+1), pesquisa);
                }
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

