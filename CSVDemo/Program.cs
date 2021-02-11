using System;
using System.Collections.Generic;
using System.IO;

namespace CSVDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Marvel.csv"))
            {
                List<string> myFile = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();


                    myFile.Add(line);

                }
                foreach (var item in myFile)
                {
                    Console.WriteLine(item);
                }
            }
               
        }
    }
}
