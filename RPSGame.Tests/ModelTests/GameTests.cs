using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSGame.Models;

namespace RPSGame.Tests
{
  [TestClass]

  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame_Game()
    {
      Game newGame = new Game("scissors");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GetUserChoice_ReturnUserChoice_String()
    {
      string choice = "scissors";
      Game newGame = new Game("scissors");
      Assert.AreEqual(newGame.PlayerChoice, choice);

    }

    [TestMethod]
    public void SetUserChoice_ReturnUserChoice_String()
    {
      Game newGame = new Game("");
      newGame.PlayerChoice = "scissors";
      Assert.AreEqual(newGame.PlayerChoice, "scissors");
    }

    [TestMethod]
    public void CalculateWin_ReturnsWinOrLoseMessage_String()
    {
      Game newGame = new Game("rock");
      Assert.AreEqual("You tied!", newGame.CalculateWin());
    }

    [TestMethod]
    public void CalculateWin_ReturnsTieMessage_String()
    {
      Game newGame = new Game("scissors");
      string result = newGame.CalculateWin();
      Assert.IsTrue("You lose!" == result || "You win!" ==  result || "You tied!" == result);
    }
  }
}