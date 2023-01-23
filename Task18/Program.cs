Console.WriteLine("Введите номер четверти:");
string number = Console.ReadLine();
string result = Quarter(number);

Console.WriteLine(result);

/*string Quarter(string num)
{
    if (num=="1") return "x > 0 и y > 0";
    if (num=="2") return "x < 0 и y > 0";
    if (num=="3") return "x < 0 и y < 0";
    if (num=="4") return "x > 0 и y < 0";
    return "Введены некорректные данные!";
}
*/

string Quarter(string num)
{
    switch (num)
    {
        case "1": return "Допуситимые координаты: x > 0 и y > 0";
        case "2": return "Допуситимые координаты: x < 0 и y > 0";
        case "3": return "Допуситимые координаты: x < 0 и y < 0";
        case "4": return "Допуситимые координаты: x > 0 и y < 0";
        default: return "Введены некорректные данные!";
    }
}