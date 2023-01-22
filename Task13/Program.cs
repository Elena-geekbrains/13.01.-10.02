/* Задача 13в
Напишите программу, которая:
1. выводит третью цифру заданного числа
2. или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int NumberOfDigit(int num)
{
    int count;
    count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int numberOfDigit = NumberOfDigit(number);

if (numberOfDigit < 3) Console.WriteLine($"В введенном числе нет третьей цифры!");
else 
{
    number = number / (int)Math.Pow(10, numberOfDigit-3) % 10;
    Console.WriteLine($"Третья цифра введенного числа => {number}");
}