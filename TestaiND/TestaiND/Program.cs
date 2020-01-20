using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaiND
{
    public class Uzduotis
    {
        private string Versim = "qwerty";
        public string Apvertimas(string qwerty)
        {
            string apvertas = "";
            char[] tempV = qwerty.ToArray();
            for (int i = tempV.Length-1; i >= 0; i--)
            {
                apvertas = apvertas + tempV[i];
            }

            return apvertas;

        }

        public bool lyginis(int lygus)
        {
            if (lygus % 2 == 0)
            {
                return true;
            }
            else return false;
        }


    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Uzduotis a = new Uzduotis();
            Console.WriteLine(a.Apvertimas("qwerty"));
            Console.ReadLine();
        
        }
    }
}
