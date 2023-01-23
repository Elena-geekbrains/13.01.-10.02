/* Задача 19
Напишите программу, которая:
1. принимает на вход пятизначное число,
2. проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Решение 1 - только для пятизначного числа
bool Palindrom(int num)
{
    return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10;
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10000 && number < 100000)
{
    bool result = Palindrom(number);
    Console.WriteLine(result ? "Число является палиндромом." : "Число не является палиндромом.");
}
else Console.WriteLine("Ошибка ввода!");

/* Решение 2 - для любрго натарального числа --------- еще требует доработки

int NumReverse(int num)
{
    int countDigit;
    countDigit = 0;
    while (num > 0)
    {
        num = num / 10;
        countDigit++;
    }
    int n = 0;
    int numReverse = 0;
    while (n < countDigit)
    {
        int temp = Convert.ToInt32(num / Math.Pow(10, n) % 10 * Math.Pow(10, countDigit - (n + 1)));
        n++;
        numReverse = numReverse + temp;
    }
    return numReverse;
}

    Console.WriteLine("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 10000 && number < 100000)
    {
        int newNumber = NumReverse(number);
        if (newNumber==number) Console.WriteLine($"Число {number} является палиндромом.");
        else Console.WriteLine($"Число {number} не является палиндромом.");
    }
    else Console.WriteLine("Ошибка ввода!");
*/

