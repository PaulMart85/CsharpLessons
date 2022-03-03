// Написать программу, принимающую на вход координаты двух точек 
// и определяющую расстояние между ними

Console.Clear();

double distanceBetweenTwoPoints(double xAcoord, double yAcoord, double xBcoord, double yBcoord) 
{
    return Math.Sqrt(Math.Pow(xBcoord - xAcoord,2) + Math.Pow(yBcoord - yAcoord,2));
}

double xa, ya;
double xb, yb;

Console.Write("Input the coordinates of the first point (Xa, Ya): Xa = ");
xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinates of the first point (Xa, Ya): Ya = ");
ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the coordinates of the second point (Xb, Yb): Xb = ");
xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinates of the second point (Xb, Yb): Yb = ");
yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The distance between two given points is " + distanceBetweenTwoPoints(xa, ya, xb, yb));