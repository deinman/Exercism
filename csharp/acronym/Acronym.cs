using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var sb = new StringBuilder();
        var words = Regex.Split(phrase, @"[^\p{L}]*\p{Z}[^\p{L}]*");

        foreach (var word in words)
        {
            sb.Append(word.Substring(0,1));
        }

        return sb.ToString().ToUpper();
    }
}