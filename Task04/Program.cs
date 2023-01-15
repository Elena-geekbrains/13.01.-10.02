// Задача 4
// Напишите программу, которая:
// 1. Принимает на вход три числа.
// 2. Выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третие число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"Максимальнле число из {number1}, {number2} и {number3} - это {max}.");