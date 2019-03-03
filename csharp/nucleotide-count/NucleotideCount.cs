using System;
using System.Collections.Generic;

public class NucleotideCount
{
    private readonly Dictionary<char, int> _counts;

    public NucleotideCount(string sequence)
    {
        _counts = new Dictionary<char, int>
        {
            {'A', 0},
            {'C', 0},
            {'G', 0},
            {'T', 0}
        };

        foreach (var c in sequence)
        {
            if (!_counts.ContainsKey(c)) throw new InvalidNucleotideException();

            _counts[c]++;
        }
    }

    public IDictionary<char, int> NucleotideCounts => _counts;
}

public class InvalidNucleotideException : Exception
{
}