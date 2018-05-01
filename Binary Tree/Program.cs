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


        }

    }
    class Pessoa {
        public int idade;
        public string nome;
        public float peso;
        public char sexo;
    }
    class NoPessoa {
         public Pessoa dadosPessoa;
         public NoPessoa esquerda, direita;
    }
    class ABB
    {
        NoPessoa raiz;

        public bool Vazia(){
            if (raiz == null)
            {
                return true;
            }
            else return false;
        }
        public void inserir(Pessoa pessoaNova , NoPessoa raiz) {

            if (Vazia() == true)
            {
                raiz.dadosPessoa = pessoaNova;
            }
            else {
                if (pessoaNova.nome.CompareTo(raiz.dadosPessoa.nome) == 1)
                {//alterar a regra considerar como menor
                    if (raiz.esquerda == null)
                    {
                        raiz.esquerda.dadosPessoa = pessoaNova;
                    }
                    else
                    {
                        raiz = raiz.esquerda;
                        inserir(pessoaNova, raiz);
                    }
                }
                else {
                    if (raiz.direita == null)
                    {
                        raiz.direita.dadosPessoa = pessoaNova;
                    }
                    else
                    {
                        raiz = raiz.direita;
                        inserir(pessoaNova, raiz);
                    }
                }
            }
        }
        public bool ehfolha(NoPessoa nodo) {
            if ((nodo.esquerda == null) && (nodo.direita == null))
            {
                return true;
            }
            else { return false; }
        }

        public int PreOrdemQuantosHomens(NoPessoa raiz , int contador) {
            if (raiz !=null) {
                if (raiz.dadosPessoa.sexo=='m') {
                    contador++;
                }
                PreOrdemQuantosHomens(raiz.esquerda,contador);
                PreOrdemQuantosHomens(raiz.direita,contador);
            }
            return contador;
        }

        public void PreOrdemPesquisaPessoa(NoPessoa raiz, string nome)
        {
            if (raiz != null)
            {
                if (raiz.dadosPessoa.nome == nome)
                {
                    Console.WriteLine("Pessoa dados : idade =" + raiz.dadosPessoa.idade + " peso =" + raiz.dadosPessoa.peso);
                }
                else
                {
                    PreOrdemPesquisaPessoa(raiz.esquerda, nome);
                    PreOrdemPesquisaPessoa(raiz.direita, nome);
                }
            }
        }
    }
}
