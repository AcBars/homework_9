/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет произведение
натуральных чисел в промежутке от M до N.

M = 1; N = 5. ->120

M = 4; N = 6. -> 120
*/
using static System.Console;

Clear();
Write("Введите значение м:");
int m=int.Parse(ReadLine());
Write("Введите значение n:");
int n=int.Parse(ReadLine());
if(n>=m)
{
    int count=n-m;
    int start=m;
    int end=n;
    WriteLine(FourierMultiplication(start, end, count));
}
else
{
    int count=m-n;
    int start=n;
    int end = m;
    WriteLine(FourierMultiplication(start, end, count));
}













int FourierMultiplication(int a, int b, int c)
{
    if(c>=0)
    {
        b=b*a;
        a++;
        
        return FourierMultiplication(a, b, c);
    }
    else return c;
}