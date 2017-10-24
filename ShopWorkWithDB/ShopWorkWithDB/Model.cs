using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ShopWorkWithDB
    { 

        [Table("Location")]
        public class Location
        {
 
            public int Id { get; set; }

            public string Name { get; set; }


            public List<Product> Products { get; set; }


        }


        [Table("User")]
        public class User
        {
            [Key]
            public int Id { get; set; }


            public string Name { get; set; }

  
            public string Surname { get; set; }


            public string Password { get; set; }


            public string Login { get; set; }


            public string Phone { get; set; }


            public string Role { get; set; }


            public Discount Discount { get; set; }
        }


        [Table("Discount")]
        public class Discount
        {

            public int Id { get; set; }

     
            public int Percent { get; set; }


            public string Description { get; set; }
        }


        [Table("ProductType")]
        public class ProductType
        {
      
            public int Id { get; set; }

          
            public string Name { get; set; }
        }


        [Table("Product")]
        public class Product
        {
  
            public int Id { get; set; }


            public string Name { get; set; }


            public double Price { get; set; }


            public Discount Discount { get; set; }
            
            public ProductType Type { get; set; }


            public int Count { get; set; }


        }

        [Table("Sale")]
        public class Sale
        {
    
            public int Id { get; set; }

      
            public List<Product> SaledProducts { get; set; }

      
            public double Sum { get; set; }

      
            public DateTime SaleDate { get; set; }
        }



        [Table("Move")]
        public class Move
        {

 
            public int ID { get; set; }

            public List<Product> Products { get; set; }


            public Location From { get; set; }

 
            public Location To { get; set; }

          
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
            public virtual DbSet<Discount> Discounts { get; set; }
            public virtual DbSet<ProductType> ProductTypes { get; set; }
        }
    
}
