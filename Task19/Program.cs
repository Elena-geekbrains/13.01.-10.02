/* Задача 19
Напишите программу, которая:
1. принимает на вход пятизначное число,
2. проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number < 100000)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
        Console.WriteLine($"Число {number} является палиндром.");
    else Console.WriteLine($"Число {number} не является палиндром.");
}
else Console.WriteLine("Ошибка ввода!");