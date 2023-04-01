using Microsoft.AspNetCore.Mvc;

namespace RACHELHERMOGINO.PRELIMEXAM.ECommerce.Contracts.Common
{
    public class BaseDto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
