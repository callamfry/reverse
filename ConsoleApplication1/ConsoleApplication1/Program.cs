using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("please enter a word");



           string input = Console.ReadLine();
            string reverse = "";
            int i;
            for (i = 0; i < input.Length; i++)
            {
                reverse = input[i] + reverse;
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
