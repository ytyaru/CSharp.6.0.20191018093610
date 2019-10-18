using System;

namespace cs6
{
    class CS6_1
    {
        public void Run()
        {
            var p = new Person1("Bill", "MMM", "Wagner");
            Console.WriteLine("The name, in all caps: " + p.AllCaps());
            Console.WriteLine("The name: " + p);
        }
    }
    public class Person1
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; } = "";

        public Person1(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public string AllCaps()
        {
            FirstName = FirstName.ToUpper();
            LastName = LastName.ToUpper();
            return ToString();
        }
    }
}
