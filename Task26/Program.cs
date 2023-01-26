/*Задача 26: Напишите программу, которая:
1. принимает на вход число,
2. выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int countDigit = CountDigit(number);
Console.WriteLine($"Количество цифр в числе {number} => {countDigit}");

int CountDigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}


