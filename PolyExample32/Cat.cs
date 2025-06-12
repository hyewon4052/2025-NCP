using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample32
{
    class Cat : Animal
    {
        public new void Eat() { Console.WriteLine("냐미냐미 예쁘게 먹습니다."); }
        public new void Sleep() { Console.WriteLine("소근소근 잠을 잡니다."); }
        public void Meow() { Console.WriteLine("냥냥 웁니다.."); }
    }
}
