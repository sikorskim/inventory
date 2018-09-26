using System;
using System.Text.RegularExpressions;

namespace inventory
{
    class Program
    {

        private readonly ApplicationDbContext _context;

        public Program (ApplicationDbContext context)
        {
            _context = context;
        }

        static void Main(string[] args)
        {
            printMessage();          
            readInput();
        }

        static void printMessage()
        {
            Console.WriteLine("Computerman Inventory");
            Console.WriteLine("Ready to input...");
        }

        static void readInput()
        {
            Device dev = new Device();
            while(true)
            {
                string input = Console.ReadLine();
                Console.WriteLine("input="+input);
                dev.findDevice(input);
            }
        }
    }
}