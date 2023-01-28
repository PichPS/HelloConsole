int Max(int arg1, int arg2, int arg3);
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 5, b1 = 4, c1 = 20, a2 = 89, b2 = 45, c2 = 78, a3 = 7, b3 = 2, c3 = 18;

int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);
