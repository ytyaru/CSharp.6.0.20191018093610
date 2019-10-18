using System;

namespace cs6
{
    class CS6_2
    {
        public void Run()
        {
            var p = new Person2("Bill", "MMM", "Wagner");
            Console.WriteLine("The name, in all caps: " + p.AllCaps());
            Console.WriteLine("The name: " + p);
        }
    }
    public class Person2
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; } = "";

        public Person2(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }
        public string AllCaps()
        {
            FirstName = FirstName.ToUpper();
            LastName = LastName.ToUpper();
            return ToString();
        }
        public override string ToString() => FirstName + " " + LastName;
    }
}
