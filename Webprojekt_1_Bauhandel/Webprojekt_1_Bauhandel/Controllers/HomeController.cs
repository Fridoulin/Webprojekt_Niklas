﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Webprojekt_1_Bauhandel.Models;

namespace Webprojekt_1_Bauhandel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Impressum()
        {
            return View();
        }
    }
}
