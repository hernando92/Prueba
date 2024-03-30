using Microsoft.AspNetCore.Mvc;

namespace Universidad.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("/index.html")]
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger/index.html");
        }
    }
}