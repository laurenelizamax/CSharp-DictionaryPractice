using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            // Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // // Add several more words and their definitions
            // wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            // wordsAndDefinitions.Add("Sleepy", "Starts at 330 every day");
            // wordsAndDefinitions.Add("McGarrett", "The best dog in the world");
            // wordsAndDefinitions.Add("Bed", "A very comfortable place");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {
            //     Console.WriteLine($"the definition of {word.Key} is {word.Value}");

            // }

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();
            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();
            Dictionary<string, string> funWord = new Dictionary<string, string>();
            Dictionary<string, string> dogWord = new Dictionary<string, string>();

            // // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "energy and enthusiasm");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("sentence", "I am excited to learn C#!");

            funWord.Add("word", "fun");
            funWord.Add("defition", "enjoyable");
            funWord.Add("part of speech", "adjective");
            funWord.Add("sentence", "That was fun.");

            dogWord.Add("word", "dog");
            dogWord.Add("definition", "not a cat");
            dogWord.Add("part of speech", "noun");
            dogWord.Add("sentence", "I love my dog");


            // Add Dictionary to your `dictionaryOfWords` list

            dictionaryOfWords.Add(excitedWord);
            dictionaryOfWords.Add(funWord);
            dictionaryOfWords.Add(dogWord);

            // create another Dictionary and add that to the list


            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (var word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (var item in word)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
