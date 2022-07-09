// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
if (numberA % 2 == 1)
{
    Console.WriteLine("Число не четное");
}
else
{
    Console.WriteLine("Число четное");
}