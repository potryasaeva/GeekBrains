using System;

namespace GeekBrainsFirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name");
            var userName = Console.ReadLine();
            var currentDate = DateTime.Now.ToLongDateString(); ;
            Console.WriteLine($"Hello {userName} today is {currentDate}");
        }
    }
}
