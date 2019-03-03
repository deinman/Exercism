using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        // Per instructions, "spaces and hyphens are allowed to appear multiple times"
        var sanitizedWord = word.Replace(" ", string.Empty).Replace("-", string.Empty).ToUpper();

        return sanitizedWord.Count() == sanitizedWord.ToCharArray().Distinct().Count();
    }
}
