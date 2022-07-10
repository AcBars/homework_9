/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;

Clear();
Write("Введите значение м:");
int m=int.Parse(ReadLine());
Write("Введите значение N:");
int n=int.Parse(ReadLine());
WriteLine(FourierMultiplication(m,n));



int SumNumbers (int m, int n)
{
    int count=n>=m? count=n-m
}