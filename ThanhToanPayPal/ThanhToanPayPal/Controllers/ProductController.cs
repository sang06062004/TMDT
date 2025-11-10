using Microsoft.AspNetCore.Mvc;
using MyEStore.Entities;

namespace ThanhToanPayPal.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyeStoreContext _ctx;

        public ProductController(MyeStoreContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View(_ctx.HangHoas.ToList());
        }

        public IActionResult Details(int id)
        {
            var prod = _ctx.HangHoas.SingleOrDefault(p => p.MaHh == id);
            return View(prod);
        }
    }
}
