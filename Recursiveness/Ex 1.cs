using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
class Program
{
static void Main(string[] args) //Alessandra Faria Abreu
{
int nu1 = 0 , nu2 = 0;

Console.WriteLine("Digite o Primeiro Número ");
nu1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Segundo Número ");
nu2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Resultado  "+nu1+" X "+nu2+" = "+ Multiplicacao(nu1,nu2));

Console.ReadKey();

}
static public int Multiplicacao(int n1 , int n2) {
    int resultado = 0;

    if ((n1 == 0) || (n2 == 0))
    {
        return 0;
    }
    else {

        for (int c = 0 ;c<n2;c++ ) {

            resultado += n1;
        }

        return resultado;
    }

}
}
}
