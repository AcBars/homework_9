/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет произведение
натуральных чисел в промежутке от M до N.

M = 1; N = 5. ->120

M = 4; N = 6. -> 120
*/
using static System.Console;

Clear();
Write("Введите значение M: ");
int m=int.Parse(ReadLine());
Write("Введите значение N: ");
int n=int.Parse(ReadLine());
if(n>=m)
{
    int count=n-m;
    int start=m;
    int end=n;
    WriteLine($"Произведение чисел от {start} до {end} равна: {FourierMultiplication(start, end, count)}");
}
else
{
    int count=m-n;
    int start=n;
    int end = m;
    WriteLine($"Произведение чисел от {start} до {end} равна: {FourierMultiplication(start, end, count)}");
}

int FourierMultiplication(int a, int b, int c)
{
    int temp;
    if(c>0)
    {
        b=b*a;
        a++;
        c--;
        return FourierMultiplication(a, b, c);
    }
    else return b;
}