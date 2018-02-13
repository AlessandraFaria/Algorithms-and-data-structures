using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            string palavra;

            Console.WriteLine("Escreva uma palavra");
            palavra = Console.ReadLine();

            Console.WriteLine("Escreva a letra que deseja busrcar na paravra "+palavra);
            letra = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("A letra foi encontrada ?  "+BuscaLetra(palavra,letra));

            Console.ReadKey();
        }

        public static bool BuscaLetra (string palavra, char letra) {
            char[] palavraBusca = new char[palavra.Length];
            bool resultado=false;
            
            for (int c =0; c<palavra.Length; c++) {
                palavraBusca[c] = Convert.ToChar(palavra[c]);
                if (palavraBusca[c] == letra) {
                    resultado= true;
                }
            }
            return resultado;

            
        }
    }
}
