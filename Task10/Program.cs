/*Задача 10
Напишите программу, которая:
1. принимает на вход трёхзначное число;
2. на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
456 -> 5
782 -> 8
918 -> 1
*/


int SecondDigit(int num) // Метод определения вторрй цифры трёхзначного числа
{
    return num = num / 10 % 10;
}

Console.WriteLine("Введите трёхзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Модуль числа

if (number > 99 && number < 1000)
{
    int result = SecondDigit(number);
    Console.WriteLine($"Вторая цифра этого числа => {result}");
}
else Console.Write("Ошибка ввода!");