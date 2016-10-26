using EntityFrameworkHW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseInitializers.Models
{
    public class ProductsDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

            context.Products.Add(new Product() { ProductId = 1, ProductName = "Axe", ProductPrice = 45 });
            context.Products.Add(new Product() { ProductId = 2, ProductName = "Fructis", ProductPrice = 50 });
            context.Products.Add(new Product() { ProductId = 3, ProductName = "Timotei", ProductPrice = 40 });


            context.ProductTypes.Add(new ProductType() { ProductTypeId = 1, ProductId = 1, Name = "Shampoo" });
            context.ProductTypes.Add(new ProductType() { ProductTypeId = 2, ProductId = 1, Name = "Conditioner" });
            context.ProductTypes.Add(new ProductType() { ProductTypeId = 3, ProductId = 2, Name = "Shampoo" });
            context.ProductTypes.Add(new ProductType() { ProductTypeId = 4, ProductId = 2, Name = "Conditioner" });
            context.ProductTypes.Add(new ProductType() { ProductTypeId = 5, ProductId = 3, Name = "Conditioner" });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}

