using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int controle = 0;

            Console.WriteLine("Digite o número de elementos do vetor");
            n = Convert.ToInt32(Console.ReadLine());

            int[] valores = new int[n];
            for (int c = 0; c < n; c++)
            {
                Console.WriteLine("Digite um número para ser armazenado no Vetor ");
                valores[c] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Fim da escrita normal dos valores " + EscritaNormal(valores, n, controle));
            Console.WriteLine("Fim da escrita invertida dos valores " + EscritaInvertida(valores, n, ((controle = n) - 1)));
            Console.WriteLine("Fim da escrita normal dos valores " + Soma(valores, (n - 1), (controle = 0)));

            Console.ReadKey();
        }
        public static int EscritaNormal(int[] valores, int n, int controle)
        {
            if (controle == n)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(valores[controle]);
                return EscritaNormal(valores, n, (controle + 1));
            }
        }
        public static int EscritaInvertida(int[] valores, int n, int controle)
        {

            if (controle < 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(valores[controle]);
                return EscritaInvertida(valores, n, (controle - 1));
            }
        }
        public static int Soma(int[] valores, int n, int controle)
        {
            int soma = 0;
            if (controle == n)
            {
                return 0;
            }
            else
            {
                return valores[n] + Soma(valores, n, (controle + 1));
            }
        }




    }
}

