using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_LAB_AED
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALESSANDRA FARIA ABREU
            int numero;
            int t = 2;
            int resultado = 0;
            Console.Clear();
            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());
            int[] parte1 = new int[numero / 2];
            int[] parte2 = new int[numero / 2];
            Console.WriteLine("------------------------------");
            //PREENCHE OS VETORES 
            for (int c = 1; c < (numero / 2); c++) {
                parte1[0] = 2;
                parte1[c] = parte1[c - 1] + 4;
                parte2[0] = 4;
                parte2[c] = parte2[c - 1] + 4;

            }
            if (numero%2==0) {
                TaylorPar(parte1,parte2,(numero/2),resultado);
            }
            else TaylorImpar(parte1, parte2, (numero / 2), resultado);
            Console.ReadKey();



        }

        static public int TaylorImpar(int[] pa1, int[] pa2, int n, int C){
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return 1 - TaylorImpar(pa1, pa2, (n - 1), (Soma((1 / Fatorial(pa1[n])), (1 / Fatorial(pa2[n])) - Soma((1 / Fatorial(pa1[n - 1])), (1 / Fatorial(pa2[n - 1]))))));
            }
        }
        static public int TaylorPar(int[] pa1, int[] pa2, int n, int C)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return 1 + TaylorPar(pa1, pa2, (n - 1), (Soma((1 / Fatorial(pa1[n])), (1 / Fatorial(pa2[n])) - Soma((1 / Fatorial(pa1[n - 1])), (1 / Fatorial(pa2[n - 1]))))));
            }
        }
        static public int Fatorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fatorial(n - 1);
        }

        static public int Soma(int valor1 ,int valor2 ) {

            return valor1 + valor2;
        }
    }
}
