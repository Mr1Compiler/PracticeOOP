using System;


namespace Practice
{
    class clsPerson
    {
        public string FirstName;
        public string LastName;

        public string FullName()
        {
            return FirstName + ' ' + LastName;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object from class
            clsPerson Person1 = new clsPerson();

            Person1.FirstName = "Ayman";
            Person1.LastName = "Asal";

            Console.WriteLine(Person1.FullName());

            Console.ReadKey();


        }
    }
}