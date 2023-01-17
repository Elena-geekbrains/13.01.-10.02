/*11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");

int newnumber = NewNumber(number);
Console.WriteLine($"Новое число: {newnumber}");

int NewNumber(int num)
{
    int firstNumber = number / 100;
    int secondNumber = number % 10;
    int result = firstNumber * 10 + secondNumber;
    return result;
}
