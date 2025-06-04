using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propExample
{
    class Program
    {
        public static int classVar = 0;
        static void Main(string[] args)
        {
            // 클래스 변수 호출
            Program.classVar = -1;

            // 인스턴스 변수처럼 클래스 변수 사용 불가에 주의 (자바에서는 OK)
            //Program p = new Program();
            //p.classVar

            // 생성자
            //기본(기정) 생성자 - 생성자를 하나라도 정의하면 기본 생성자를 따로 작성해주어야 함
            //Product p = new Product();

            // 팩토리 메서드 패턴 ( 생성자에 private을 사용하는 경우 )
            Product p = Product.GetInstance("아아", 2940);

            // 정적 생성자 예제
            Console.WriteLine("첫번 째 위치");
            Console.WriteLine("두번 째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세번 째 위치");
            Console.WriteLine(Sample.value);

            //Math m = MyMath();
        



            // Property 실습
            Box box1 = new Box(100, 200);
            box1.Width = -3;
            Console.WriteLine(box1.Width);
            Console.WriteLine(box1.Area);

            // 값 복사
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine(a);   // a와 b가 별개 변수

            // 참조복사 
            Test test = new Test();
            test.value = 5;
            Change(test);   // 레퍼런스를 넘김에 주의
            Console.WriteLine(test.value);

            Test testA = new Test();
            Test testB = testA;         // A와 B는 같은 걸 가리킨다.
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine(testA.value);
        }
        
        class Test
        {
            public int value = 10;
        }
        static void Change(Test input)  // 메인 메소드와 같은 위치. 레퍼런스를 매개변수로 받음
        {
            input.value = 20;
        }
    }
}
