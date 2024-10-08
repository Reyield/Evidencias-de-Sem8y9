namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.WriteLine();

            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name:");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastname;
            Console.Write("type your last name");
            myLastname = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastname);
            Console.ReadLine();
        }
    }
}
