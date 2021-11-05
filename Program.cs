using System;
using System.Collections.Generic;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            /*
            int x = 5; 
            int X = 50;
            var y = 5;
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} !"); // ("Hello" + name + "!")
            Console.WriteLine("Yo");
            
            string x = "Ariana";
            Console.WriteLine(x + " is not weird");

            Program myProgram = new Program();
            myProgram.Print();
            
            int x = 5;
            int? y = null;
            Console.WriteLine(y);
            
            int a = -5;
            uint b = 5;
            char c = 'c';
            float d = 5.5F;
            double e = 5.5;
            decimal f = 5.5M;
            bool g = true;
            string h = "Hello";
            
            int a = -5;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            int[] a = { -5 };
            int[] b = a;
            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);
            b[0] = 10;
            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);
            
            int[] a = { -5 };
            Console.WriteLine(a[0]);
            Test(a);
            Console.WriteLine(a[0]);
            
            Int32 x = 5;
            string y = "Ariana"
            
            int x = (int)5.99;
            double y = 5;
            Console.WriteLine(x);
            */
            //float x = 5.5f;
            double y = 5.5;
            decimal x = 10.5M;
            double a = double.NaN;
            //double b = double.PositiveInfinity;
            double b = Math.Pow(9999, 99999999999);
            Console.WriteLine(double.IsInfinity(b));


        }
        static void Test(int[] x)
        {
            x[0] = 100;
        }
        void Print()
        {
            Console.WriteLine("Hey");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Best friend!");
        }

    }
}
