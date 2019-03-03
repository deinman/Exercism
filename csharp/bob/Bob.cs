using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        var trimmed = statement.Trim();
        var silentStatement = trimmed == string.Empty;
        var lastCharacterIsQuestionMark = !silentStatement && trimmed[trimmed.Length - 1] == '?';
        var lettersInSentence = string.Join("", trimmed.Where(char.IsLetter));
        var allLettersUpper = lettersInSentence.Any() && lettersInSentence.All(char.IsUpper);

        if (silentStatement)
            return "Fine. Be that way!";
        if (lastCharacterIsQuestionMark && allLettersUpper)
            return "Calm down, I know what I'm doing!";
        if (lastCharacterIsQuestionMark)
            return "Sure.";
        if (allLettersUpper)
            return "Whoa, chill out!";
        return "Whatever.";
    }
}