using Microsoft.AspNetCore.Mvc;

namespace mateus_fattori_mvc_rm97904.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
