// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
    Console.WriteLine("Nubmer Max = " + numberA); 
else if (numberB > numberC)
    Console.WriteLine("Number Max = " + numberB); 
else
    Console.WriteLine("Number Max = " + numberC); 