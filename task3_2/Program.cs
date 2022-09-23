/*Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве.*/
Console.WriteLine("Введите координаты точки A:");
Console.WriteLine("x1:");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("y1:");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("z1:");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("ВВедите координаты точки B:");
Console.WriteLine("x2:");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("y2:");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("z2:");
int z2 = int.Parse(Console.ReadLine()!);
double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow (z1-z2,2));
d = Math.Round(d,2);
Console.WriteLine($" Длина отрезка: {d}");