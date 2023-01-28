int[] array = {11, 24, 35, 64, 75 ,16 ,71, 18, 16};

int n = array.Length;

int find = 16;

int index = 0;

while (index < n) 
{
    if (array[index] == find)
    {
        Console.WriteLine (index);
        break;

    }
    index++;
}
