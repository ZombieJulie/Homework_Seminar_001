// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое натуральное число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Максимальное число = " + numberA);
}
if (numberB > numberA)
{
    Console.WriteLine("Максимальное число = " + numberB);
}
