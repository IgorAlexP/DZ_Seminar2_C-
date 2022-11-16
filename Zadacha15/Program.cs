/* Задача 15: Напишите программу, котораяпринимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.*/
int cons1 = 0;
int cons2 = 6;
int cons3 = 5;
int cons4 = 8;
Console.WriteLine("ВВЕДИТЕ НОМЕР ДНЯ НЕДЕЛИ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > cons1 && number < cons2)
{
    Console.WriteLine("ЭТОТ ДЕНЬ НЕ ЯВЛЯЕТСЯ ВЫХОДНЫМ");
}
else if (number > cons3 && number < cons4)
{
    Console.WriteLine("ЭТОТ ДЕНЬ ЯВЛЯЕТСЯ ВЫХОДНЫМ");
}
else
{
    Console.WriteLine("ТАКОГО ДНЯ В НЕДЕЛЕ НЕТ");
}