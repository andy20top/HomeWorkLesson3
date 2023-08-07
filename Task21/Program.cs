// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// d = sqrt((x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2);

System.Console.WriteLine("Введите координату Х1: ");
int numX1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y1: ");
int numY1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Z1: ");
int numZ1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату Х2: ");
int numX2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y2: ");
int numY2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Z2: ");
int numZ2 = int.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow((numX2 - numX1), 2) + Math.Pow((numY2 - numY1), 2) + Math.Pow((numZ2 - numZ1), 2));


System.Console.WriteLine($"Расстояние между точками = {Math.Round(dist, 2)}");