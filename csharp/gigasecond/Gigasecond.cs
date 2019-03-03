using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(10e8);
    }
}