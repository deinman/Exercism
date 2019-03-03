using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }

        ulong ret = 1;

        if (n == 1)
        {
            return ret;
        }

        for (var i=1; i<n; i++)
        {
            ret = ret * 2;
        }

        return ret;
    }

    public static ulong Total()
    {
        ulong ret = 0;

        for (int i = 1; i <= 64; i++)
        {
            ret += Square(i);
        }

        return ret;
    }
}