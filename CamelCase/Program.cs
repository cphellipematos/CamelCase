using System;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = CamelCase(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        protected static int CamelCase(string s)
        {
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == s[i].ToString().ToUpper())
                    count++;
            }
            return count;
        }
    }
}
