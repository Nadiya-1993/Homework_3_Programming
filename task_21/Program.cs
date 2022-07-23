// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string сorName, string dotName)
{
    Console.Write($"Введите координату {сorName} точки {dotName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Dec (double x1, double x2, double y1, double y2, double z1, double z2 )
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

double segLenght = Math.Round(Dec(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Длина отрезка равна {segLenght}");
