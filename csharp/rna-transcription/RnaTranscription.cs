using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class RnaTranscription
{
    private static readonly Dictionary<char, char> map = new Dictionary<char, char>()
    {
        {'C', 'G'},
        {'G', 'C'},
        {'T', 'A'},
        {'A', 'U'}
    };
    
    public static string ToRna(string nucleotide)
    {
        if (string.IsNullOrEmpty(nucleotide))
        {
            return nucleotide;
        }

        return nucleotide.Aggregate("", (current, c) => current + map[c]);
    }
}