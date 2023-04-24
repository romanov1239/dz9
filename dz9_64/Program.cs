// Вывести натуральные числа от N до 1

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int m=int.Parse(ReadLine());

WriteLine();
WriteLine(PrintNumbers(m));

string PrintNumbers(int n)
{
    
    if (n == 1)
    { 
        return "1";
    }
    string s =  n.ToString()+ " " + PrintNumbers(n-1);
   
    return s;
}

