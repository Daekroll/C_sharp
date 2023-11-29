int a1 = 11, b1 = 1,
    c1 = 5, a2 = 9,
    b2 = 74, c2 = 19,
    a3 = 98, b3 = 64,
    c3 = 4;

int Max(int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return(result);
    }

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);