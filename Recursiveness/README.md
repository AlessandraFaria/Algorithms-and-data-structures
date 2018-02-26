### Ex 1 :
Um programa em C# que leia dois valores inteiros e imprima o resultado da multiplicação
de um pelo outro. A multiplicação deve ser feita por meio de somas sucessivas recursivas. Por
exemplo: 2 x 3 = (2+2+2) = 6.

### Ex 2 :
Um programa em C# que leia dois valores inteiros; calcule, através de uma função
recursiva, a divisão inteira entre eles; e imprima o resultado. A divisão deve ser feita por meio de
subtrações sucessivas recursivas. A divisão inteira despreza a parte decimal do resultado, por
exemplo: 5 / 2 = 2 e 15 / 4 = 3.

### Ex 3 :
Uma string S e um caractere C, escreva um algoritmo recursivo que responda verdadeiro ou
falso para a questão: o caractere C existe na string S?
Dica: para observar os caracteres de uma string, podemos considerá-la como um vetor. Por
exemplo, se S=”PUC Minas”, S[0] é P, S[1] é U, S[2] é C e assim por diante.

### Ex 4 :
Uma função recursiva em C# para solucionar cada um dos problemas descritos
abaixo. Suas funções devem receber como parâmetros um vetor A de inteiros e a quantidade n de
elementos armazenados atualmente no vetor:
a) imprimir os elementos do vetor A na ordem em que se encontram armazenados, isto é:
A[0], A[1], ... , A[n];
b) imprimir os elementos do vetor A em ordem contrária àquela em que se encontram
armazenados, isto é: A[n], A[n-1], ..., A[1], A[0];
c) calcular o somatório do valor de todos os elementos armazenados no vetor A.

### Ex 5 :
Considere um supermercado e a lista de produtos por ele comercializados. Um cliente desse
supermercado pode, através de terminais eletrônicos espalhados no estabelecimento, consultar o
preço unitário de um produto informando, para isso, o código de barras desse produto.
Considere que, sobre cada produto, são armazenadas as seguintes informações: código de barras,
nome e preço unitário.
Implemente, em C#, uma classe Produto com os atributos codigoBarras, nome e
precoUnitario. Esses atributos devem ser dos seguintes tipos, respectivamente: int, String e
double.
Faça um programa, em C#, que leia, de um arquivo texto de entrada, a lista de produtos
comercializados pelo supermercado e armazene-os em um vetor. Assuma que esse arquivo de
entrada contém, em cada linha, os seguintes dados: o código de barras do produto; o nome do
produto; e o preço unitário desse produto. Esses dados estão separados, em cada linha, pelo
caracter ‘-’. Posteriormente, esse programa deve permitir que o usuário informe o código de
barras do produto pesquisado e retornar o nome e preço unitário desse produto, simulando assim
as consultas que os clientes do supermercado realizam nos terminais eletrônicos espalhados pelo
estabelecimento. Implemente a busca do produto desejado no vetor de produtos através de
pesquisa sequencial recursiva. Faça com que seu programa imprima a quantidade total de
operações de comparação necessárias para recuperar o produto desejado.

### Ex 6 :
Implemente o mesmo procedimento de busca do exercício anterior utilizando, nesse caso,
pesquisa binária recursiva. Indique ao final a quantidade total de operações de comparação
necessárias para recuperar o produto desejado.
Lembre-se que, para a pesquisa binária, o vetor deve estar ordenado. Para isso, faça um
procedimento para sempre inserir produtos no vetor em ordem ascendente de código de barras,
para que esse vetor de produtos sempre fique ordenado.
Compare e discuta os resultados obtidos na pesquisa sequencial e na pesquisa binária.

### Ex 7 :
Um programa em C# que calcule uma aproximação do coseno de 1 (um) radiano através da
série infinita abaixo:

C = 1 - 1/2! + 1/4! - 1/6! + 1/10! ....

Esse programa deve receber como entrada o número de termos, n, da série infinita acima, que
devem ser considerados para o cálculo de C. O cálculo do valor de C, obtido pela série infinita
acima, deve ser realizado considerando apenas seus n primeiros termos e utilizando-se uma
função recursiva. Ao final, o programa deve imprimir o resultado encontrado para C.
