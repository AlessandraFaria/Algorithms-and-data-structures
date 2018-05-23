using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();          
            int[] vetor = new int[10];

            for (int c =0;c<vetor.Length; c++) {
                vetor[c]= random.Next(0, 30);
            }

            BubbleSort(vetor);

            for (int a= 0; a < vetor.Length; a++) {
                Console.WriteLine(vetor[a]);
            }

            Console.ReadKey();
        }
        public static int[] BubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparar = 0;
            int trocas = 0;

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
