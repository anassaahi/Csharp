using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("\t\t\t\t SHRITORI GAME");
            shritori g1 = new shritori();
            while (true)
            {
                Console.Write("Enter the word: ");
                word = Console.ReadLine();
                Console.WriteLine(string.Join(", ", (string[])g1.play(word)));
                if (g1.over)
                {
                    Console.Write("\n\n");
                    Console.Write(g1.restart());
                    Console.WriteLine("\n\n Press any key to restart.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
