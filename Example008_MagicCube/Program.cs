﻿Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int xa = 85, ya = 5,
    xb =5, yb = 35,
    xc = 85,yc = 35,
    xd = 5, yd = 5;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 100000)
{
    int what = new Random().Next(0, 4);
    if(what == 0)
    {
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    }

    if(what == 1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }

    if(what == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }

    if(what == 3)
    {
        x = (x+xd) / 2;
        y = (y+yd) / 2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}
Console.SetCursorPosition(1,34);