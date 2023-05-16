using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Lab1
{
     class Program
    {
        static IList<string> words = new List<string>();
        static void Main(string[] args)
        {
            bool exit=false;
            
            while(!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Import Words from File");
                Console.WriteLine("2 - Bubble Sort words");
                Console.WriteLine("3 - LINQ/Lambda sort words");
                Console.WriteLine("4 - Count the Distinct Words");
                Console.WriteLine("5 - Take the last 50 words");
                Console.WriteLine("6 - Reverse print the words");
                Console.WriteLine("7 - Get and display words that end with 'd' and display the count");
                Console.WriteLine("8 - Get and display words that start with 'r' and display the count");
                Console.WriteLine("9 - get and display words that are more then 3 characters long and start with the letter'a',display");
                Console.WriteLine("x - Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch(choice)
                {

                }
            }
        }
    }
}