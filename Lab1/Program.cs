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

                switch (choice)
                {
                    case "1":
                        ImportWordsFromFile();
                        break;
                    case "2":
                        BubbleSortWords();
                        break;
                    case "3":
                        LINQSortWords();
                        break;
                    case "4":
                        CountDistinctWords();
                        break;
                    case "5":
                        TakeLast50Words();
                        break;
                    case "6":
                        ReversePrintWords();
                        break;
                    case "7":
                        GetWordsEndingWithD();
                        break;
                    case "8":
                        GetWordsStartingWithR();
                        break;
                    case "9":
                        GetwordsLongerTHen3andStartsWithA();
                        break;
                    case "x":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invailt choice.Please try again");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void ImportWordsFromFile()
        {
            try
            {
                words.Clear();
                string[] lines = File.ReadAllLines("Words.txt");
                words.AddRange(lines.SelectMany(line => line.Split(' ')));
                Console.WriteLine($"Successfully imported{words.Count} words from file.");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex) {
            Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        static void BubbleSortWords()
        {
            IList<string> words = new List<string>(words);
            try
            {
                DateTime startTime = DateTime.Now;
                for (int i = 0;i<sortedwords.Count - 1; i++)
                {
                    for(int j = 0;j<sortedWord.Count - i - 1; j++)
                    {
                        if (string.Compare(sortedWords[j], sortedWords[j + 1]) > 0)
                        {
                            string temp = sortedWords[j];
                            sortedWords[j] = sortedWords[j + 1];
                            sortedWords[j + 1] = temp;
                        }
                    }
                }
                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime;
                Console.WriteLine($"Bubble sort complete. Sorted {sortedWords.Count}words.Time tkaen: {duration.TotalMilliseconds}ms");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
        }
        static void LINQSortWords()
        {

        }
    }
}