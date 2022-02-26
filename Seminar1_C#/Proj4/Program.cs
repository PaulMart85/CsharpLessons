// Task: which number among three is greater
Console.Clear();

Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b) {
    max = b;
}
if (max < c) {
    max = c;
}

Console.WriteLine(a + ", " + b + ", " + c + " -> " + max);