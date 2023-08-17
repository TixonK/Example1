int[] array = {11, 2, 43, 54, 3, 23, 54, 57, 3};

int n = array.Length;
int find = 3;

int index = 0;

while (index < n)
{
    if (array[index] == find )
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

