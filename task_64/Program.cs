/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.

M = 1; N = 5. ->120

M = 4; N = 6. -> 120
*/
using static System.Console;

Clear();
Write("Введите значение м:");
int m=int.Parse(ReadLine());
Write("Введите значение N:");
int n=int.Parse(ReadLine());
WriteLine(FourierMultiplication(m,n));














int FourierMultiplication(int a, int b)
{
    int result=b;
    if(b>=a)
    {
        b--;
        result*=FourierMultiplication(result, b);
        
        return result;
    }
    else return result; 
}