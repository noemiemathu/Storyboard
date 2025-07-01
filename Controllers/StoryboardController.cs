using Microsoft.AspNetCore.Mvc;
using Storyboard2.Models;

namespace StoryBoard2.Controllers
{
    public class StoryboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Change(int number, int selectedPanel, string title)
        {
            var model = new Story { Number = number, SelectedPanel = selectedPanel, Title = title };
            return View("Change", model);
        }
        public ActionResult Show()
        {
            return View("Show");
        }
    }
}
