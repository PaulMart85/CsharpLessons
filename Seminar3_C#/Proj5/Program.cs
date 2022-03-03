// Task: the distance between two points in 3D
Console.Clear();

double distanceBetweenTwoPoints3D(double xAcoord, double yAcoord, double zAcoord, double xBcoord, double yBcoord, double zBcoord) 
{
    return Math.Sqrt(Math.Pow(xBcoord - xAcoord,2) + Math.Pow(yBcoord - yAcoord,2) + Math.Pow(zBcoord - zAcoord,2));
}

double xa, ya, za;
double xb, yb, zb;

Console.Write("Input the coordinates of the first point (Xa, Ya, Za): Xa = ");
xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinates of the first point (Xa, Ya, Za): Ya = ");
ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinates of the first point (Xa, Ya, Za): Za = ");
za = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the coordinates of the second point (Xb, Yb, Zb): Xb = ");
xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinates of the second point (Xb, Yb, Zb): Yb = ");
yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinates of the second point (Xb, Yb, Zb): Zb = ");
zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("A(" + xa + "," + ya + "," + za + "); B(" + xb + "," + yb + "," + zb + ") -> " + distanceBetweenTwoPoints3D(xa, ya, za, xb, yb, zb));