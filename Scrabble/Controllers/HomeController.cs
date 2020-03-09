using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/scrabblescore")]
    public ActionResult ScrabbleScore(string word)
    {
      Game newGame = new Game();
      newGame.Word = word;
      newGame.Score = newGame.TallyLetters(word);
      return View(newGame);
    }

  }
}    