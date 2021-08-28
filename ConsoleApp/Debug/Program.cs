using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine(Calc(x, y));
        }

        public static int Calc(int x, int y)
        {
            return x + y;
        }
    }
}
