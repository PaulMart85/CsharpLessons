// Написать программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();

int NumberOfQuadrant(double xCoord, double yCoord) {
    if (xCoord > 0 && yCoord > 0) return 1;
    if (xCoord < 0 && yCoord > 0) return 2;
    if (xCoord < 0 && yCoord < 0) return 3;
    if (xCoord > 0 && yCoord < 0) return 4;
    return 0;
}

double x, y;
Console.Write("Input the point (X, Y): X = ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the point (X, Y): Y = ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The number of quadrant where the point (" + x + ", " + y + ") locates is " + NumberOfQuadrant(x, y));