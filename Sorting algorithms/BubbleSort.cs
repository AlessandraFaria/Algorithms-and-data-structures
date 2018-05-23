using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static int comparar;
        public static int trocas;
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] vetor = new int[30];
            

            for (int c = 0; c < vetor.Length; c++)
            {
                vetor[c] = random.Next(0, 1000);
            }

            for (int a = 0; a < vetor.Length; a++)
            {
                Console.Write(vetor[a] + "-");
            }

            BubbleSort(vetor);
            Console.Write("\n Trocas = " + trocas);
            Console.Write("\n Comparações = " + comparar);
            Console.Write("\n Vetor Ordenado \n");
          
            for (var a = 0; a < vetor.Length; a++)
            {
                Console.Write(vetor[a]+"-");
            }

            Console.ReadKey();
        }
        public static int[] BubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
           
            comparar = 0;
            trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparar++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }
           

            return vetor;
        }


    }
}
