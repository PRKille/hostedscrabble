using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void WordCalc_CreateNewInstance_NewInstance()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      newGame.WordCalc("test", 0);
      // Assert
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void TallyLetters_CalculateScore_1()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      int result = newGame.TallyLetters("A");
      // 
      Assert.AreEqual(1, result);
    }
  }
}