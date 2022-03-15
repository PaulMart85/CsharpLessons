// Task: first two max numbers and first two min numbers from the sequence of Z numbers
Console.Clear();

int max1, max2, min1, min2, varMax, varMin;
ag:
Console.WriteLine("Input numbers(of Z) one by one with Enter after each input. Input 0 to finish:");
Console.WriteLine();

max1 = Convert.ToInt32(Console.ReadLine());

if (max1 != 0) 
{
    min2 = max1;
    max2 = Convert.ToInt32(Console.ReadLine());
    if (max2 != 0) 
    {
        min1 = max2;
        varMax = max2;
    }
    else 
    {
        Console.WriteLine("Not less than two numbers are expected"); 
        goto ag;
    }
} 
else 
{
    Console.WriteLine("No numbers"); 
    goto ag;
}

do 
{
    if (varMax > max1)
    {
        max2 = max1;
        max1 = varMax;
        varMin = max2;
    }
    else if(varMax > max2 && varMax != max1) 
    {
        //varMin = max2;
        max2 = varMax;
        varMin = varMax;
    }
    else varMin = varMax;
        
    // here we have varMin <= max2
    if (varMin < min1)
    {
        min2 = min1;
        min1 = varMin;
    }
    else if(varMin < min2 && varMin != min1) min2 = varMin;
    
    varMax = Convert.ToInt32(Console.ReadLine());
}
while (varMax != 0);

Console.WriteLine("First two max numbers are " + max1 + " and " + max2);
Console.WriteLine("First two min numbers are " + min1 + " and " + min2);