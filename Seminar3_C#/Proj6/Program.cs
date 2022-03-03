// Task: 3-powered numbers from 1 to N in question
Console.Clear();

void threePowNumbers(int numb) 
{
    int threePowNumb = 1;

    if (numb > 0) 
    {
        while (threePowNumb < numb) 
        {
            Console.Write(Math.Pow(threePowNumb,3) + ", ");
            threePowNumb++;
        }
        Console.WriteLine(Math.Pow(threePowNumb,3));
    }
    else
    {
        while (threePowNumb > numb) 
        {
            Console.Write(Math.Pow(threePowNumb,3) + ", ");
            threePowNumb--;
        }
        Console.WriteLine(Math.Pow(threePowNumb,3));
    }
}

Console.Write("Input the number N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write(N + " -> ");
threePowNumbers(N);