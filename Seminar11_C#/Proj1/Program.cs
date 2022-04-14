// Задача 3: Заданы 2 массива: info и data. В массиве data хранятся двоичные представления 
// нескольких чисел (без разделителя). В массиве info хранится информация о количестве бит, которые
// занимают числа из массива data. Напишите программу, которая составит массив десятичных представлений
// чисел массива data с учётом информации из массива info.
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1}
// info = {2, 3, 3, 1}
// выходные данные:
// 1, 7, 0, 1
int BinaryToDecimal(int[] array, int sum = 0)
{
    Array.Reverse(array);
    for (int i = 0; i < array.Length; i++)
        sum += array[i] * (int)Math.Pow(2,i);

    return sum;
}

int[] PrintDataByInfo(int[] data, int[] info)
{
    int sum = 0;
    for (int i = 0; i < info.Length; i++)
        sum += info[i];

    int[] dec = new int[info.Length];

    if (sum < data.Length) 
    {
        Console.WriteLine("Последние элементы в data удалены в соответствие с размером info!");
        data = data.ToList().GetRange(0, sum).ToArray();
    }
    if (sum > data.Length)
    {
        int dim = data.Length;
        Console.WriteLine("В data добавлены случайные элементы с конца в соответствие с размером info!");
        Array.Resize(ref data, dim + sum-dim);
        for (int i = dim; i < data.Length; i++)
            data[i] = new Random().Next(0,2);
    }

    Console.WriteLine("Input: ");
    Console.Write("data = {");
    for (int j = 0; j < data.Length-1; j++)
        Console.Write($"{data[j]}, ");
    Console.WriteLine($"{data[data.Length-1]}" + "}");

    Console.Write("info = {");
    for (int j = 0; j < info.Length-1; j++)
        Console.Write($"{info[j]}, ");
    Console.WriteLine($"{info[info.Length-1]}" + "}");

    for (int i = info.Length - 1; i >= 0; i--)
    {
        dec[i] = BinaryToDecimal(data.ToList().GetRange(data.Length - info[i], info[i]).ToArray());
        data = data.ToList().GetRange(0, data.Length-info[i]).ToArray();
    }

    return dec;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Output: ");
    for (int i = 0; i < array.Length-1; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine($"{array[array.Length-1]}");
}


Console.Clear();
// The solvetion of the task 3:
int[] data = {0, 1, 0, 1, 1, 0, 1, 0},
      info = {2, 5, 2, 2};     
PrintArray(PrintDataByInfo(data, info));

