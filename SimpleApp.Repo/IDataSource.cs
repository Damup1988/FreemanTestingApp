using System;
using System.Collections.Generic;
using SimpleApp.Models;

namespace SimpleApp.Repo
{
    public interface IDataSource
    {
        IEnumerable<Product> Products { get; }
    }
}