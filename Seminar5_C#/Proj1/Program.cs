Console.Clear();

// Задача 1: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] buildArray1(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++) array[i] = new Random().Next(1, 1000);
    
    return array;
}

int countOfEvenNumbers(int[] array)
{
    int cnt = 0; // a counter of even numbers
    for (int i = 0; i < array.Length; i++) if (array[i]%2 == 0) cnt++;

    return cnt;
}

void printArray<T>(T[] array, T res)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++) Console.Write($"{array[i]}, ");
    Console.WriteLine($"{array[array.Length-1]}] -> " + res);
}

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] buildArray2(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++) array[i] = new Random().Next(-99, 100);
    
    return array;
}

int sumOfOddPositions(int[] array)
{
    int sum = 0; // a summary of odd positions
    for (int i = 1; i < array.Length; i=i+2) sum += array[i];

    return sum;
}

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами
//  массива.
// [3, 7, 22, 2, 78] -> 76
double[] buildArray3(int arrayLength)
{
    double[] array = new double[arrayLength];
    for (int i = 0; i < arrayLength; i++) array[i] = Math.Truncate((new Random().NextDouble()) * (new Random().Next(-10000,10001)))/100;
    
    return array;
}

double diffMaxMin(double[] array)
{
    if (array.Length == 1) return array[0];

    int max = 1,  // indexes of max and min elements
        min = 0;
    if (array[0] > array[1]) 
    {
        max = 0;
        min = 1;
    } 

    for (int i = 2; i < array.Length; i++) 
    {
        if (array[i] > array[max]) max = i;
        else if (array[i] < array[min]) min = i;
    }

    return array[max] - array[min];
}

// The solvetion of the taks 1:
int[] array1 = buildArray1(5);
printArray(array1, countOfEvenNumbers(array1));

// The solvetion of the taks 2:
int[] array2 = buildArray2(6);
printArray(array2, sumOfOddPositions(array2));

// The solvetion of the taks 3:
double[] array3 = buildArray3(4);
printArray(array3, Math.Round(diffMaxMin(array3), 2));