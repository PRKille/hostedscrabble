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
      if (wordArr[i] == 'a' || wordArr[i] == 'e' || wordArr[i] == 'i' || wordArr[i] == 'o' || wordArr[i] == 'u' || wordArr[i] == 'l' || wordArr[i] == 'n' || wordArr[i] == 'r' || wordArr[i] == 's' || wordArr[i] == 't')
      {
        score ++;
      }
      else if (wordArr[i] == 'd' || wordArr[i] == 'g')
      {
        score += 2;
      }
      else if (wordArr[i] == 'b' || wordArr[i] == 'c' || wordArr[i] == 'm' || wordArr[i] == 'p')
      {
        score += 3;
      }
      else if (wordArr[i] == 'f' || wordArr[i] == 'h' || wordArr[i] == 'v' || wordArr[i] == 'w' || wordArr[i] == 'y')
      {
        score += 4;
      }
      else if (wordArr[i] == 'k')
      {
        score += 5;
      }
      else if (wordArr[i] == 'j' || wordArr[i] == 'x')
      {
        score += 8;
      }
        else if (wordArr[i] == 'q' || wordArr[i] == 'z')
      {
        score += 10;
      }
      return score;
    }
  }
}
