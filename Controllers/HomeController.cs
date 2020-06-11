using Microsoft.AspNetCore.Mvc;
using InsecureBindingConfiguration_POC.Data;

namespace InsecureBindingConfiguration_POC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var repo = new UserRepository();
            var cedric = repo.GetTheUser();
            return View(cedric);
        }
    }
}
