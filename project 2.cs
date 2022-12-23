using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Exercise28
{
    public static void Main()
    {
        int n, r, sum;
        int x, y;

        Console.Write("\n\n");
        Console.Write("Find perfect numbers within a given number of range:\n");
        Console.Write("------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the starting range or number : ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the ending range of number : ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("The Perfect numbers in between : ");
        for (n = x; n <=y; n++)
        {
            r = 1;
            sum = 0;
            while (r < n)
            {
                if (n % r == 0)
                    sum = sum + r;
                r++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }
}