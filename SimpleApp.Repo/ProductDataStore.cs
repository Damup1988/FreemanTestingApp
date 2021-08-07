using System.Collections.Generic;
using SimpleApp.Models;

namespace SimpleApp.Repo
{
    public class ProductDataStore : IDataSource
    {
        public IEnumerable<Product> Products =>
            new Product[]
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "LifeJacket", Price = 48.95M }
            };
    }
}