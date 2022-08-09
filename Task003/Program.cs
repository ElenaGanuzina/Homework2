// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int number = new Random().Next(1, 8);
Console.WriteLine(number);
if(number == 6 || number == 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Рабочий");