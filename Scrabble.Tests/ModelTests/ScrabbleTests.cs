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
  }
}