// Треугольник Паскаля
int[,] PascalTriangle(int level)
{
    int[,] pasTr = new int[level+1,level+1];

    pasTr[0,0] = 1;

    for (int i = 1; i < level+1; i++)
        pasTr[0,i] = 0;

    for (int i = 1; i < level+1; i++)
    {
        pasTr[i,0] = 1;
        for (int j = 1; j < level+1; j++)
            pasTr[i,j] = pasTr[i-1,j-1] + pasTr[i-1,j];     
    }
   
    return pasTr;
}

string DigIndend(int value, string indend = "")
{
    return value==0 ? indend : DigIndend(value / 10, indend + " ");
}

string FinIndend(int len, string indend = " ")
{
    return len==0 ? indend : FinIndend(len-1, indend + " ");
}

void PrintPascalTriangle(int[,] matr)
{
    int n = matr.GetLength(0);
    string[] pt = new string[n];

    for (int i = n-1; i > 0; i--)
        for (int j = 0; j < i+1; j++)
            pt[i] += $"{matr[i,j]}{DigIndend(matr[i-1,j])}"; 
    pt[0] = "1";

    int shift = (double)n%2 == 0 ? 1 : 0;
    int sp = pt[n-1].Length/2 - shift;

    for (int i = 0; i < n-1; i++)    {
        Console.WriteLine($"{FinIndend(sp - pt[i].Length/2)}{pt[i]}");
    }

    Console.WriteLine();  
}

Console.Clear();
PrintPascalTriangle(PascalTriangle(20));