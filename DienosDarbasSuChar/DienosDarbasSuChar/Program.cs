using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienosDarbasSuChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';
            int i = (int)c;
            Console.WriteLine("i - {0}",i);
            i++;

            c = (char)i;

            Console.WriteLine("c - {0}",c);
            Console.ReadLine();

        }
    }
}
