using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nu1 = 0, nu2 = 0;

            Console.WriteLine("Digite o Primeiro Número ");
            nu1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número ");
            nu2 = Convert.ToInt32(Console.ReadLine());
            if (nu2==0) {
                Console.WriteLine("Não é possivel realizar divisão por 0 ");
            }
            else {
                Console.WriteLine("Resultado  " + nu1 + " / " + nu2 + " = " + Divisao(nu1, nu2));
            }

            Console.ReadKey();
        }
        static public int Divisao(int n1, int n2)
        {
            int resultado = n1;

            if ((n1 == 0))
            {
                return 0;
            }
            else if (n1 == n2) {
                return 1;
            }
            else
            {
                while (resultado >= n2)
                {
                    resultado = resultado - n2;
                }

                return resultado;
            }
        }
        }
    }
