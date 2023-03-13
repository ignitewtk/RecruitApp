using Microsoft.AspNetCore.Mvc;

namespace RecruitApp.Controllers
{
    public class ProfilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
