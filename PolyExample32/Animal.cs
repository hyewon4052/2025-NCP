using System;

namespace PolyExample32
{
    class Animal
    {

        private void Private() { }

        protected void Protected() { }
        public void Public() { }

        public void TestA()
        {
            Private();  // 같은 클래스 내에서는 private 호출 가능
            Protected();
            Public();
        }
        public int Age { get; set; }

        public Animal()
        {
            Age = 0;
        }

          
        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }
}