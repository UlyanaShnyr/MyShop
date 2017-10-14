using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1
{

    [DataContract]
    [Table("Location")]
    public class Location
    {
        [DataMember]
        public int Id{get; set;}

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Product> Products { get; set; }


    }

    [DataContract]
    [Table("User")]
    public class User
    {
        [Key]
        [DataMember]
        public int Id{ get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Password { get; set; }


        [DataMember]
        public string Login { get; set; }


        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public int Role { get; set; }

        [DataMember]
        public Discount _Discont { get; set; }
    }

    [DataContract]
    [Table("Discount")]
    public class Discount
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Percent { get; set; }


        [DataMember]
        public string Description { get; set; }
    }

    [DataContract]
    [Table("ProductType")]
    public class ProductType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    [Table("Product")]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public Discount _Discont { get; set; }

        [DataMember]
        public ProductType _Type { get; set; }

        [DataMember]
        public int _Count { get; set; }


    }

    [DataContract]
    [Table("Sale")]
    public class Sale
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public List<Product> SaledProducts { get; set; }

        [DataMember]
        public double Sum { get; set; }

        [DataMember]
        public DateTime SaleDate { get; set; }
    }


    [DataContract]
    [Table("Move")]
    public class Move
    {

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public List<Product> Products { get; set; }

        [DataMember]
        public Location From { get; set; }

        [DataMember]
        public Location To { get; set; }

        [DataMember]
        public DateTime Date { get; set; }
        
    }


    public class ShopDB : DbContext
    {
        public ShopDB(string connection) : base(connection) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Location> Locatoins { get; set; }
        public virtual DbSet<Move> Move { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }

    }
}
