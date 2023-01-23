/* 
1. принимает число (N)
2. выдает таблицу квадратов от 1 до N
5=> 1, 4, 9, 16, 25
2=> 1, 4
*/

Console.WriteLine("Введите число (N): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Ошибка ввода!");
else ResultTable(number);

void ResultTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5} {count * count,5}");
        count++;
    }
}
