using Microsoft.AspNetCore.Mvc;

namespace RACHELHERMOGINO.PRELIMEXAM.ECommerce.Contracts
{
    public class IService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
