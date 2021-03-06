using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SimpleApp.Models;
using SimpleApp.Controllers;
using SimpleApp.Repo;
using Xunit;

namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        // class FakeDataSource : IDataSource
        // {
        //     public IEnumerable<Product> Products { get; set; }
        //     public FakeDataSource(Product[] data)
        //     {
        //         Products = data;
        //     }
        // }
        
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            Product[] testData = new Product[]
            {
                new Product { Name = "p1", Price = 275M },
                new Product { Name = "p2", Price = 120M },
                new Product { Name = "p3", Price = 110M }
            };
            var mock = new Mock<IDataSource>();
            mock.SetupGet(m => m.Products).Returns(testData);
            var controller = new HomeController();
            controller.dataSource = mock.Object;
            
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
            
            // Assert
            Assert.Equal(testData, model,
                Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
            mock.VerifyGet(m => m.Products, Times.Once);
        }
    }
}