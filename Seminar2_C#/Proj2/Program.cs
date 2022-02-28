//Task: third digit of number
Console.Clear();

int ThirdDigitOfNumber(int num){
    int ver = num;
    int cnt = 0;

    do{
        ver = ver/10;
        cnt++;
    }
    while(ver >= 1 || ver <= -1);

    if(cnt < 3) {
        Console.Write("There is no third digit: ");
        return -1;
    }
    else return Math.Abs(num/Convert.ToInt32(Math.Pow(10,cnt-3)) % 10);
}

Console.Write("Input any number (or input R for random): ");
string number = Console.ReadLine().ToLower();
int givenNumber;

if (number == "r") {
    givenNumber = new Random().Next(-100000,100000);
}
else {
    givenNumber = Convert.ToInt32(number);
}

Console.WriteLine(givenNumber + " -> " + ThirdDigitOfNumber(givenNumber));