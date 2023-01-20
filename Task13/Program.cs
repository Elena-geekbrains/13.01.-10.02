/* Задача 13
Напишите программу, которая:
1. выводит третью цифру заданного числа
2. или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int ThirtDigit(int num)
{
    return num = num / 100 % 10;
}

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100) Console.WriteLine($"В введенном числе нет третьей цифры!");
else if (number < 1000) number = number % 10;
else number = ThirtDigit(number);
Console.WriteLine($"Третья цифра введенного числа => {number}");

/* Решение с использованием дополнительной переменной result:

int ThirtDigit(int num)
{
    return num = num / 100 % 10;
}

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100) Console.WriteLine($"В введенном числе нет третьей цифры!");
else if (number < 1000)
{
    int result = number % 10;
    Console.WriteLine($"Третья цифра введенного числа => {result}");
}

else
{
    int result = ThirtDigit(number);
    Console.WriteLine($"Третья цифра введенного числа => {result}");
}
*/
