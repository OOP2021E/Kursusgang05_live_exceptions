using System;

namespace Exceptions
{
    class BadExamples
    {
        public int ParseTal(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    throw new NumberFormatException(s);
            }
            return int.Parse(s);
        }



        internal void Run(string p)
        {
            // DETTE ER IKKE MÅDEN!
            try
            {
                if(p == null)
                   throw new ArgumentNullException("p");
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        internal void REalRun(string p)
        {
                if (p == null)
                    Console.WriteLine("P is null");
        }
    }
}
