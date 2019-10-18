using System;
using System.Linq;
using static System.Console;

namespace cs6
{
    class CS6_5
    {
        public void Run()
        {
            string s = null;
//            Console.WriteLine(s.Length); // NullReferenceException 
            Console.WriteLine(s?.Length); // 左オペランドがnullなら?はnullを返す

            char? c = s?[0];
            Console.WriteLine(c.HasValue);

            bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext();
            Console.WriteLine(hasMore.HasValue);

            hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            Console.WriteLine(hasMore);
        }
    }
}
