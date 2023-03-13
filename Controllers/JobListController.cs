using Microsoft.AspNetCore.Mvc;

namespace RecruitApp.Controllers
{
    public class JobListController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Theme"] = "Main Page for Seeker";
            return View();
        }
        public string Welcome()
        {
            return "Welcome to job list";
        }
        public IActionResult Search(string s1, string s2)
        {
            ViewData["keywords"] = "keywords for Seeker";

            
            return View();
        }


    }
}
