// Task: if the number of the week is a weekend
Console.Clear();

string IsItWeekeend(int num) {

    if (num < 1 || num > 7) return "No such a weekday's number!";

    if (num == 6 || num == 7) {
        return "Yes, it is a weekend!";
    }
    else {
        return "No, it is not a weekend!";
    }
}

Console.Write("Input the number of the weekday (or input R for a random choice): ");
string ver = Console.ReadLine().ToLower();
int numberOfWeekday;

if (ver == "r") {
    numberOfWeekday = new Random().Next(1,8);
}
else {
    numberOfWeekday = Convert.ToInt32(ver);
}

Console.WriteLine(numberOfWeekday + " -> " + IsItWeekeend(numberOfWeekday));