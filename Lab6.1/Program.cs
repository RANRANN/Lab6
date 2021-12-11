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
            int resultstring = 0;
            foreach (string s in stringarray);
            {
                resultstring = stringarray[1].Length;
                if (max<resultstring)
                {
                    max = resultstring;
                }
            }
            /*for (int i=0,stringarray[].Length)
            {
                if (a>max)
                {
                    max = a;
                }
            }
            Console.WriteLine(max);
            /*n = stringarray[s.length];
            for (int i = 0; i < length; i++)
            {
                n = (n > s.length) ? n = n : n = s.length;
            } 
            n=Math.Max(array[i])
            Console.WriteLine(n);

            int max = array[0];
            foreach (int a in array);
            {
                if (a>max)
                max=a;
            }
            Console.WriteLine(max);
            Console.ReadKey();
             */
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
