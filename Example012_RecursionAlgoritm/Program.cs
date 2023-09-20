// string[,] table = new string[2,5];
//String.empti
//table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] 
//table[0,0] table[1,1] table[1,2] table[1,3] table[1,4]


// table[1,2]= "Слово";


// for(int rows =0; rows < 2; rows++)
// {
//     for(int columns =0;columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
// void PrintArray(int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for( int j = 0; j<matr.GetLength(1); j++)
//     {
//         Console.Write($"{matr[i, j]}");
//     }
// Console.WriteLine();
// }
// }

// void FillArray (int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for( int j = 0; j<matr.GetLength(1); j++)
//     {
//         matr[i,j] = new Random().Next(1, 10);
//     }
// Console.WriteLine();
// }
// }

// int[,] matr = new int [3,4];
// PrintArray(matr);
// FillArray(matr);
// Console.WriteLine();
// PrintArray(matr);


// double Factorial (int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial (n - 1);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


double Fibonacci (int n)
{
    if (n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i}! = {Fibonacci(i)}");
}
