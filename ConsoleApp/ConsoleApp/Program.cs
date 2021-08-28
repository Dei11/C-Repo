using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mydll;
using System.Threading;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Hey");
            Console.ReadLine();
        }

        public static async void Method()
        {
            await Task.Run(() => LongMethod());
            Console.WriteLine("New Thread");
        }

        public static void LongMethod()
        {
            Thread.Sleep(2000);
            Console.WriteLine("This is a long method...");
        }
    }
}