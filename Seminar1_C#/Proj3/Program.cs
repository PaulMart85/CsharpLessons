// Task: which number between two is greater
Console.Clear();

Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = b;

if (a > b) {
    max = a;
}

Console.WriteLine("a = " + a + "; b = " + b + " -> max = " + max);
