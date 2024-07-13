using System;
using System.Runtime.Intrinsics.X86;


namespace Practice
{
    class clsA
    {
        public int x1;
        public static int x2;

        public int Method1()
        {
            return x1 + x2;
        }
        public static int Method2()
        {
            // we can not access non static member or variable from a static method
            // because the sattic is shareed 
            return x2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsA A = new clsA();
            clsA B = new clsA();

            A.x1 = 10;
            B.x1 = 20;
            // A.x2 = 100; can not access the static member through an object
            // we can access it through class like this: 

            clsA.x2 = 20;

            Console.WriteLine(A.Method1());
            Console.WriteLine(B.Method1());

            Console.WriteLine(clsA.Method2());

            Console.ReadKey();
        }
    }
}