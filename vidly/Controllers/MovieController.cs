﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shark" };
            return View();
            
        }
    }
}