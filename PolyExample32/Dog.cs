using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample32
{
    class Dog : Animal
    {

        public int Color { get; set; }

        public void Bark() { Console.WriteLine("왈왈 짖습니다..");  }
    }
}
