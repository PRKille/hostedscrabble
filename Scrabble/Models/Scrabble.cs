namespace Scrabble.Models
{
  public class Game
  {
    public string Word { get; set; }
    public int Score { get; set; }

    public void WordCalc(string word, int score)
    {
      Word = word;
      Score = 0;
    }
  }
  
}
