﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using SimpleApp.Controllers;
using Xunit;

namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();
            Product[] products = new Product[]
            {
                new Product {Name = "KayakTest", Price = 275M},
                new Product {Name = "LifejacketTest", Price = 48.95M}
            };
            
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
            
            // Assert
            Assert.Equal(products, model,
                Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
        }
    }
}