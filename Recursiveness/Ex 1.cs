using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {//alessandra faria abreu
        static void Main(string[] args)
        {
            int a = 0, b= 0;
            Console.WriteLine("Digite o primeiro número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado  " + a + " X " + b + " = " + Multiplica(a, b));

            Console.ReadKey();


        }

        public static int Multiplica(int n1 , int n2) {
            if ((n2 == 0)||(n1==0))
            {
                return 0;
            }
            else {
                return n1 + Multiplica(n1,(n2-1));
            }
        }
    }
}
