/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_B = Convert.ToInt32(Console.ReadLine());
if (number_A > number_B)
{
    System.Console.WriteLine(number_A + " Первое число больше, " + "а второе меньше " + number_B);
}
else
{
    System.Console.WriteLine(number_B + "Второе число больше, " + "а первое меньше" + number_A);
}
