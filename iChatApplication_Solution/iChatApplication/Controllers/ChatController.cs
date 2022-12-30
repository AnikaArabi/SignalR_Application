using Microsoft.AspNetCore.Mvc;

namespace iChatApplication.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
