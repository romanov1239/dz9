// Сумма элементов включительно в заданном интервале


using System;
using static System.Console;

Clear();
Write("Введите start: ");
int start = int.Parse(ReadLine());
Write("Введите end: ");
int end = int.Parse(ReadLine());

WriteLine(PrintNumbers(start, end));

int PrintNumbers(int start, int end)
{
   int sum=0;
    if (end >= start)
    {
       sum= PrintNumbers(start, end-1)+end;
    }
    return sum;
}
