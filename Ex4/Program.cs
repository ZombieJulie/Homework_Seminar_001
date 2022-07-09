// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое натуральное число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье натуральное число: ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
    Console.WriteLine("Максимальное число = " + numberA); 
else if (numberB > numberC)
    Console.WriteLine("Максимальное число = " + numberB); 
else
    Console.WriteLine("Максимальное число = " + numberC); 