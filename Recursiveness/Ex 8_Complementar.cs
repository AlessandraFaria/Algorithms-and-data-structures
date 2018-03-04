using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            Console.WriteLine("Digite o tamanho da sequencia");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("resultado");
            for (int c=0; c<=n; c++) {
              Console.Write(" "+Fibro(c + 1));
            }
            Console.ReadKey();
            
        }

        public static int Fibro(int n){
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else {

                return Fibro(n - 1) + Fibro(n - 2);

            }
            
         }

    }
}
