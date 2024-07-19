using System;


namespace Practice
{
    class clsPerson
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson(int Id, string Name, short Age)
        {
            this.ID = Id;
            this.Name = Name;
            this.Age = Age;
        }

    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson(1, "Ayman", 22);

            Console.WriteLine($"ID = {Person1.ID} \nName = {Person1.Name} \nAge = {Person1.Age}");

            Console.ReadKey();
        }
    }
}