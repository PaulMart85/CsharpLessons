// Написать программу, которая принимает на вход номер четверти и 
// выводит на экран диапазон координат, доступных в этой четверти

Console.Clear();

void NuberOfQuadrant(int q) {
    switch (q) {
        case 1: {
            Console.WriteLine(" X > 0, Y > 0");
            break;
        }   
        case 2: {
            Console.WriteLine(" X < 0, Y > 0");
            break;
        }
        case 3: {
            Console.WriteLine(" X < 0, Y < 0");
            break;
        }
        case 4: {
            Console.WriteLine(" X > 0, Y < 0");
            break;
        }
        default: {
            Console.WriteLine(" Quadrant is not defined.");
            break;
        }
    }
    
}

Console.Write("Input the number of quadrant: ");
int qdr = Convert.ToInt32(Console.ReadLine());

NuberOfQuadrant(qdr);
