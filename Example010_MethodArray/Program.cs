int[] array = {1, 234, 345, 55 , 4, 23, 1, 55};

int n = array.Length;
int find = 55;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}