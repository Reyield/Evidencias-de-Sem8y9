namespace matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int nummber1 = 4;
            //int nummber2 = 8;
            //int nummber3 = 15;
            //int nummber4 = 16;
            //int nummber5 = 23;

            //if (number1 == 16)
            //{ 
            //}
            //else if (number2 == 16)
            //{
            //}
            //else if(number3 == 16) 
            //{ 
            //}


            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers.Length);
            //Console.ReadLine();

            //int[] numbers2 = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "eddie", "Alex", "Michaeel", "David lee" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadLine();

            //    foreach (string name in names)
            //    {
            //        Console.WriteLine(name);

            //    }
            //    Console.ReadLine();

            string zig = "You can get what you want out of life" + "if you help enough other peoble get what they want.";

            char[] charArray = zig.ToCharArray():
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.WriteLine(zigChar);
            }
            Console.ReadLine();
        }
    }
}
