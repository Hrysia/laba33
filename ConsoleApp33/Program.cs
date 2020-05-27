using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;



namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            string d;
            using (StreamReader f = new StreamReader("input.txt")) { d = f.ReadToEnd(); }
            Console.WriteLine(d);

            using (StreamWriter f = new StreamWriter("output.txt", true))
            {
                string[] words = d.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == "є" || words.Length == 1)
                    {
                        f.Write(words[i] + " ");
                    }
                    else
                    {
                        char[] chararray = words[i].ToCharArray();

                        if (chararray[0] != chararray[chararray.Length - 1])
                        {
                            f.Write(words[i] + " ");
                        }
                    }

                }

            }
        }
    }
}
