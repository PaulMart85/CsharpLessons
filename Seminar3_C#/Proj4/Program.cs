// Task: if the five-digit number is a palindrome
Console.Clear();

string ifNumberIsPalindrome(int numb)
{
    int cnt = 0, ver = numb;
    do
    {
        ver = ver/10;
        cnt++;
    } while (ver >=1);

    int[] array = new int[cnt];
    int index = 0;

    while (index < cnt) 
    {
        array[index++] = numb%10;
        numb = numb/10;
    }
    
    //int[cnt] array = {numb/10000, numb/1000%10, numb/100%10, numb/10%10, numb%10};
    index = 0;
    while (index < cnt/2) 
    {
        if (array[index] != array[cnt-1 - index++]) return "No"; 
    }
    return "Yes";
}

Console.Write("Input the five-digit number (or input R for a random choice): ");
string val = Console.ReadLine().ToLower();
int fiveDigNumb;

if (val == "r") fiveDigNumb = new Random().Next(10000,100000);
else fiveDigNumb = Convert.ToInt32(val);

Console.WriteLine(fiveDigNumb + " -> " + ifNumberIsPalindrome(fiveDigNumb));