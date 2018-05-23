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

            Insertion(vetor);

            for (int a= 0; a < vetor.Length; a++) {
                Console.WriteLine(vetor[a]);
            }

            Console.ReadKey();
        }
        public static int[] Insertion(int[] vetor)
        {
            int i, j, atual;
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor;
        }

    }
}
