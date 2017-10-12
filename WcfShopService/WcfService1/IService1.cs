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
        int isEntered(User user);

        /// <summary>
        /// Admin registrate new cashier
        /// </summary>
        /// <param name="user">new user</param>
        /// <returns>Login & Password</returns>
        [OperationContract]
        string Registration(User user);

        /// <summary>
        /// Get all priducts
        /// </summary>
        /// <returns>List of products</returns>
        [OperationContract]
        List<Product> GetProducts();

        /// <summary>
        /// Get all products on storage
        /// </summary>
        /// <returns>List of products</returns>
        [OperationContract]
        List<Product> GetStorage();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">place from move product</param>
        /// <param name="to">place to move product</param>
        /// <param name="products">products which move</param>
        /// <returns>true if opreration complete false if failed</returns>
        [OperationContract]
        bool Move(Location from, Location to, List<Product> products);

        /// <summary>
        /// Get all products on shop
        /// </summary>
        /// <returns>List of products</returns>
        [OperationContract]
        List<Product> GetShop();



    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
}
