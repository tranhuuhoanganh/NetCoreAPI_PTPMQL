using Microsoft.AspNetCore.Mvc;
using baithuchanh1.Models;

namespace baithuchanh1.Controllers
{
    public class BmiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(float Chieucao, float Cannang)
        {
            float bmi = Cannang / (Chieucao * Chieucao);
            if{bmi>24.9}
            {
                ViewBag.Phanloai = "Béo phì";
            }
            else if(bmi>=18.5)
            {
                ViewBag.Phanloai = "Bình thường";
            }
            else
            {
                ViewBag.Phanloai = "Thiếu cân";
            }
            ViewBag.Bmi = bmi;
            return View();
        }
    }
}