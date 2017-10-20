using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWorkWithDB
{
    class ShopDbService
    {
        ShopDB db = new ShopDB(new SqlConnectionStringBuilder()
        {
            DataSource = @"RUSLAN\SQLEXPRESS",
            InitialCatalog = "AccountigSystem",
            IntegratedSecurity = false,
            UserID = "sa",
            Password = "1",
        }.ConnectionString);



        public bool AddLocations(string locationName)
        {
            if (db.Locatoins.Select(location => location.Name == locationName).Count() > 0) return false;
            db.Locatoins.Add(new Location() { Name = locationName });
            return true;
        }

        public int AddProductDiscont(int idProduct, int percent)
        {
            db.Products.Where(product => product.Id == idProduct).First()._Discont.Percent = percent;
            db.SaveChanges();
            return percent;
        }

        public List<ProductType> AddProductTypes(string type)
        {
            if (db.ProductTypes.Select(_type => _type.Name).Contains(type)) throw new NotImplementedException();
            db.ProductTypes.Add(new ProductType() { Name = type });
            db.SaveChanges();
            return db.ProductTypes.ToList();
        }

        public int AddUserDiscont(int idUser, int percent)
        {
            db.Users.Where(user => user.Id == idUser).First()._Discont.Percent = percent;
            db.SaveChanges();
            return percent;
        }

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
            if (_user != null)
            {
                return user.Role;
            }
            return -1;
        }

        public bool FormatSale(Sale sale, int idLocation)
        {

            foreach (var item in db.Locatoins.Where(locate => locate.Id == idLocation).First().Products)
            {
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

        public List<Location> GetLocations()
        {
            return db.Locatoins.ToList();
        }

        public List<Move> GetProductMoves(DateTime from, DateTime to)
        {
            return db.Move.Where(move => move.Date >= from && move.Date <= to).ToList();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public List<Product> GetProducts(int idLocation)
        {
            return db.Locatoins.Where(location => location.Id == idLocation).First().Products;
        }

        public List<Sale> GetProductSales(DateTime from, DateTime to)
        {
            return db.Sales.Where(prod => prod.SaleDate >= from && prod.SaleDate <= to).ToList();
        }

        public List<ProductType> GetProductTypes()
        {
            return db.ProductTypes.ToList();
        }





        public bool Move(int idFrom, int idTo, List<Product> products)
        {
            return true;
        }

        public string Registration(User user)
        {
            if (db.Users.Where(_user => _user.Login == user.Login).Count() > 0)
                throw new NotImplementedException();//todo LoginExsistException

            db.Users.Add(user);
            db.SaveChanges();
            return user.Login + " " + user.Password;
        }

    }

}
