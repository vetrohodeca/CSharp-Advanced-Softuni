using System;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        public Person()
        {
            Name = name;
            Age = age;
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                Age = age;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Name = name;
            }
        }
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(string Name)
        {
            this.Name = name;
        }
        public Person( string Name, int Age) :this(Age)
        {
            
            this.Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pesho";
            int age = 21;
            Person Pesho = new Person(name, age);
            Console.WriteLine();

        }
    }
}
