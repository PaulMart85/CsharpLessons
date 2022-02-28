// Task: second digit of three-digit number
Console.Clear();

int SecDigitOfNumber(int num){
    if (num/100 < 1 || num/100 > 9) {
        Console.Write("It is not a three-digit number: ");
        return -1;
    }
    else return (num/10)%10;
}

Console.Write("Input any three-digit number (or input R for random): ");
string number = Console.ReadLine().ToLower();
int givenNumber;

if (number == "r") {
    givenNumber = new Random().Next(100,1000);
}
else {
    givenNumber = Convert.ToInt32(number);
}

Console.WriteLine(givenNumber + " -> " + SecDigitOfNumber(givenNumber));