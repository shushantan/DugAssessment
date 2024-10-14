using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubDirectoriesCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;
            int count = 0;

            do {
                if (count != 0)
                {
                    Console.WriteLine("Path must start with / and cannot be empty!");
                }
                Console.Write("Enter a path (s1): ");
                s1 = Console.ReadLine();
                count++;
            } while (!isValidInput(s1));

            count = 0; // reset
            do
            {
                if (count != 0)
                {
                    Console.WriteLine("Path must start with / and cannot be empty!");
                }
                Console.Write("Enter a path (s2): ");
                s2 = Console.ReadLine();
                count++;
            } while (!isValidInput(s2)); 

            try
            {
                var result = Program.IsSubDirectories(s1, s2);
                Console.WriteLine("Is S2 ({0}) a subdirectory of S1 ({1})?", s2, s1);
                Console.WriteLine("Answer: {0}", result);
                Console.ReadLine();

            } catch (Exception ex)
            {
                Console.WriteLine("Error {0}", ex.Message);
                Console.ReadLine();
            }

        }
        
        public static bool IsSubDirectories(string s1, string s2) 
        {
            if (s1.Equals(s2))
            {
                return true;
            }

            var listOfDirectoryS1 = s1.Split('/').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var listOfDirectoryS2 = s2.Split('/').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var rootDirectoryOfS2 = listOfDirectoryS2.FirstOrDefault();

            if (rootDirectoryOfS2 == null) { return false; }
            
            if (s1.Length == 1 && listOfDirectoryS2.Count > 0 ){ return true; }

            foreach ( var item in listOfDirectoryS1)
            {
                if (item == rootDirectoryOfS2)
                { return true; }

            }
            return false;
        
        }

        private static bool isValidInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || !Path.IsPathRooted(input))
            {
                return false;
            }
            return true;
        }

    }
}
