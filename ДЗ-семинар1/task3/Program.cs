﻿/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 1)
{
    System.Console.WriteLine("Число " + num + "    является: нечетным");
}
else
{
System.Console.WriteLine("Число " + num +   "    является: четным");
}
