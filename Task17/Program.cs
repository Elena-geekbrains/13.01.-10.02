Console.WriteLine("Введите координаты точки:");
Console.Write("Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int quartet = Quarter(x, y);

string result = quartet > 0
              ? $"Указанные координаты соответствуют четверти: {quartet}"
              : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

