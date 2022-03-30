Console.Clear();

// Задача 1: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4
int CountOfPosNumbs(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");            
    }
    Console.Write($"{array[array.Length-1]} -> ");            
}

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива.
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями. 
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1
void fillOutOf(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0 || i == matr.GetLength(0)-1) matr[i, j] = 1;
            else if (j == 0 || j == matr.GetLength(1)-1) matr[i, j] = 1;
            else matr[i, j] = 0;
        }
    }
}

void printMatrix(int[,] matr)
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


// The solvetion of the taks 1:
int M = new Random().Next(2, 10);
int[] array = new int[M];
Console.WriteLine("Input " + M + " ENTER-separated numbers:");
for (int i = 0; i < M; i++) array[i] = Convert.ToInt32(Console.ReadLine());

printArray(array);
Console.WriteLine(CountOfPosNumbs(array));

// The solvetion of the taks 2:
Console.WriteLine("Input the number of rows (or input R for random): ");
string number = Console.ReadLine().ToLower();
int row;
if (number == "r") {
    row = new Random().Next(3,20);
    Console.WriteLine(row);
}
else {
    row = Convert.ToInt32(number);
}

Console.WriteLine("Input the number of columns (or input R for random): ");
number = Console.ReadLine().ToLower();
int column;
if (number == "r") {
    column = new Random().Next(3,20);
    Console.WriteLine(column);
}
else {
    column = Convert.ToInt32(number);
}

int[,] matrix = new int[row, column];

Console.WriteLine(row + ", " + column + " -> ");
fillOutOf(matrix);
printMatrix(matrix);