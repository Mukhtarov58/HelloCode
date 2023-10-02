int[] CreateArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    int sizeArr = array.Length;
    for (int i = 0; i < sizeArr / 2; i++)
    {
        int temp = array[i];
        array[i] = array[sizeArr - 1 - i];
        array[sizeArr - 1 - i] = temp;
    }

    return array;
}

// Console.WriteLine("Enter min of array value:  ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array value:  ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array value:  ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateArray(min, max, size);
// ShowArray(newArray);
// Console.WriteLine();
// ShowArray(ReverseArray(newArray));


// bool IsTriangle(int a, int b, int c)
// {
//     return a + b > c && a + c > b && b + c > a;
// }

// Console.WriteLine("Input firs part:  ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second part:  ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third part:  ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (IsTriangle(a, b, c))
//     Console.WriteLine("triangle can be alive!!!");
// else
//     Console.WriteLine("you die!");


// int BinaryNumber(int num){
//     int res = 0;
//     int power= 0;
//     while(num>0)
//     {
//         res+=num %2 * Convert.ToInt32(Math.Pow(10,power));
//         power++;
//         num/=2;
//     }
//     return res;
// }

// Console.WriteLine("Input num :  ");
// int num = Convert.ToInt32(Console.ReadLine());
// BinaryNumber(num);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void PrintFibonacciNumbers(int N)
// if (N > 0)
// {
//     {
//         int[] fibNum = new int[N];
//         fibNum[0] = 0;
//         fibNum[1] = 0;
//         Console.Write(fibNum[0] + " ");
//         Console.Write(fibNum[1] + " ");


//         for (int i = 0; i < N; i++)
//         {
//             fibNum[i] = fibNum[i - 1] + fibNum[i - 2];
//             Console.Write(fibNum[i] + " ");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Error!!!");
//     }
// }
// Console.WriteLine("Input num :  ");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintFibonacciNumbers(num);


// int FindMaxValue(ref int[] array)
// {
//     int max = array[0];
//     int index = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//             index = i;
//         }
//     }
//     int[] temp = new int[array.Length - 1];
//     for (int j = 0; j < index - 1; j++)
//     {
//         temp[j] = array[j];
//     }
//     for (int k = index; k < array.Length; k++)
//     {
//         temp[k - 1] = array[k];
//     }
//     array = temp;
//     return max;
// }


int [] BubbleSort(int [] array)
{
    int  temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}


Console.WriteLine("Enter min of array value:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array value:  ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter size of array value:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(min, max, size);
ShowArray(newArray);
BubbleSort(newArray);
Console.WriteLine($"{newArray[newArray.Length - 1]} and {newArray[newArray.Length - 2]}");
