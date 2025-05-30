using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        override public string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Quantity: {Quantity}, Price: {Price}";
        }
    }
}
