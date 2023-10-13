void ShowNumbers(int n)
{
    if (n > 1) ShowNumbers(n - 1);
    System.Console.Write($"{n} ");
}

// ShowNumbers(5);

int Fact(int n)
{
    if (n > 1)
    {
        return Fact(n - 1) * n;
    }

    return 1;
}

// int sum = Fact(5);
// System.Console.WriteLine(sum);

// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N 

void ShowValuesRec(int n, int m)
{
    if (n != m)
    {
        ShowValuesRec(n, m + 1);
    }
    System.Console.Write($"{m} ");
}

// System.Console.WriteLine("Enter n number");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter m number");
// int m = Convert.ToInt32(Console.ReadLine());
// ShowValuesRec(Math.Max(n,m), Math.Min(n,m));

int SummDigits(int n)
{
    if (n < 0) n *= (-1);
    if (n > 10)
    {
        return SummDigits(n / 10) + n % 10;
    }
    else
    {
        return n;
    }
}
System.Console.WriteLine("Enter n number");
int n = Convert.ToInt32(Console.ReadLine());

int summ = SummDigits(n);
System.Console.WriteLine(summ);