using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfAppClient.ServiceReference1;

namespace WcfAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            Console.WriteLine(client.GetData(1));
            Console.ReadKey();
        }
    }
}
