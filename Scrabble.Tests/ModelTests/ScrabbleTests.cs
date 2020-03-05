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
      newGame.WordCalc("test");
      // Assert
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void TallyLetters_CalculateScore_1()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      int result = newGame.TallyLetters("hello");
      // 
      Assert.AreEqual(8, result);
    }
    [TestMethod]
    public void TallyLetters_CalculateScore_2()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      int result = newGame.TallyLetters("dog");
      // 
      Assert.AreEqual(5, result);
    }
        [TestMethod]
    public void TallyLetters_CalculateScore_3()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      int result = newGame.TallyLetters("camp");
      // 
      Assert.AreEqual(10, result);
    }
    public void TallyLetters_CalculateScore_4()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      int result = newGame.TallyLetters("five");
      // 
      Assert.AreEqual(10, result);
    }
    public void TallyLetters_CalculateScore_5()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      int result = newGame.TallyLetters("kid");
      // 
      Assert.AreEqual(8, result);
    }
    public void TallyLetters_CalculateScore_8()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      int result = newGame.TallyLetters("jam");
      // 
      Assert.AreEqual(12, result);
    }
    public void TallyLetters_CalculateScore_10()
    {
      // Arrange
      Game newGame = new Game();
      // Act
      int result = newGame.TallyLetters("queen");
      // 
      Assert.AreEqual(14, result);
    }
  }
}