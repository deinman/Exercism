using System;
using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var sb = new StringBuilder();
        var words = phrase.ToUpper()
            .Replace('-', ' ')
            .Replace('_', ' ')
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            sb.Append(word.AsSpan(0,1));
        }

        return sb.ToString().ToUpper();
    }
}