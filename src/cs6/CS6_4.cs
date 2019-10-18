using System;
using System.Linq;
using static System.Console;

namespace cs6
{
    class CS6_4
    {
        public void Run()
        {
            var p = new Person4("Bill", "MMM", "Wagner");
            WriteLine($"The name, in all caps: {p.AllCaps()}");
            WriteLine($"The name is: {p}");

            var phrase = "the quick brown fox jumps over the lazy dog";
            var wordLength = from word in phrase.Split(' ') select word.Length;
            var average = wordLength.Average();
            WriteLine(average);
            WriteLine($"The average word length is: {wordLength.Average()}");
            WriteLine($"The average word length is: {wordLength.Average():F2}");
        }
    }
    public class Person4
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; } = "";
        public Person4(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }
        public override string ToString() => $"{FirstName} {LastName}";
        public string AllCaps() => ToString().ToUpper();
    }
}
