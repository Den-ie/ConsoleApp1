using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("   Yasno");
            Console.Write("Числовведи - ");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Умноженане на 2: ");
            Console.WriteLine(b * 2);
            
            Console.ReadLine();
        }
    }
}
