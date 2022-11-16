/*Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.*/
Console.Write("Введите любое трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int cons = 10;
    int a = 0;
    int b = 0;
    int cons1 = 99;
    int cons2 = 1000;
if (number > cons1 & number < cons2)
{
    a = number / cons;
    b = a % cons;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Число не является трехзначным!");
}