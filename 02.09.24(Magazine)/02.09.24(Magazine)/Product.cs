using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09._24_Magazine_
{
    internal abstract class Product
    {
        private int Count { get; set; }
        private int Weight { get; set; }
        internal virtual double Price { get; set; }
        internal string Name { get; set; }

        internal abstract void GetInformation();
    }
}
