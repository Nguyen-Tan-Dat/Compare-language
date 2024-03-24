using System;
using System.Diagnostics;

class test
{
    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int count = 0;
        // Tính số lượng số nguyên tố nhỏ hơn 1000000
        for (int i = 2; i < 20000000; i++)
        {
            if (IsPrime(i))
                count++;
        }

        stopwatch.Stop();
        TimeSpan elapsed = stopwatch.Elapsed;

        Console.WriteLine($"Found {count} prime numbers in {elapsed}");
    }
}
