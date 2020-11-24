using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webprojekt_1_Bauhandel.Models;

namespace Webprojekt_1_Bauhandel.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View(ArticleList());
        }
        private List<Shoparticle> ArticleList()
        {
            return new List<Shoparticle>()
            {
                new Shoparticle(1, "Schlagbohrmaschine", "Zum Bohren durch Beton bzw. Löcher stemmen", 189.99m, Art.Kabel, Category.Schlagbohrmaschine),
                new Shoparticle(2, "Akkuschrauber", "Zum Bohren durch Beton bzw. Löcher stemmen", 189.99m, Art.Akku, Category.Akkuschrauber) };
            }
        }
    }

