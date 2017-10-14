using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        /// <summary>
        /// Chek User's Rights
        /// </summary>
        /// <param name="user">user</param>
        /// <returns>-1 not found, 0 - Cashier, 1 - Admin </returns>
        [OperationContract]
        int Enter(User user);

        /// <summary>
        /// Admin registrate new cashier
        /// if user exsist generate LoginExsistException
        /// todo: LoginExsistException
        /// </summary>
        /// <param name="user">new user</param>
        /// <returns>Login & Password</returns>
        [OperationContract]
        string Registration(User user);

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List of products</returns>
        [OperationContract]
        List<Product> GetProducts();

        /// <summary>
        /// Get all products on shop
        /// </summary>
        /// <returns>List of products</returns>
        [OperationContract]
        List<Product> GetProducts(int idLocation);

        /// <summary>
        /// Move a product from one location to another
        /// </summary>
        /// <param name="from">place from move product</param>
        /// <param name="to">place to move product</param>
        /// <param name="products">products which move</param>
        /// <returns>true if opreration complete false if failed</returns>
        [OperationContract]
        bool Move(int idFrom, int idTo, List<Product> products);

   


        /// <summary>
        /// Get locations
        /// </summary>
        /// <returns>List of loactions</returns>
        [OperationContract]
        List<Location> GetLocations();


        /// <summary>
        /// add new location
        /// </summary>
        /// <returns>true if success false failed</returns>
        [OperationContract]
        bool AddLocations(string name);

        /// <summary>
        /// Check discont on product
        /// </summary>
        /// <param name="product">product</param>
        /// <returns>discont in %</returns>
        [OperationContract]
        int CheckDiscont(Product product);

        /// <summary>
        /// Check users discont
        /// </summary>
        /// <param name="user">user</param>
        /// <returns>discont in %</returns>
        [OperationContract]
        int CheckDiscont(User user);

        /// <summary>
        /// Add users discont
        /// </summary>
        /// <param name="user">user</param>
        /// /// <param name="percent">percent</param>
        /// <returns>discont in %</returns>
        [OperationContract]
        int AddUserDiscont(int idUser, int percent);


        /// <summary>
        /// Add product discont
        /// </summary>
        /// <param name="product">product</param>
        /// <param name="percent">percent</param>
        /// <returns>discont in %</returns>
        [OperationContract]
        int AddProductDiscont(int idProduct, int percent);

        /// <summary>
        /// Get product types
        /// </summary>
        /// <returns>List of Types</returns>
        [OperationContract]
        List<ProductType> GetProductTypes();


        /// <summary>
        /// Add product types
        /// </summary>
        /// <returns>List of Types</returns>
        [OperationContract]
        List<ProductType> AddProductTypes(string type);

        /// <summary>
        /// Get moves of product in specified period
        /// </summary>
        /// <param name="from">from this time</param>
        /// <param name="to">to this time</param>
        /// <returns>List of Moves</returns>
        [OperationContract]
        List<Move> GetProductMoves(DateTime from, DateTime to);

        /// <summary>
        /// Get sales of product in specified period
        /// </summary>
        /// <param name="from">from this time</param>
        /// <param name="to">to this time</param>
        /// <returns>List of Sales</returns>
        [OperationContract]
        List<Sale> GetProductSales(DateTime from, DateTime to);


        /// <summary>
        /// Format new sale
        /// </summary>
        /// <param name="sale">new sale</param>
        /// <returns>true if success, false if failed</returns>
        [OperationContract]
        bool FormatSale(Sale sale, int idLocation);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
}
