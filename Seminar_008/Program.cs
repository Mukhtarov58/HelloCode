// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива

int[,] ChangedRowsMatrx(int[,] matrix, int firstRowNumber = 1, int secondRowNumber = -1)
{
    if (secondRowNumber == -1) secondRowNumber = matrix.GetLength(0);
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int[,] result = new int[rows, cols];
    Array.Copy(matrix, result, rows * cols);
    int temp;
    for (int j = 0; j < rows; j++)
    {
        temp = result[firstRowNumber - 1, j];
        result[firstRowNumber - 1, j] = result[secondRowNumber - 1, j];
        result[secondRowNumber - 1, j] = temp;
    }
    return result;
}

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

// int[,] array = Create2dArray(10, 40, 5, 10);
// Show2dArray(array);

// int[,] newmatrix = ChengeRowMatrix(array);
// Show2dArray(newmatrix);

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] CrossRowsAndCols(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);
//     for(int i = 0; i< rows; i++:){
//         int temp = matrix[i,j];
//         matrix[i,j] = matrix[j,i];
//         matrix[j,i] = temp;
//     }
//     return matrix;
// }

// int[,] array = Create2dArray(1,3,4,5);


void Print2DArrayInt(int[,] matrix)
{
    Console.Write("\t");
    int tabSize = Console.CursorLeft;

    for (int m = 0; m < matrix.GetLength(1); m++)
    {
        Console.Write($"{m}\t");
    }
    Console.WriteLine();
    Console.Write(new string('_', tabSize * (matrix.GetLength(1) + 1)));
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{i}:\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] CreateIncreasingMatrixInt(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    matrix[0, 0] = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j - 1] + k;
        }
        if (i + 1 < matrix.GetLength(0))
            matrix[i + 1, 0] = matrix[i, matrix.GetLength(1) - 1] + k;
    }
    return matrix;
}

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int[,] TransposedMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int[,] result = new int[cols, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[j, i] = matrix[i, j];
        }
    }
    return result;
}


int[,] crossRowsAndCols(int [,] matrix){
        int countRow = matrix.GetLength(0);
        int countCol = matrix.GetLength(1);

        if(countRow != countCol){
            int [,] buff = new int[countCol, countRow];

            for(int i = 0; i < countCol; i++){
                for(int j = 0; j < countRow; j++){
                    buff[i,j] = matrix[j, i];
                }
            }
            return buff;
        } else {

            for(int i = 0; i < countRow; i++){
                for(int j = i + 1; j < countCol; j++){
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
            return matrix;
        }
    }

int[,] arr1 = CreateIncreasingMatrixInt(5, 7, 3);
Print2DArrayInt(arr1);
Console.WriteLine();
int[,] arr2 = crossRowsAndCols(arr1);
Print2DArrayInt(arr2);

// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


  void PrintMatrix (int [,] matrix)
  {
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
          Console.Write($"{matrix[i, j]}\t");
      }
      Console.WriteLine();
    }
  }

int[,] CreateMatrix(int n, int m)
  {
    int[,] matrix = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {

        matrix[i, j] = random.Next(0, 5);

      }
    }

    return matrix;
  }

  void CountNumbers(int[,] matrix)
  {
    int[] uniqValues = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int[] friquancy = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int uc = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
        bool flag = false;
        for(int k = 0; k < uc; k++)
        {
          if(matrix[i, j] == uniqValues[k])
          {
            flag = true;
            friquancy[k]++;
          }
        }
        if(!flag) 
        {
          uniqValues[uc] = matrix[i,j];
          friquancy[uc] = 1;
          uc++;
        }
      }
    }
    for(int i = 0; i < uc; i++)
    {
      Console.WriteLine($"{uniqValues[i]} встречается {friquancy[i]} раз");
    }

  }
  
  int[,] matrix = CreateMatrix(3, 3);
  PrintMatrix(matrix);
  
  CountNumbers(matrix);
