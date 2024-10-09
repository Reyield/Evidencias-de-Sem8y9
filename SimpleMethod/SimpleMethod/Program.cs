using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
        class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.ReadLine();
        }
        private static void HelloWorld()
        {
            Console.WriteLine("Hello world");
        }

        private static void ReverseString()
        {
            string message = "Hello world";
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char c in messageArray)
            {
                Console.Write(item);
            }
        }
    }
}