using Microsoft.AspNetCore.Mvc;

namespace iChatApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
