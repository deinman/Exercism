using System;
using System.Linq;
using System.Collections.Generic;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (IsPrime(number))
        {
            return Classification.Deficient;
        }

        var aliquotSum = AliquotSum(number);

        if (aliquotSum == number)
        {
            return Classification.Perfect;
        }

        if (aliquotSum > number)
        {
            return Classification.Abundant;
        }

        return Classification.Deficient;
    }

    private static bool IsPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;

        var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

        for (int i = 2; i <= limit; ++i)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    private static int AliquotSum(int number)
    {
        var factors = GetFactors(number);

        return factors.Distinct().Sum();
    }

    private static IEnumerable<int> GetFactors(int number)
    {
        for (int factor = 1; factor * factor <= number; factor++)
        {
            if (number % factor == 0)
            {
                yield return factor;
                if (factor * factor != number)
                    yield return number / factor;
            }
        }
    }
}
