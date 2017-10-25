using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelWriter;
using ShopWorkWithDB;


namespace ConsoleAppTestFinaly
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Discount> discs = new List<Discount>();
            discs.Add(new Discount() { Description = "DiscountDescription_1", Id = 1, Percent = 10 });
            discs.Add(new Discount() { Description = "DiscountDescription_2", Id = 2, Percent = 20 });
            discs.Add(new Discount() { Description = "DiscountDescription_3", Id = 3, Percent = 30 });
            discs.Add(new Discount() { Description = "DiscountDescription_4", Id = 4, Percent = 40 });

            List<ProductType> prodtypes = new List<ProductType>();
            prodtypes.Add(new ProductType() { Id = 1, Name = "ProductType_1" });
            prodtypes.Add(new ProductType() { Id = 2, Name = "ProductType_2" });
            prodtypes.Add(new ProductType() { Id = 3, Name = "ProductType_3" });
            prodtypes.Add(new ProductType() { Id = 4, Name = "ProductType_4" });

            List<Product> p = new List<Product>();
            p.Add(new Product() { Id = 1, Count = 1, Name = "product1", Discount = discs[0], Price = 100, Type = prodtypes[3] });
            p.Add(new Product() { Id = 2, Count = 2, Name = "product2", Discount = discs[1], Price = 200, Type = prodtypes[2] });
            p.Add(new Product() { Id = 3, Count = 3, Name = "product3", Discount = discs[2], Price = 300, Type = prodtypes[1] });
            p.Add(new Product() { Id = 4, Count = 4, Name = "product4", Discount = discs[3], Price = 400, Type = prodtypes[0] });
            p.Add(new Product() { Id = 5, Count = 5, Name = "product5", Discount = discs[0], Price = 500, Type = prodtypes[3] });


            List<Sale> s = new List<Sale>();
            s.Add(new Sale() { Id = 1, SaleDate = DateTime.Now, SaledProducts = p.GetRange(1, 4), Sum = 000 });
            s.Add(new Sale() { Id = 2, SaleDate = DateTime.Now, SaledProducts = p.GetRange(1, 3), Sum = 999 });
            s.Add(new Sale() { Id = 3, SaleDate = DateTime.Now, SaledProducts = p.GetRange(3, 2), Sum = 888 });
            s.Add(new Sale() { Id = 4, SaleDate = DateTime.Now, SaledProducts = p.GetRange(1, 1), Sum = 777 });


            ExcelWriter.ExcelWriter.WriteToExcel(s, @"test.xls");
        }

    }
}
