using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Espacios_y_trabajo

{
    class Program
    {
     
        static void Main(string[] args)
        {
           
            WebClient client = new WebClient();
            string reply = client.DownloadString("Http://msdn.microsoft.com");

            Console.WriteLine(reply);

      
            File.WriteAllText(@"C:\Users\zabdi\Downloads\Net-Coding-Fundamentals-master\.Net-Coding-Fundamentals-master\15-AssembliesAndNamespaces", reply);

            Console.ReadLine();
        }
    }
}
