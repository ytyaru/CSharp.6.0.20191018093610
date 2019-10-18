using System;

namespace cs6
{
    class CS6_6
    {
        public void Run()
        {
            try 
            {
                string s = null;
                Console.WriteLine(s.Length);

            } catch (Exception e) when (LogException(e)) {}
            Console.WriteLine("Exception must have been handled");
        }
        private bool LogException(Exception e)
        {
            Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
            Console.WriteLine($"\tMessage: {e.Message}");
            return false;
        }
    }
}
