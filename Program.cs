// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//     Урок 9. Как не нужно писать код. Часть 3 
//----------------------------------------------------
// Задача 64: Задайте значения M и N. Напишите программу, которая 
// выведет натуральные числа в промежутке от M до N.
//            1) M = 1; N = 5 -> 1, 2, 3, 4, 5
//            2) M = 4; N = 8 -> 4, 6, 7, 8

Console.WriteLine("Задача 64");
void outputNumbersMtoN (int m, int n)
{
    if (n > 0)
    {
        Console.Write(m + " ");
        m++;
        n--;
        outputNumbersMtoN(m, n);
    }
}

outputNumbersMtoN(1, 5);
Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдет сумму натуральных элементов в промежутке от M до N.
//            1) M = 1; N = 15 -> 120
//            2) M = 4; N = 8 -> 30

Console.WriteLine("Задача 66");
void sumNumbersMtoN (int m, int n, int sum)
{
    if (m > n)
    {
        Console.Write(sum + " ");
        return;
    }
    sum = sum + (m++);
    sumNumbersMtoN(m, n, sum);
}

sumNumbersMtoN(1, 15, 0);
Console.WriteLine();

sumNumbersMtoN(4, 8, 0);
Console.WriteLine();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m до n.
//            1) m = 2, n = 3 -> A(m,n) = 9
//A(0, n) = n + 1;
//A(m, 0) = A(m–1, 1); при m > 0;
//A(m, n) = A(m–1, A(m, n–1)); при m > 0 и n > 0.


Console.WriteLine("Задача 68");
int  functionAckerman (int m, int n)
{
  if (m == 0) return n + 1;
    else if (n == 0) return functionAckerman(m-1, 1);
        else return functionAckerman(m - 1, functionAckerman(m, n - 1));
}

int a;
a = functionAckerman(1,0);
Console.WriteLine(a);
Console.WriteLine(functionAckerman (2, 3));
