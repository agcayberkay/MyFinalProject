using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1,  ProductName="Computer", UnitsInStock=5, UnitPrice=23000},
               new Product{ ProductId=2, CategoryId=2,  ProductName="Phone", UnitsInStock=15, UnitPrice=13000},
               new Product{ ProductId=3, CategoryId=3,  ProductName="Glass", UnitsInStock=25, UnitPrice=3000},
               new Product{ ProductId=4, CategoryId=4,  ProductName="Mouse", UnitsInStock=15, UnitPrice=3500},
               new Product{ ProductId=5, CategoryId=5,  ProductName="Screen", UnitsInStock=9, UnitPrice=4000}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
