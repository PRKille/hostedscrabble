using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      StartGame();
    }

    public static void StartGame()
    {
      Console.WriteLine("Please enter a word to calculate the scrabble score!");
      string userInput = Console.ReadLine().ToLower();
      Game newGame = new Game();
      Console.WriteLine($"Your score is {newGame.TallyLetters(userInput)}!");
    }
  }
}