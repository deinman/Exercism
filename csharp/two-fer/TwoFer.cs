public static class TwoFer
  {
      public static string Name(string input = null)
      {
          var name = string.IsNullOrEmpty(input) ? "you" : input;
          
          return $"One for {name}, one for me.";
      }
  }