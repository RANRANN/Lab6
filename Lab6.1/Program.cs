using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startstring = Console.ReadLine();
            string[] stringarray = startstring.Split();
            int max = stringarray[0].Length;
            foreach (string s in stringarray)
            {
                Console.Write("{0} ", s.Length);
                if (max >= s.Length)
                {
                    max = max;
                }
                else 
                {
                    max = s.Length;
                }
            }
            Console.WriteLine();
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
