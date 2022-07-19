// Задача 21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z2");
int z2 = int.Parse(Console.ReadLine());


double Distance(int x1Local, int y1Local, int z1Local, int x2Local, int y2Local, int z2Local)
{
    double Dis = Math.Sqrt(Math.Pow((x1Local - x2Local), 2) + Math.Pow((y1Local - y2Local), 2) + Math.Pow((z1Local - z2Local), 2));
    return Dis;
}

Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));
