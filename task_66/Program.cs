/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;

Clear();
Write("Введите значение M:");
int m=int.Parse(ReadLine());
Write("Введите значение N:");
int n=int.Parse(ReadLine());
if(n>=m)
{
    int count=n-m;
    int start=m;
    int end=n;
    WriteLine($"Сумма чисел от {start} до {end} равна: {FourierMultiplication(start, end, count)}");
}
else
{
    int count=m-n;
    int start=n;
    int end = m;
    WriteLine($"Сумма чисел от {start} до {end} равна: {FourierMultiplication(start, end, count)}");
}

int FourierMultiplication(int a, int b, int c)
{
    int temp;
    if(c>0)
    {
        b=b+a;
        a++;
        c--;
        return FourierMultiplication(a, b, c);
    }
    else return b;
}