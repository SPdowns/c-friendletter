using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello Fwend"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye Fwend."; }
    [Route("/")]
    public ActionResult Letter() { return View(); }


  }
}