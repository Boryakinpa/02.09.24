using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09._24_Magazine_
{
    internal class Drinks : Product
    {
        private int Alcoholism { get; set; }
        internal override double Price
        {
            get
            {
                return base.Price * 0.95;
            }
        }
        public Drinks(int alcoholism = 0, double price = 0, string name = "no title")
        {
            Alcoholism = alcoholism;
            Price = price;
            Name = name;
        }

        internal override void GetInformation()
        {
            Console.WriteLine($"Product name: {Name}; Alcoholism: {Alcoholism}%; Price: {Price}");
        }
    }
}
