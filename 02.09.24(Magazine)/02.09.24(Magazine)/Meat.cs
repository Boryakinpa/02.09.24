using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09._24_Magazine_
{
    internal class Meat : Product
    {
        private int FilletPercentage { get; set; }
        internal override double Price
        {
            get
            {
                return base.Price * 0.9;
            }
        }
        public Meat(int filletPercentage = 0, double price = 0, string name = "no title")
        {
            FilletPercentage = filletPercentage;
            Price = price;
            Name = name;
        }

        internal override void GetInformation()
        {
            Console.WriteLine($"Product name: {Name}; Fillet percentage: {FilletPercentage}; Price: {Price}");
        }
    }
}
