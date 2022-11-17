/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99)
{
    int digit = SecondDigit(number);
    System.Console.WriteLine($"{number} -> {digit}");
}

else System.Console.WriteLine($"{number} -> третьей цифры нет");


static int SecondDigit(int n) 
{
    while (n >= 1000) 
    n /= 10;
    int a = n % 10;
    return a;
}