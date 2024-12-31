using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد را وارد کنید: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"عدد {n} جمله در دنباله فیبوناچی: {Fibonacci(n)}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}