//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int Quat(int x, int y){
//     if (x>0 && y>0)
//         return 1;
//     else if (x>0 && y<0)
//         return 4;
//     else if (x<0 && y>0)
//         return 2;
//     else 
//         return 3;
// }

// Console.WriteLine("Enter X point: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Y point: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x!=0 && y!=0){
//     int quater = Quat(x,y);
//     Console.WriteLine($"The number of quater is {quater}");
// }
// else{
//     Console.WriteLine($"Points is not on quater");
// }

//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

// void Range(int quat){
//     if (quat == 1)
//         Console.WriteLine("[X > 0;Y > 0]");
//     else if (quat == 2)
//         Console.WriteLine("[X < 0;Y > 0]");
//     else if (quat == 3)
//         Console.WriteLine("[X < 0;Y < 0]");
//     else
//         Console.WriteLine("[X > 0;Y < 0]");
// }

// Console.WriteLine("Enter quater number: ");
// int quat = Convert.ToInt32(Console.ReadLine());
// if(quat<1 || quat>4)
//     Console.WriteLine("Error");
// else
//     Range(quat);

//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.

// double Dist(int x1, int y1, int x2, int y2){
//     int x = x2-x1;
//     int y = y2-y1;
//     double res = Math.Round(Math.Sqrt(x*x + y*y),2);
//     return res;
// }

// Console.WriteLine("Enter x1 point: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1 point: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x2 point: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2 point: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Distance beetween points is {Dist(x1,y1,x2,y2)}");


//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4.
//-5 -> 1, 4, 9, 16, 25.


void Square(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i * i} ");
    }
}

Console.WriteLine("Enter a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 0)
    numb *= (-1);
else if (numb == 0)
    Console.WriteLine("Wrong number");
Square(numb);