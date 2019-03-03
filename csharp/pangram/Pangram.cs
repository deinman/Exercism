using System;
using System.Linq;
using System.Text;

public static class Pangram
{
    private static readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static bool IsPangram(string input)
    {
        return alphabet.All(input.ToUpper().Contains);
    }
}
