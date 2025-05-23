using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Customer
    {
        //viết poco
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public void PrintInfo()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"{Id}\t{Name}\t{Email}\t{Phone}\t{Address}");
            Console.WriteLine("=========================================");
            Console.WriteLine($"Customer ID: {Id}");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Customer Email: {Email}");
            Console.WriteLine($"Customer Phone: {Phone}");
            Console.WriteLine($"Customer Address: {Address}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
