using System;
using System.Collections.Generic;
using System.Linq;

public class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence) 
    {
        string validNucleotide = "ACGT";

        if (!sequence.All(validNucleotide.Contains))
        {
            throw new ArgumentException();
        }

        return (sequence + validNucleotide).GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count() - 1);
    }
}