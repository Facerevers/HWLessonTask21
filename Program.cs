void ShowResult(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2);
    Console.WriteLine($"Расстояние между точками равно: {res}");
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = GetInput("Введите координату X первой точки: ");
int y1 = GetInput("Введите координату Y первой точки: ");
int z1 = GetInput("Введите координату Z первой точки: ");
int x2 = GetInput("Введите координату X второй точки: ");
int y2 = GetInput("Введите координату Y второй точки: ");
int z2 = GetInput("Введите координату Z второй точки: ");
ShowResult(x1, y1, z1, x2, y2, z2);