

    using System;
    class program
    {
        static public void Main()
        {

            int a, b, i, j, num;

            Console.Write(
            "Enter lower number: ");
            a = Convert.ToInt32(
            Console.ReadLine());

            Console.Write(
            "\nEnter the higher number: ");
            b = Convert.ToInt32(
            Console.ReadLine());

            Console.Write("\nPrime numbers between are : " + a
                        + " and " + b + " are: ");

            if (a == 1)
            {
                Console.Write(a + " ");
                a++;
                if (b >= 2)
                {
                    Console.Write(a + " ");
                    a++;
                }
            }
            if (a == 2)
            {
                Console.Write(a + " ");
            }

            if (a % 2 == 0)
            {
                a++;
            }

            for (i = a; i <= b; i = i + 2)
            {

                num = 1;

                for (j = 2; j * j <= i; ++j)
                {
                    if (i % j == 0)
                    {
                        num = 0;
                        break;
                    }
                }

                if (num == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }