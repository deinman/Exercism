using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public HighScores(List<int> scores) => ScoreList = scores;

    public List<int> ScoreList { get; }

    public List<int> Scores() => ScoreList;

    public int Latest() => ScoreList.Last();

    public int PersonalBest() => ScoreList.OrderByDescending(x => x).First();

    public List<int> PersonalTopThree() => ScoreList.OrderByDescending(x => x).Take(3).ToList();
}