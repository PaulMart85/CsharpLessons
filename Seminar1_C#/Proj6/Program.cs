// Task: all even numbers from 1 to N in question
Console.Clear();

Console.Write("Input the number: ");
int N = Convert.ToInt32(Console.ReadLine());

int even = 1;

Console.Write(N + " -> ");

if (N > 0) {
    while (even <= N) {
        if (even%2 == 0) {
            Console.Write(even + ", ");
        }
        even++;
    }
}
else {
     while (even >= N) {
        if (even%2 == 0) {
            Console.Write(even + ", ");
        }
        even--;
    }
}

Console.WriteLine();