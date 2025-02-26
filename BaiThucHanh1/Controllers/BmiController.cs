using Microsoft.AspNetCore.Mvc;
using BaiThucHanh1.Models;

namespace BaiThucHanh1.Controllers
{
    public class BmiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bmi model)
        {
            if (model.ChieuCao > 0 && model.CanNang > 0)
            {
                float chieuCaoMet = model.ChieuCao / 100; // Chuyển cm → m
                float bmi = model.CanNang / (chieuCaoMet * chieuCaoMet); // Tính BMI

                string phanLoai;

                if (bmi < 18.5)
                    phanLoai = "Gầy";
                else if (bmi < 24.9)
                    phanLoai = "Bình thường";
                else if (bmi < 29.9)
                    phanLoai = "Thừa cân";
                else if (bmi < 34.9)
                    phanLoai = "Béo phì độ 1";
                else if (bmi < 39.9)
                    phanLoai = "Béo phì độ 2";
                else
                    phanLoai = "Béo phì độ 3";

                ViewBag.BMI = $"Chỉ số BMI của bạn là: {bmi:F2} - {phanLoai}";
            }
            else
            {
                ViewBag.BMI = "Vui lòng nhập số hợp lệ!";
            }

            return View();
        }
    }
}
