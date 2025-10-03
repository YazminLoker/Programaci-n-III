using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i=0; i < args.Length; i++)
            {
                Console.WriteLine("orden: " + (i+1) +" " + args[i]);
            }
        }
    }
}
