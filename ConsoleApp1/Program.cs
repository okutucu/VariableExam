using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string s = "";
            string s1;
            string s2 = null;

            byte b = 5;
            sbyte sb = 5;

            object obj = "New object";

            string s23 = "21";
            int i23 = 21;

            Console.WriteLine(i23 + int.Parse(s23));
            Console.WriteLine(i23.ToString() + s23);

        }
    }
}
