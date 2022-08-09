Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = Math.Abs(number);
if(number1 < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (number1 >= 1000) number1 /= 10;
    int result = number1 % 10;
    Console.WriteLine(result);
}
