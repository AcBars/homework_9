/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/
using static System.Console;

Clear();
Write("Введите значение M:");
int m=int.Parse(ReadLine());
Write("Введите значение N:");
int n=int.Parse(ReadLine());
WriteLine(Recursion(m, n));

int Recursion(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0 && m > 0) 
    {
        return recursion(m - 1, 1);
    }
    else 
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}
