// Задача 1: Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3.3 8 -9,9
// 8 7,8 -7,1 9
double[,] CreateMatrixOfDouble(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Truncate((new Random().NextDouble()) 
                                          * (new Random().Next(-100,101)))/10;
        }
    }
    return matrix;
}

void PrintMatrix<T>(T[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
int[,] CreateMatrixOfInteger(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void ValueOfPosition(int x, int y, int[,] matr)
{
    if (x >= matr.GetLength(0) || y >=matr.GetLength(1))
        Console.WriteLine(x + " " + y + " -> element not found");
    else    
        Console.WriteLine(x + " " + y + " -> " + matr[x, y]);
}

// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void AveragePerColumnOf(int[,] matr)
{
    double avg = 0;
    int i, j;
    Console.Write("Average of each column: ");
    for (i = 0; i < matr.GetLength(1)-1; i++)
    {
        for (j = 0; j < matr.GetLength(0); j++) 
            avg += matr[j, i];
        Console.Write($"{Math.Round(avg/j,2)}; ");
        avg = 0;    
    }
    for (j = 0; j < matr.GetLength(0); j++) 
            avg += matr[j, i];
        Console.WriteLine($"{Math.Round(avg/j,2)}. ");
}

Console.Clear();
// The solvetion of the taks 1:
Console.WriteLine("Input a dimension (mxn) of a matrix:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = CreateMatrixOfDouble(m, n);
PrintMatrix(matrix);
Console.WriteLine();

// The solvetion of the taks 2:
Console.WriteLine("Input an element position (x, y) of a matrix:");
Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateMatrixOfInteger(new Random().Next(2, 10), new Random().Next(2, 10));
PrintMatrix(matrix1);
ValueOfPosition(x, y, matrix1);
Console.WriteLine();

// The solvetion of the taks 3:
int[,] matrix2 = CreateMatrixOfInteger(new Random().Next(2, 10), new Random().Next(2, 10));
PrintMatrix(matrix2);
AveragePerColumnOf(matrix2);
Console.WriteLine();