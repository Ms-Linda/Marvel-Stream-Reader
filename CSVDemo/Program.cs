using System;
using System.Collections.Generic;
using System.IO;

namespace CSVDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool foundFile = true;
            List<string> marvelCharacters = new List<string>();

            do
            {
                foundFile = true;

                Console.WriteLine("What file would you like to read?");
                var input = Console.ReadLine();




                try
                {
                    using (var reader = new StreamReader(input))
                    {

                        while (!reader.EndOfStream)
                        {

                            var line = reader.ReadLine();


                            marvelCharacters.Add(line);
                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("File not found. Please put in the right file name");
                    foundFile = false;

                }
             

            }while (foundFile == false);



            foreach (var hero in marvelCharacters)
            {
                Console.WriteLine(hero);
            }
   
        }
    }
}
