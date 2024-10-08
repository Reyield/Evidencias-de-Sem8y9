using System;
using Sytem.collections.Generic;
using System.Linq
using System.Threading.Task;

namespace Decisions
{
    class Program
    {
        
        static void Main(string[] args
        {
            //Console.WriteLine("Bob's big Giveaway");
            //Console.WriteLine("Choose a door: 1,2,3:");
            //string userValue = Console.ReadLine();

            //string message = "";

            //if (userValue == "1")
            //    message = "You won a new car!";
            //else if (userValue == "2")
            //    message = "You won a new boat";
            //else if (userValue == "3")
            //    message = "you won a new cat";
            //else
            //{
            //    message = "sorry, we didnt understand";
            //    message = message + "you lose";
            //}
            //Console.WriteLine(message);
            //Console.ReadLine();


            Console.WriteLine("Bob's big Giveaway");
            Console.WriteLine("Choose a door: 1,2,3:");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of limit";
            Console.WriteLine('You won a ');
            Console.Write(message);
            Console.Write(".");

            //Console.WriteLine('You won a {0}.', message);
            Console.WriteLine("you entered a {0}, therefore you won a {1}." , userValue, message);

            Console.ReadLine();
        }
    }