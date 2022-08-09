// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
string str_number = number.ToString();
char digit = str_number[1];
string new_str_number = digit.ToString();
int new_number = Convert.ToInt32(new_str_number);
Console.WriteLine(new_number);