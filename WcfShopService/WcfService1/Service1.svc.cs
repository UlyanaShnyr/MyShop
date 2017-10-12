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
        static List<byte> file = new List<byte>();
        mySkype db = new mySkype(new SqlConnectionStringBuilder()
        {
            DataSource = @"RUSLAN\SQLEXPRESS",
            InitialCatalog = "MyReg2",
            IntegratedSecurity = false,
            UserID = "sa",
            Password = "1",
        }.ConnectionString);

        public string Test() { return "Working"; }

        public User isExist(User user)
        {
            foreach (var i in db.Users)
                if (user.Login == i.Login) return i;
            return null;
        }

        public bool corPass(User user)
        {
            if (user.Password == db.Users.Where(x => x.Login == user.Login).First().Password) return true;
            return false;
        }

        public bool isEnter(User user)
        {
            return corPass(isExist(user));
        }

        public string Reg(User user)
        {
            try
            {
                

                db.Users.Add(user);
                db.SaveChanges();

                return "OK";
            }
            catch(Exception ex) {
                return ex.Message; }
        }
        public void SaveFile(byte[] bytes,string ext)
        {
            file.AddRange(bytes);
         }

        public void SaveToFile( string ext)
        {
            File.WriteAllBytes(@"D:\\IISTeach\" + ext, file.ToArray());
            file.Clear();
        }
    }
}
