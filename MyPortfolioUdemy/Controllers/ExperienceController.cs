using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            if (!ModelState.IsValid) // Doğrulama başarısızsa
            {
                // Hata mesajları ile birlikte formu tekrar göster
                return View(experience);
            }

            // Doğrulama başarılıysa veritabanına kaydet
            context.Experiences.Add(experience);
            context.SaveChanges();

            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }


        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            if (!ModelState.IsValid) // Doğrulama başarısızsa
            {
                // Hata mesajları ile birlikte formu tekrar göster
                return View(experience);
            }

            // Doğrulama başarılıysa veritabanına kaydet
            context.Experiences.Update(experience);
            context.SaveChanges();

            return RedirectToAction("ExperienceList");
        }
    }
}
