// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива. 
int[,] CreateRandomMatrix(int row, int column)
{
    int[,] matrix = new int[row,column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matrix[i,j] = new Random().Next(1,10);

    return matrix;
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

int[,] SortMatrix(int[,] matr)
{
    int min, tmp;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int n = 0; n < matr.GetLength(1)-1; n++)
        {
            min = n;
            for (int m = n; m < matr.GetLength(1); m++)
                if(matr[i,m] < matr[i,min]) min = m;

            tmp = matr[i,n];
            matr[i,n] = matr[i,min];
            matr[i,min] = tmp;
        }   
    }
    return matr;
}


// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
void MinSumString(int[,] matr)
{
    int sumString = 0,
        minValue = 0,
        minIndex = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
            minValue += matr[0,j];
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            sumString += matr[i,j];

        if(sumString < minValue) 
        {
            minValue = sumString;
            minIndex = i;
        }

        sumString = 0;  
    
    }
    Console.WriteLine("The first-found string of the minimum sum of elements is " + (minIndex+1));
    Console.WriteLine();
}


// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// Массив размером 2 х 2 х 2
// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)
int[,,] CreateMatrix3D(int height, int width, int depth)
{
    int[,,] matrix3D = new int[height,width,depth];
    int[] rndGen = new int[height*width*depth];

    for (int i = 0; i < height*width*depth; i++)
    {
        do 
        {
            rndGen[i] = new Random().Next(10,100);
            for (int j = 0; j < i; j++)
            {
                if(rndGen[i] == rndGen[j]) rndGen[i] = 1;
                break;
            }
        } while (rndGen[i] == 1);
    }

    int n = 0;
    for (int i = 0; i < height; i++)
        for (int j = 0; j < width; j++)
            for (int k = 0; k < depth; k++)
                matrix3D[i,j,k] = rndGen[n++];

    return matrix3D;
}

void PrintMatrix3D(int[,,] matr3D)
{
    Console.WriteLine("Matrix of " + matr3D.GetLength(0) + 
                             " x " + matr3D.GetLength(1) + 
                             " x " + matr3D.GetLength(2));

    for (int i = 0; i < matr3D.GetLength(0); i++)
        for (int j = 0; j < matr3D.GetLength(1); j++)
        {
            for (int k = 0; k < matr3D.GetLength(2); k++)
                Console.Write($"{matr3D[i,j,k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    Console.WriteLine();    
}


// Задача 4: Заполните спирально массив 4 на 4.
// На выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
int[,] SpiralMatrix(int dimens)
{
    int[,] matrSpir = new int[dimens,dimens];

    int i = 0, cnt = 1;
    int j, n, k, m;
    while (i < (int)dimens/2)
    {
        for (j = i; j < dimens-1-i; j++)
            matrSpir[i,j] = cnt++;
        for (n = i; n < dimens-1-i; n++)
            matrSpir[n,j] = cnt++;
        for (k = j; k > i; k--)
            matrSpir[n,k] = cnt++;
        for (m = n; m > i; m--)
            matrSpir[m,k] = cnt++;   
        i++;
    }
    if(dimens%2 != 0) matrSpir[i,i] = cnt;

    return matrSpir;
}


Console.Clear();

// The solvetion of the task 1:
int[,] matrix1 = CreateRandomMatrix(row: 4, column: 5);
PrintMatrix(matrix1);
PrintMatrix(SortMatrix(matrix1));

// The solvetion of the task 2:
int q = 3; // dimension of rectangular array
int[,] matrix2 = CreateRandomMatrix(row: q, column: q);
PrintMatrix(matrix2);
MinSumString(matrix2);

// The solvetion of the task 3:
PrintMatrix3D(CreateMatrix3D(2,3,3));

// The solvetion of the task 4:
int dim = 4; // dimension of rectangular array
PrintMatrix(SpiralMatrix(dim));