using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startstring = Console.ReadLine();
            string S = string.Concat(startstring.ToLower());
            string s = Convert.ToString(S.Reverse());
            if (String.Compare(S, s) == 1)
            {
                Console.WriteLine("Введённое предложение является полиндромом");
            }
            Console.WriteLine("Введённое предложение не является полиндромом");
            Console.ReadKey();

        }
    }
}
