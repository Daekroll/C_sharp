int a = 1;
int b = 0;
int c = 7;
int d = 1;
int e = 7;
int f = 7;
int g = 4;
int h = 5;

if (a > b 
    && c > d
    && e > a
    || a == 1
    || c == f
    ^ !(g != h))
    {
        System.Console.WriteLine("vse ok");
    }
else
{
    System.Console.WriteLine("vse ne ok");
} 
