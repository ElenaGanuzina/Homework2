// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = Math.Abs(number);
if(number1 < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    string str_number = number1.ToString();
    char digit = str_number[2];
    string new_str_number = digit.ToString();
    int new_number = Convert.ToInt32(new_str_number);
    Console.WriteLine(new_number);  
}

