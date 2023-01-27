/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int factorial = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} => {factorial}.");
}
else Console.WriteLine("Ошибка ввода!");

int Factorial(int num)
{
    int product = 1;
    for (int count = 1; count <= num; count++)
    {
        product *= count; 
        //product=product*count;
    }
    return product;
}
