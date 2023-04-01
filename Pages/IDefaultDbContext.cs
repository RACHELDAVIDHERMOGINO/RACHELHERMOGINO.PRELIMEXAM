using Microsoft.AspNetCore.Mvc;

namespace RACHELHERMOGINO.PRELIMEXAM.ECommerce.EntityFramework
{
    public interface IDefaultDbContext
    {
        IActionResult Index { get; }

        IActionResult Index();
    }
}