using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {

        //method 연습
        int Sqr(int x)
        {
            int result = x * x;
            return result;
        }

        static void SayHi()
        {
            Console.WriteLine("Hello");
        }


        void MyFunc(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);
        }

        static void Print(int x)
        {
            Console.WriteLine(x);

        }
        static void Func(int x)
        {
            Console.WriteLine(x * 2);
        }
        
        //자료형 타입을 각각의 인수 앞에 작성해주어야 함.
        /*
        static int Sum(int x, int y)
        {
            return x + y;
        }
        */

        static int Pow(int x, int y)
        {
            int result = 1;
            for(int i=0; i<y; i++)
            {
                result*= x;
            }

            return result;
        }

        static int Area(int h, int w)
        {
            return h * w;
        }

        
        // 값으로 지정 passing by value
        static void sqr(int x)
        {
            x = x * x;
        }

        // 주소로 지정 passing by reference
        static void other_sqr(ref int x)
        {
            x = x * x;
        }

        //출력 데이터로 지정 passing by output
        static void GetValue(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
 
        static void Main(string[] args)
        {
            SayHi();
            SayHi();
            SayHi();

            Print(27);

            Func(10);
            Func(50);

            //Console.WriteLine(Sum(8, 6));

            Console.WriteLine(Pow(2, 3));

            //int res = Arwa(8, 5)로 해도 에러는 발생하지 않음. 표기상 아래가 더 직관적이고 자리 바꾸기 가능. 더 편한 듯.
            int res = Area(w:8, h:5);
            Console.WriteLine(res);

            // value 값을 사용하면, sqr메소드에 적용되지 않고 그냥 지나침. 
            int a = 3;
            // sqr(a);

            //reference 주소를 이용하면 메소드에 적용됨.
            other_sqr(ref a);

            //output적용
            int c, d;

            // c=5, d=42
            GetValue(out c, out d);

            

            Console.WriteLine(a);

            
            
            
            
            

        }
    }
}
