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
            InitialCatalog = "MyReg2",
            IntegratedSecurity = false,
            UserID = "sa",
            Password = "1",
        }.ConnectionString);

        public int CheckDiscont(Product product)
        {
            throw new NotImplementedException();
        }

        public int CheckDiscont(User user)
        {
            throw new NotImplementedException();
        }

        public int Enter(User user)
        {
            throw new NotImplementedException();
        }

        public bool FormatSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public List<Move> GetProductMoves(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetProductSales(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public List<Type> GetProductTypeds()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetShop()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetStorage()
        {
            throw new NotImplementedException();
        }

        public bool Move(Location from, Location to, List<Product> products)
        {
            throw new NotImplementedException();
        }

        public string Registration(User user)
        {
            throw new NotImplementedException();
        }

        public string Test() { return "Working"; }

     
        
    }
}
