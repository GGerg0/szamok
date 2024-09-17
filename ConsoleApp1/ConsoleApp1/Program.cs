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
            int szam = Convert.ToInt32(Console.ReadLine());
            switch (szam)
            {
                case 3: Console.WriteLine("Osztható 3-mal"); break;
                case 6: Console.WriteLine("Osztható 3-mal"); break;
                case 9: Console.WriteLine("Osztható 3-mal"); break;
                case 12: Console.WriteLine("Osztható 3-mal"); break;
                case 15: Console.WriteLine("Osztható 3-mal"); break;
                case 18: Console.WriteLine("Osztható 3-mal"); break;
                default: Console.WriteLine("Nem osztható 3-mal"); break;
            }
            Console.ReadKey();
        }
    }
}
