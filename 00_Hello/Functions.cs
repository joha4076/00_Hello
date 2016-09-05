using System;

namespace _00_Hello
{
    public class Functions
    {
        public static string Hello()
        {
            return "Hello";
        }

        internal static object Hello(string v)
        {
            return "Hello, " + v;
        }
    }
}