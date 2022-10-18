using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(100,4000))
            {
                Console.WriteLine(product.ProductName +" "+product.UnitPrice);
                Console.WriteLine("*********************");
            }

        }
    }
}
