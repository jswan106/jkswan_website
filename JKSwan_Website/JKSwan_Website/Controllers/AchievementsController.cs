﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JKSwan_Website.Controllers
{
    public class AchievementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
