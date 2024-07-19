using System;


namespace Practice
{
    class clsPerson
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson()
        {
            ID = -1;
            Name = "Empty";
            Age = 0;
        }

    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson();

            Console.WriteLine($"ID = {Person1.ID} \nName = {Person1.Name} \nAge = {Person1.Age}");

            Console.ReadKey();
        }
    }
}