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

            Console.WriteLine("Fim da escrita normal dos valores " + EscritaNormal(valores, n));
            Console.WriteLine("Fim da escrita invertida dos valores " + EscritaInvertida(valores, n));
            Console.WriteLine("Fim da escrita normal dos valores " + Soma(valores, n));

            Console.ReadKey();
        }
        public static void EscritaNormal(int[] valores, int n)
        {
            if (n>=0)
            {
                return EscritaNormal(valores, (n-1));               
                Console.WriteLine(valores[n]);
            }
           
        }
        public static void EscritaInvertida(int[] valores, int n)
        {

            if (n>=  0)
            {
                Console.WriteLine(valores[n]);
                return EscritaInvertida(valores, (n-1));
            }
           
        }
        public static int Soma(int[] valores, int n)
        {
            if(n>=0)
            {
                return valores[n] + Soma(valores, (n-1));
            }
            else return 0;
        }




    }
}

