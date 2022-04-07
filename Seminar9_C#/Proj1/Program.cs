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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();    
}

void PrintPascalTriangle(int[,] matr)
{
    int i, j;
    for (i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(0)-1-i; k++)
            Console.Write($" ");
        for (j = 0; j < i+1; j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();  
}

Console.Clear();
PrintPascalTriangle(PascalTriangle(4));