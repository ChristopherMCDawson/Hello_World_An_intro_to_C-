/*Name: Christopher Decarie-Dawson
 *Student#: 040718315
 CST8359_300
 Lab1
 Author: Christopher Decarie-Dawson
 Release:1.0
 Date:2023/05/16
*/

/*
 The purpose of this program is to take in data  from a word.txt file
then sort and miluate the data from a menu displayed on the console.
Doing this within the C# framework , without the (framewroks).

All methods outside of Main have been try/catched with error handling.
 
 */

using ServiceStack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
// declaring the namespace as lab1
namespace Lab1
{
    class Program
    {
     
        // the Main method which holds the menu and the switch cases for the menu options , which in turns calls the other methods.
        static void Main(string[] args)
        {
            bool exit = false;
            // runs till an Exit call
            while (!exit)
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
                Console.WriteLine("9 - Get and display words that are more than 3 characters long and start with the letter 'a'");
                Console.WriteLine("x - Exit");

                Console.Write("Enter your choice: ");
                // takes user input into the Switch case.
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        readFile();
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
                        GetWordsLongerThan3AndStartsWithA();
                        break;
                    case "x":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
                Console.WriteLine();
            }
        }
        // This Method is used to Read or import the Words.txt file into the program for use.
        static IList<string> readFile()
        {
            try
            { // creates a List and then reads the file and adds the words to the List.
                IList<string> words;
                words = System.IO.File.ReadAllLines(@".\Words.txt");
                int Count = 0;
                Count = words.Count;
                foreach (string line in words)
                {  // Increase the count so that it can go to the next word.
                    Count++;
                }
                Console.WriteLine($"Successfully imported {words.Count} words from file.");
                return words;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        // This method Sorts the words on the Imported file in the Bubblesort style and displays the compu time in mills.
        static void BubbleSortWords()
        {
            try { 
            // Bubble sorts
                List<string> sortedWords = new List<string>(Words);
                // begin the time recorded for sorting time.
                DateTime startTime = DateTime.Now;

                for (int i = 0; i < sortedWords.Count - 1; i++)
                {
                    for (int j = 0; j < sortedWords.Count - i - 1; j++)
                    {
                        if (string.Compare(sortedWords[j], sortedWords[j + 1]) > 0)
                        {
                            string temp = sortedWords[j];
                            sortedWords[j] = sortedWords[j + 1];
                            sortedWords[j + 1] = temp;
                        }
                    }
                }
                // Closes the time record for sorting time.
                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime;

                Console.WriteLine($"Bubble sort complete. Sorted {sortedWords.Count} words. Time taken: {duration.TotalMilliseconds} ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        // This Method sorts the words on the Imported file in the lamda sort style and outputs the compu tim in mills.
        static void LINQSortWords()
        {
            try
            {
                List<string> sortedWords = new List<string>(words);

                DateTime startTime = DateTime.Now;
                // Lamda  doing it's thing for very very quick sorting.
                sortedWords = sortedWords.OrderBy(w => w).ToList();

                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime; Console.WriteLine($"LINQ sort complete. Sorted {sortedWords.Count} words. Time taken: {duration.TotalMilliseconds} ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        // This Method counts up the distinct words with in the file and outputs the total.
        static void CountDistinctWords()
        {
            try
            {   // Simple count ofthe words which are distinct.
                int distinctCount = words.Distinct().Count();
                Console.WriteLine($"Distinct words count: {distinctCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        // This Method Displays the last 50 words with in the file.
        static void TakeLast50Words()
        {
            try { 
                // targetting the last 50 words for displaying.
                List<string> last50Words = words.TakeLast(50).ToList();
                Console.WriteLine("Last 50 words:");
                foreach (string word in last50Words)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        // This Method displays the whole list of words from the file in reverse order.
        static void ReversePrintWords()
        {
            try
            {   // Taking the order of the list and then Reversing the order and print it out.
                List<string> reversedWords = words.Reverse().ToList();
                Console.WriteLine("Words in reverse order:");
                foreach (string word in reversedWords)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        // This Method finds the words ending with the letter D and then displays them.
        static void GetWordsEndingWithD()
        {
            try
            {   // quick serah for words ending with d.
                List<string> wordsEndingWithD = words.Where(w => w.EndsWith("d")).ToList();
                Console.WriteLine($"Words ending with 'd' ({wordsEndingWithD.Count}):");
                foreach (string word in wordsEndingWithD)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        // This Method finds the words starting with the letter R and then displays them.
        static void GetWordsStartingWithR()
        {
            try
            {   // Quick seach for words starting with  'r' and displaying them.
                List<string> wordsStartingWithR = words.Where(w => w.StartsWith("r")).ToList();
                Console.WriteLine($"Words starting with 'r' ({wordsStartingWithR.Count}):");
                foreach (string word in wordsStartingWithR)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        // This Method finds the words Starting with the letter A and which are also longer then Three letters and displays them.
        static void GetWordsLongerThan3AndStartsWithA()
        {
            try
            {   // Seachs the file for words the start with the letter 'a' && that are more then 3 letters long.
                List<string> wordsLongerThan3AndStartsWithA = words.Where(w => w.Length > 3 && w.StartsWith("a")).ToList();
                Console.WriteLine($"Words longer than 3 characters and starting with 'a' ({wordsLongerThan3AndStartsWithA.Count}):");
                foreach (string word in wordsLongerThan3AndStartsWithA)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

