using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentException();
        }

        var counter = 0;
        var n = number;

        while (n != 1)
        {
            counter++;
            n = Collatz(n);
        }

        return counter;
    }

    private static int Collatz(int n)
    {
        if (n == 1)
        {
            return 0;
        }

        if (n % 2 == 0)
        {
            return n / 2;
        }
        else
        {
            return (3 * n) + 1;
        }
    }
}