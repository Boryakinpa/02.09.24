using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09._24_Magazine_
{
    internal class Toy : Product
    {
        internal int Age { get; set; }
        internal override double Price
        {
            get
            {
                return base.Price * 0.7;
            }
        }

        public Toy(int age = 0, double price = 0, string name = "no title")
        {
            Age = age;
            Price = price;
            Name = name;
        }

        internal override void GetInformation()
        {
            Console.WriteLine($"Product name: {Name}; Age playing: {Age}; Price: {Price}");
        }
    }
}
