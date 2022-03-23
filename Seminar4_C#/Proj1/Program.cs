Console.Clear();

// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
long Pow(int A, int B)
{
    long res = 1;

    for (int i = 0; i < B; i++) res *= A;

    return res;
}

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumDigitsOf(int C)
{
    int ver = Math.Abs(C), sum = 0;

    do
    {
        sum += ver%10;
        ver = ver/10;
    } while (ver >=1);
    
    return sum;
}

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] ArrayOf8Elems()
{
    int[] array = new int[8];

    for(int i=0; i < 8; i++) array[i] = new Random().Next(-100, 101);

    return array;
}
void PrintFrrayOf8Elems(int[] array)
{
    for(int i=0; i < 7; i++) Console.Write($"{array[i]}, ");
    Console.Write(array[7] + " -> [");
    
    for(int i=0; i < 7; i++) Console.Write($"{array[i]}, ");
    Console.Write(array[7] + "]");
}


int A = new Random().Next(-101, 101);
int B = new Random().Next(1, 10);
Console.WriteLine(A + ", " + B + " -> " + Pow(A, B));
Console.WriteLine();

int C = new Random().Next(-1000000, 1000001);
Console.WriteLine(C + " -> " + SumDigitsOf(C));
Console.WriteLine();

int[] array = ArrayOf8Elems();
PrintFrrayOf8Elems(array);
Console.WriteLine();