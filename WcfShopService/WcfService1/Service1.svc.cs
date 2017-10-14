using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        ShopDB db = new ShopDB(new SqlConnectionStringBuilder()
        {
            DataSource = @"RUSLAN\SQLEXPRESS",
            InitialCatalog = "AccountigSystem",
            IntegratedSecurity = false,
            UserID = "sa",
            Password = "1",
        }.ConnectionString);

        public int CheckDiscont(Product product)
        {
            return product._Discont.Percent;
        }

        public int CheckDiscont(User user)
        {
            return user._Discont.Percent;
        }

        public int Enter(User user)
        {
            var _user = db.Users.Where(x => x.Login == user.Login && x.Password == user.Password).First();
            if (_user!=null)
            {
                return user.Role;
            }
            return -1;
        }

        public bool FormatSale(Sale sale)
        {
            foreach (var item in db.Shop.First().Products) {
                foreach (var saled in sale.SaledProducts)
                {
                    if (item._Type == saled._Type && saled._Count <= item._Count)
                    {
                        item._Count -= saled._Count;
                        db.Sales.Add(sale);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            return false;         
        }

        public List<Move> GetProductMoves(DateTime from, DateTime to)
        {
            return db.Move.Where(move => move.Date >= from && move.Date <= to).ToList();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public List<Sale> GetProductSales(DateTime from, DateTime to)
        {
            return db.Sales.Where(prod => prod.SaleDate >= from && prod.SaleDate <= to).ToList();
        }

        public List<ProductType> GetProductTypes()
        {
            return db.ProductTypes.ToList();
        }

        public List<Product> GetShop()
        {
            return db.Shop.First().Products;
        }

        public List<Product> GetStorage()
        {
            return db.Storages.First().Products;
        }

        public bool Move(Location from, Location to, List<Product> products)
        {
            return true;
        }

        public string Registration(User user)
        {
            if(db.Users.Where(_user=>_user.Login == user.Login).Count() > 0)
                  throw new NotImplementedException();//todo LoginExsistException

            db.Users.Add(user);
            db.SaveChanges();
            return user.Login + " " + user.Password;
        }

        public string Test() { return "Working"; }

     
        
    }
}
