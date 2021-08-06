﻿using Microsoft.AspNetCore.Mvc;
using Models;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(Product.GetProducts());
        }
    }
}