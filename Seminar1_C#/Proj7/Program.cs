Console.Clear();

void FillArray(double[] mas) {

    int count = 0;

    while (count < mas.Length) {
        mas[count] = new Random().Next(1,20)/10.0;
        count++;
    }
}

void PrintArray(double[] mas) {

    int counter = 0;
    while (counter < mas.Length) {
        Console.Write(mas[counter] + "  ");
        counter++;
    }
    Console.WriteLine();
}

void AccendArray(double[] mas) {

    int index = 0, index1 = 0;
    double var;

    while (index < mas.Length-1) {
        index1 = index+1;
            while(index1 < mas.Length) {
                if (mas[index] > mas[index1]) {
                    var = mas[index];
                    mas[index] = mas[index1];
                    mas[index1] = var;
                }
            index1++;
        }
        index++;
    }
}

void DecendArray(double[] mas) {

    int index = 0, index1 = 0;
    double var;

    while (index < mas.Length-1) {
        index1 = index+1;
            while(index1 < mas.Length) {
                if (mas[index] < mas[index1]) {
                    var = mas[index];
                    mas[index] = mas[index1];
                    mas[index1] = var;
                }
            index1++;
        }
        index++;
    }
}

void FirstIndexOf(double[] mas, double val) {

    int pos = -1;
    int count = 0;
    while (count < mas.Length) {
        if (mas[count] == val) {
            pos = count;
            break;
        }
        count++;
    }
    Console.WriteLine(pos);
}

void LastIndexOf(double[] mas, double val) {

    int pos = -1;
    int count = 0;
    while (count < mas.Length) {
        if (mas[count] == val) {
            pos = count;
        }
        count++;
    }
    Console.WriteLine(pos);
}

double[] number = new double[5];

Console.Write("Initial array is:  ");
FillArray(number);
PrintArray(number);

Console.Write("Input any value of array: ");
double val =  Convert.ToDouble(Console.ReadLine());
Console.Write("First index of array at value " + val + " is  ");
FirstIndexOf(number, val);
Console.Write("Last index of array at value " + val + " is  ");
LastIndexOf(number, val);

Console.Write("Accending array is:  ");
AccendArray(number);
PrintArray(number);

Console.Write("Decending array is:  ");
DecendArray(number);
PrintArray(number);