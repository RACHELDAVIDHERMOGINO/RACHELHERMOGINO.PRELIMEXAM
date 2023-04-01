using Microsoft.AspNetCore.Mvc;

namespace RACHELHERMOGINO.PRELIMEXAM.ECommerce.EntityFramework
{
    public class DefaultDbContext : Controller
    {
        public IActionResult Index => View();
    }
}
