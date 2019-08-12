using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast M for en liste af Vulcan Male Navne");
            Console.WriteLine("Tast F for en liste af Vulcan Female Navne");
            switch (Console.ReadLine().ToUpper())
            {
                case "M":
                    Console.Clear();
                    foreach (string letter1 in new List<string>() { "S", "Sp", "Sk", "St", "T" })
                    {
                        foreach (string letter2 in new List<string>() { "a", "e", "i", "o", "u", "y" })
                        {
                            foreach (string letter3 in new List<string>() { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" })
                            {
                                foreach (string letter4 in new List<string>() { "a", "e", "i", "o", "u", "y" })
                                {
                                    foreach (string letter5 in new List<string>() { "q", "p", "k", "ck", "l" })
                                    {
                                        Console.WriteLine(letter1 + letter2 + letter3 + letter4 + letter5);
                                    }
                                }
                            }
                        }
                    }
                    foreach (string letter1 in new List<string>() { "S", "Sp", "Sk", "St", "T"})
                    {
                        foreach (string letter2 in new List<string>() { "a", "e", "i", "o", "u", "y" })
                        {
                            foreach (string letter3 in new List<string>() { "q", "p", "k", "ck", "l" })
                            {
                                Console.WriteLine(letter1 + letter2 + letter3);
                            }
                        }
                    }
                    break;
                case "F":
                    Console.Clear();
                    foreach (string letter1 in new List<string>() { "T'" })
                    {
                        foreach (string letter2 in new List<string>() { "P", "K", "Q"})
                        {
                            foreach (string letter3 in new List<string>() { "a", "e", "i", "o", "u", "y" })
                            {
                                foreach (string letter4 in new List<string>() { "r", "j", "'p", "k", "l" })
                                {
                                    Console.WriteLine(letter1 + letter2 + letter3 + letter4);
                                }
                            }
                        }
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
