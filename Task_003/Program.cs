﻿// Программа,которая на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число `{number}` чётное");
}
else
{
    Console.WriteLine($"Число `{number}` нечётное");
}

