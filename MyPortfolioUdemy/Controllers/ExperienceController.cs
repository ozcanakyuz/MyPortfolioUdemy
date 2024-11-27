﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

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
    }
}
