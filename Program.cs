using System;


namespace Practice
{
    class clsA
    {
        public int x1 = 10;
        private int x2 = 20;
        protected int x3 = 30;

        public int fun1()
        {
            return 100;
        }

        private int fun2()
        {
            return 200;
        }

        protected int fun3()
        {
            return 300;
        }
    }


    class clsB : clsA
    {

        // because it's protected so by inheritance clsA we can only access to public and protected
        // data members and functions;
        public int fun4()
        {
            return x1 + x3;
        }

        public int fun5()
        {
            return fun1() + fun3();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            clsA A = new clsA();

            Console.WriteLine(A.x1);
            Console.WriteLine(A.fun1());

            Console.ReadKey();
        }
    }
}