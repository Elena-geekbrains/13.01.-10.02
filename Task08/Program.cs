// Задача 8
// Напишите программу, которая :
// 1. На вход принимает число (N).
// 2. На выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = 1;
    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{count} ");
        }
        count++;
    }
}
else
{
    Console.Write("Ошибка ввода!");
}