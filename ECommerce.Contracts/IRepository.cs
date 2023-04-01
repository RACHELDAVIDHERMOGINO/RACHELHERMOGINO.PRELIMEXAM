using Microsoft.AspNetCore.Mvc;

namespace RACHELHERMOGINO.PRELIMEXAM.ECommerce.Contracts
{
    public class IRepositories : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
