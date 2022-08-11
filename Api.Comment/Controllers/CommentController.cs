using Microsoft.AspNetCore.Mvc;

namespace Api.Comment.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
