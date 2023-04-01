using Microsoft.AspNetCore.Mvc;

namespace RACHELHERMOGINO.PRELIMEXAM.ECommerce.Contracts.Genres
{
    public class IService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
namespace ECommerce.Contracts
{
    public interface IService
    {
    }
}