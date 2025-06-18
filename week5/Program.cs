using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    internal class Program
    {
        public static string a;
        static int add(int x, int y)
        {
            int value = 0;
            for (int i = x; i < y; i++)
            {
                value += i;
            }

            return value;
        }
        static string add(string x, int y)
        {
            return x + y.ToString();
        }
        static void Main(string[] args)
        {
            string a = add("Hello", 11327015);
            int b = add(60, 70);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Read();

        }
    }
}
