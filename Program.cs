using System;


namespace Practice
{

    class clsEmployee
    {
        private int _ID;
        private string _name;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                clsEmployee Employee1 = new clsEmployee();

                Employee1.ID = 4;
                Employee1.Name = "Ayman";

                Console.WriteLine($"Employee ID = {Employee1.ID}");
                Console.WriteLine($"Employee Name = {Employee1.Name}");


                Console.ReadKey();
            }
        }
    }
}