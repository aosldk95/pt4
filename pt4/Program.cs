using System;
using System.Collections.Generic;

/*namespace pt4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(3, 4, 5));
            triangles.Add(new Triangle(3, 3, 3));
            int index = 1;
            foreach(Triangle shape in triangles)
            {
                shape.Draw(index);
                index++;
            }

            
        }
        
    }
    public class Triangle
    {
        private int A,B,C;

        //생성자
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        

        //속성


        //메서드
        public void Draw(int index)
        {
            double Sum = A + B + C;
            Console.WriteLine("삼각형{0} : A = {1}, B = {2}, C = {3}", index, A ,B, C) ;
            Console.WriteLine("둘레길이 : {0}", Sum);
        }

        
    }
}
*/
/*
namespace pt4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            double x = 20.5;
            double y = 10.5;
            Calculator cal = new Calculator();
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}",cal.Add(a, b), cal.Sub(a, b), cal.Mult(a, b), cal.Div(a,b));
            Console.WriteLine("a = {0}, b = {1}", x, y);
            Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}", cal.Add(x, y), cal.Sub(x, y), cal.Mult(x, y), cal.Div(x, y));
        }

    }
    public class Calculator
    {
        
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("무한");
                return 0;
            }
            else
            return a / b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("무한");
                return 0;
            }
            else
                return a / b;
        }
    }
}
*/
/*
namespace pt4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            double x = 20.5;
            double y = 10.5;
            Calculator2<int> cal = new Calculator2<int>();
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}", cal.Add(a, b), cal.Sub(a, b), cal.Mult(a, b), cal.Div(a, b));
            Calculator2<double> cal2 = new Calculator2<double>();
            Console.WriteLine("a = {0}, b = {1}", x, y);
            Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}", cal2.Add(x, y), cal2.Sub(x, y), cal2.Mult(x, y), cal2.Div(x, y));
        }

    }
    public class Calculator2<T>
    {
        public T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            dynamic Sum = da + db;
            return Sum;
        }
        public T Sub(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            dynamic Sum = da - db;
            return Sum;
        }
        public T Mult(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            dynamic Sum = da * db;
            return Sum;
        }
        public T Div(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            if (db == 0)
            {

                Console.WriteLine("무한");
                return a;
            }
            else
            {
                dynamic Sum = da / db;
                return Sum;
            }
        }
    }
}
*/
/*
namespace pt4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("마티즈");
            Console.WriteLine("시작시 속도 : {0}",car.Start());
            Console.WriteLine("엑셀 1단계 속도: {0}", car.Accelator());
            Console.WriteLine("엑셀 2단계 속도: {0}", car.Accelator()+10);
            Console.WriteLine("정지 후 속도: {0}",car.Stop());
        }

    }
    public class Car
    {
        private int speed;
        public string Name { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }

        public int Speed { get { return this.speed; } }

        public Car(string name)
        {
            Name = name;
        }
        public  int Start()
        {
            speed = 1;
            return speed;
        }
        public int Stop()
        {
            speed = 0;
            return speed;
        }
        public int Accelator()
        {
            speed += 10;
            return speed;
         
        }
        public int Break()
        {
            if (speed > 10)
            {
                speed -= 10;
                return speed;
            }
            else
            {
                speed = 0;
                return speed;
            }
            
        }
        
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] scores = { 90, 75, 85, 95, 70, 75, 85, 95, 72 };
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            double avg = sum / scores.Length;
            Console.WriteLine("점수 : {0}", string.Join<int>(",", scores));
            Console.WriteLine("합계 : {0}", sum);
            Console.WriteLine("평균 : {0}", avg);

        }
    }
}
*/
/*
 using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[ 5, 3 ] { { 90, 80, 90 }, { 85, 85, 85 }, { 95, 70, 75 }, { 80, 80, 90 }, { 90, 75, 80 } };
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = array[i, 0] + array[i, 1] + array[i, 2];
                avg = sum / 3;
                Console.WriteLine("ID={0} : 합계={1}, 평균={2}",i,sum, avg);
            }
        }
    }
}
*/
/*
 using System;

namespace pt
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                char t = s[i];
                if (char.IsUpper(t))
                {
                    Console.Write(char.ToLower(t));
                }
                else
                {
                    Console.Write(char.ToUpper(t));
                }

            }
        }
    }
}
*/
/*
 using System;

namespace pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                char t = s[i];
                int ascii = Convert.ToInt32(t);
                char code = Convert.ToChar(ascii + 3);
                Console.Write(code);
            }
        }
    }
}
*/
/*
 using System;

namespace pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/
/*
 using System;

namespace pt3
{
    class Program
    {
        static void Main(string[] args)
        {
            a = Console.ReadLine();
            b = Console.ReadLine();
            q = a( a, b);

        }
        static int a(int a int b)
        {
            int c = a + b;
            return c;
        }
        static int b(int a int b)
        {
            int c = a - b;
            return c;
        }
        static int c(int a int b)
        {
            int c = a * b;
            return c;
        }
        static int d(int a int b)
        {
            int c = a / b;
            return c;
        };
        }
    }
}
*/
