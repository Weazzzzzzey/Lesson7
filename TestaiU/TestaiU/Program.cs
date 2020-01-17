using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaiU
{
    public class mokesciai
    {
        public decimal tax(decimal pajamos)
        {
            decimal result = 0;
            if (pajamos <= 40000)
            {
                result = pajamos * 0.05m;
            }
            else if (pajamos > 40000 && pajamos <= 100000)
            {
                result = pajamos * 0.15m;
            }
            else
            {
                result = pajamos * 0.25m;
            }

            return result;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            mokesciai m = new mokesciai();
            Console.WriteLine(m.tax(10000)); 
        }
    }
}
