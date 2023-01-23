/* Задача 23
Напишите программу, которая:
1. принимает на вход число (N);
2. выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число (N): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Ошибка ввода!");
else CubeTable(number);

void CubeTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,6} {Math.Pow(count, 3),6}");
        count++;
    }
}