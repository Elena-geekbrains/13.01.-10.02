// Задача 2
// Напишите программу, которая:
// 1. На вход принимает два числа.
// 2. Выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Первое число ({number1}) больше второго числа ({number2}), а второе число ({number2}) в саою очередь меньше первого числа ({number1}).");
}
else 
{
    Console.WriteLine($"Первое число ({number1}) меньше второго числа ({number2}), а второе число ({number2}) в саою очередь больше первого числа ({number1}).");
}