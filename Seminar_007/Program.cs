int[,] Create2dArray(int min, int max, int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }

    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// int[,] ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < array.GetLength(1); j += 2)
//         {
//             array[i, j] *= array[i, j];
//         }
//     }
//     return array;
// }

// int[] FindMaxes(int[,] array)
// {
//     int[] arrayMaxes = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arrayMaxes[i] += array[i, j];
//         }
//     }
//     return arrayMaxes;
// }

// void ShowArrayAndMax(int [] arr){
//     for(int i = 0;i<arr.Lenth; i++){
//         Console.WriteLine($"{arr[i]} ")
//     } 
//     int max = arr.Max();
//     Console.WriteLine(max);
// }

void ShowSum( int [,] array){
    int sum =0;
    for(int i = 0; i<array.GetLength(0); i++){
        sum += array[i,i]
    }
    Console.WriteLine($"Sum on main diag in {sum}");
}


Console.WriteLine("Enter number of rows in array: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of col in array: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value in array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value in array: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = Create2dArray(min, max, row, col);
Show2dArray(array);

Console.WriteLine();

ShowSum(array);

// int[,] changedArr = ChangeArray(array);
// Show2dArray(array);
