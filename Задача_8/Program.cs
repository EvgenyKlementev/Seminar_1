﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8





Console.WriteLine("Enter N: ");


int N = int.Parse(Console.ReadLine());
int i = 1;
while(i<=N)
{
    if(i %2==0)
    {
      Console.Write($"{i}");
      i++;
    }
    
}

Console.WriteLine();