Console.Clear();

int xa = 40, ya = 1,
    xb = 5, yb = 40,
    xc = 110, yc = 40;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("o");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("o");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("o");


int x = xa, y = ya;
int cnt = 0;

while(cnt < 100000) {
int rnd = new Random().Next(0, 3);

if (rnd == 0) {
    x = (x + xa)/2;
    y = (y + ya)/2;
}

if (rnd == 1) {
    x = (x + xb)/2;
    y = (y + yb)/2;
}

if (rnd == 2) {
    x = (x + xc)/2;
    y = (y + yc)/2;
}


Console.SetCursorPosition(x,y);
Console.WriteLine("+");
cnt++;
}