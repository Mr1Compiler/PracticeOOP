using System;


namespace Practice
{
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