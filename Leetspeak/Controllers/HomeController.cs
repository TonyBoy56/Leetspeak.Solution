using Microsoft.AspNetCore.Mvc;
using Leetspeak.Models;

namespace Leetspeak.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/translate")]
    public ActionResult Translate(string word)
    {
      LeetspeakTranslator translator = new LeetspeakTranslator(word);
      translator.Translate();
      return View(translator);
    }
  }
}