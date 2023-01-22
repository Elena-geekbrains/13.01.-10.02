/*Задача 15
Напишите программу, которая
1. принимает на вход цифру, обозначающую день недели,
2. проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

bool Weekend(int num)
{
    return num == 6 || num == 7;
}

Console.Write("Введите цифру от 1 до 7, обозначающую день недели (1-пн, 2-вт, 3-ср, 4-чт, 5-пт, 6-сб, 7-вс): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=1 && number<=7)
{
    bool result = Weekend(number);
    Console.WriteLine(result ? "Да, этот день является выходным" : "Нет, этот день не является выходным.");
}
else Console.WriteLine("Ошибка ввода");