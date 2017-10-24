using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWorkWithDB
{
    public class ShopDbService
    {
        private ShopDB db = new ShopDB(new SqlConnectionStringBuilder()
        {
            DataSource = @"ShopDataBase.mssql.somee.com",
            InitialCatalog = "ShopDataBase",
            IntegratedSecurity = false,
            UserID = "kosmi4_SQLLogin_2",
            Password = "hb29w57hmo",
            WorkstationID = "ShopDataBase.mssql.somee.com",
            PacketSize = 4096,
            PersistSecurityInfo = false,

        }.ConnectionString);

        public ShopDB DB
        {
            get { return db; }
        }
                

        public bool AddLocations(string locationName)
        {
            if (db.Locatoins.Select(location => location.Name == locationName).Count() > 0) return false;
            db.Locatoins.Add(new Location() { Name = locationName });
            return true;
        }

        public int AddProductDiscount(int idProduct, int percent)
        {
            db.Products.Where(product => product.Id == idProduct).First().Discount.Percent = percent;
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

        public int AddUserDiscount(int idUser, int percent)
        {
            db.Users.Where(user => user.Id == idUser).First().Discount.Percent = percent;
            db.SaveChanges();
            return percent;
        }
        

        public int CheckDiscount(Product product)
        {
            return product.Discount.Percent;
        }

        public int CheckDiscount(User user)
        {
            return user.Discount.Percent;
        }

        public string Enter(User user)
        {
            var _user = db.Users.Where(x => x.Login == user.Login && x.Password == user.Password).First();
            if (_user != null)
            {
                return user.Role;
            }
            return null;
        }

        public bool FormatSale(Sale sale, int idLocation)
        {

            foreach (var item in db.Locatoins.Where(locate => locate.Id == idLocation).First().Products)
            {
                foreach (var saled in sale.SaledProducts)
                {
                    if (item.Type == saled.Type && saled.Count <= item.Count)
                    {
                        item.Count -= saled.Count;
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

        /// <summary>
        /// Функція яка перевіряє чи є такий Користувач(Адмін, Касир) з таким іменем та паролем          
        /// </summary>
        /// <param name="Name"> І'мя Користувача </param>
        /// <param name="Password"> Пароль Користувача </param>
        /// <returns>Якщо є то повертає Користувача, інкакше повертає null</returns>
        public User CheckingUser(string Login, string Password)
        {
            User user = db.Users.FirstOrDefault(x => x.Login == Login);
            if(user != null)
            {
                if (user.Password == Password) return user;
            }
            return null;
        }

    }

}
