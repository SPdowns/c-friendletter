using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello Fwend"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye Fwend."; }
    [Route("/")]

    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lin";
      myLetterVariable.Sender = "Jazmine";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }

  }
}