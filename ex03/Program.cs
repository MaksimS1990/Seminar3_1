// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5,09;
// A(7,-5);B(1,-1) -> 7,21;

Console.WriteLine("Введите координаты точки A (x, y)");
int xa = int.Parse(Console.ReadLine()!);
int ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B (x, y)");
int xb = int.Parse(Console.ReadLine()!);
int yb = int.Parse(Console.ReadLine()!);

double Lenght(int xa, int ya, int xb, int yb)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((xa -xb), 2) + Math.Pow((ya - yb), 2));
    return result;
}
Console.WriteLine("Длина отрезка составляет: " + Lenght(xa, ya, xb, yb));