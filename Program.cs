/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Например:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
int Number = 0; // Решение1
int X = 1;
Console.Write("Enter the number:  ");
Number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 == int.Parse
Console.WriteLine("------------------------");
Console.WriteLine("all even numbers from 1 to " + Number + ":");
while (X <= Number)
{
    if (X % 2 == 0)
    {
    Console.Write (X +", ");
    }
    X++;
}
*/

int Number = 0; // Решение2 (альтернативное c for)
Console.Write("Enter the number:  ");
Number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 == int.Parse
Console.WriteLine("------------------------");
Console.WriteLine("all even numbers from 1 to " + Number + ":");
for (int i = 1; i <= Number; i++)
{
    if (i % 2 == 0)
    {
    Console.Write (i +", ");
    }
}

