- [Tradução PT-BR](https://github.com/AlessandraFaria/Algorithms-and-data-structures/blob/master/Recursiveness/Tradu%C3%A7%C3%A3o.md)

### Ex 1:
A C # program that reads two integer values ​​and prints the result of the multiplication
from each other. The multiplication must be done by means of successive recursive sums. Per
example: 2 x 3 = (2 + 2 + 2) = 6.

### Ex 2:
A C # program that reads two integer values; calculate, by means of a
recursive, the entire division between them; and print the result. The division must be done by means of
recursive successive subtractions. The whole division disregards the decimal part of the result, for
example: 5/2 = 2 and 15/4 = 3.

### Ex 3:
An S string and a C character write a recursive algorithm that responds true or
false to the question: does the character C exist in the string S?
Tip: To observe the characters of a string, we can consider it as a vector. Per
for example, if S = "PUC Mines", S [0] is P, S [1] is U, S [2] is C and so on.

### Ex 4:
A recursive function in C # to solve each of the problems described
below. Its functions should be given as parameters an integer vector A and the quantity n of
elements currently stored in the vector:
a) to print the elements of vector A in the order in which they are stored, ie:
A [0], A [1], ..., A [n];
b) print the elements of vector A in an order opposite to the one in which they are
stored, that is: A [n], A [n-1], ..., A [1], A [0];
c) calculate the sum of the value of all elements stored in vector A.

### Ex 5:
Consider a supermarket and the list of products it commercializes. A client of this
The supermarket can, through electronic terminals scattered throughout the establishment, consult the
unit price of a product by informing the bar code of that product.
Consider that, on each product, the following information is stored: bar code,
name and unit price.
Implement, in C #, a Product class with the attributes
Unit price. These attributes must be of the following types, respectively: int, String, and
double
Make a program, in C #, that reads, from an input text file, the list of products
marketed by the supermarket and store them in a vector. Assume that this
entry contains the following data on each line: the bar code of the product; the name of
product; and the unit price of that product. These data are separated in each row by the
character '-'. Subsequently, this program should allow the user to enter the
of the product searched and return the name and unit price of that product, thereby simulating
the queries that the supermarket's customers make in the electronic terminals scattered throughout the
establishment. Implement the desired product search in the product vector through
recursive sequential search. Have your program print the total amount of
comparative steps necessary to recover the desired product.

### Ex 6:
Implement the same search procedure for the previous exercise using, in this case,
recursive binary search. Indicate at the end the total number of comparison operations
necessary to recover the desired product.
Remember that for binary search, the vector must be ordered. To do this, make a
procedure to always insert products into the vector in ascending order of bar code,
so that this vector of products is always ordered.
Compare and discuss the results obtained in sequential research and binary search.

# 7 # Ex 7:
A C # program that calculates a cosine approximation of 1 (a) radian through the
infinite series below:

C = 1 - 1/2! + 1/4! - 1/6! + 1/10! ....

This program should receive as input the number of terms, n, of the infinite series above, which
must be considered for the calculation of C. The calculation of the value of C, obtained by the infinite series
above, should be performed considering only its first n terms and using a
recursive function. At the end, the program should print the result found for C.
