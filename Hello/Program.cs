using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach(var item in args)
            //{
            //    Console.WriteLine("Witaj " + item);
            //}
            string Name = args[0];
            Console.WriteLine("Witaj " + Name);
        }
    }
}
