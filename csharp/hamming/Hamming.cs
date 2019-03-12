using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }

        if (firstStrand == secondStrand
            || string.IsNullOrEmpty(firstStrand)
            || string.IsNullOrEmpty(secondStrand))
        {
            return 0;
        }

        return firstStrand
                .Zip(secondStrand, (l, r) => new { l, r })
                .Count(n => n.l != n.r);
    }
}