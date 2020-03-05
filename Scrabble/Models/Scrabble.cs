namespace Scrabble.Models
{
  public class Game
  {
    public string Word { get; set; }
    public int Score { get; set; }

    public void WordCalc(string word)
    {
      Word = word;
    }
    public int TallyLetters(string word)
    {
      int score = 0;
      char[] wordArr = word.ToCharArray();
      for (int i=0; i < wordArr.Length; i++)
      if (wordArr[i] == 't')
      {
        score ++;
      }
      return score;
    }
  }
  
}
