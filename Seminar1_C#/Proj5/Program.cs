// Task: is it an even number?
Console.Clear();

Console.Write("Input the number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0) {
    Console.WriteLine(a + " -> Yes");
}
else {
    Console.WriteLine(a + " -> No");
}