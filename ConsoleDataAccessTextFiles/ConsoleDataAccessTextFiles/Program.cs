using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleDataAccessTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\donal\OneDrive\Documents\Git Repositories\CSharp\DotNet\ConsoleDataAccessTextFiles\ConsoleDataAccessTextFiles\Test.txt";

            // File.ReadAllLines(filePath) returns array of strings.  Change to List of strings to add and remove strings easier.
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // Add to list of strings.
            lines.Add("This line was added.");

            // Write all lines from the List lines to file path.
            File.WriteAllLines(filePath, lines);

            // Keep Console Window Open
            Console.ReadLine();
        }
    }
}
