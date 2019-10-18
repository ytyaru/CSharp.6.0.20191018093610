using System;

namespace cs6
{
    class CS6_0
    {
        public void Run()
        {
            var p = new Person0("Bill", "Wagner");
            Console.WriteLine("The name, in all caps: " + p.AllCaps());
            Console.WriteLine("The name: " + p);
        }
    }
    public class Person0
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person0(string first, string last)
        {
            FirstName = first;
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
