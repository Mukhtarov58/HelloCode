// Console.WriteLine("Input a number: ");

// int num = Convert.ToInt32(Console.ReadLine());

// int res = num * num;
// Console.WriteLine($"Quater of {num} is {res}");


Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = n * (-1);
for( int i = current; i<= n; i++){
    Console.Write($" {i} ");
}