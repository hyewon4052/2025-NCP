using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propExample
{
    class Item
    {
        private static int count;
        public readonly int Id;
        public string Name;
        public int price;
        public Item(string name, int price)
        {
            Id = count++;
            this.Name = name;
            this.price = price;

        }
    }
}
