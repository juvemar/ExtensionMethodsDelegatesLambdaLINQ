using System;
using System.Text;

namespace Substring
{
    static class SubstringStringBuilder
    {
        static void Main()
        {
            string str = "I trying to learn smth..";
            string substringed = str.Substring(8);
            Console.WriteLine(@"After the substring we have only ""{0}"".", substringed);

            string substringLength = str.Substring(8, 9);
            Console.WriteLine(@"After the substring with specified length we have ""{0}"".", substringLength);
        }

        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder builder = new StringBuilder();
            string toString = sb.ToString();
            builder.Append(toString.Substring(index, length));

            return builder;
        }

        public static StringBuilder Substring(this StringBuilder sb, int index)
        {
            StringBuilder builder = new StringBuilder();
            string toString = sb.ToString();
            builder.Append(toString.Substring(index));

            return builder;
        }
    }
}
