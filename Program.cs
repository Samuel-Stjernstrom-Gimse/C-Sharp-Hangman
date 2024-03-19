// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

string[] words =
{
    "programming", "computer", "algorithm", "software", "developer",
    "database", "internet", "keyboard", "mouse", "monitor",
    "network", "security", "application", "website", "javascript",
    "python", "java", "cplusplus", "html", "css",
    "ruby", "php", "swift", "mobile", "desktop",
    "server", "cloud", "framework", "debugging", "version",
    "control", "interface", "automation", "virtual", "reality",
    "machine", "learning", "artificial", "intelligence", "blockchain",
    "cryptocurrency", "bitcoin", "ethereum", "solidity", "node",
    "react", "angular", "vue", "typescript"
};

var random = new Random();
var randomNumber = random.Next(0, words.Length);
var selectedWord = words[randomNumber];
var letterList = new List<string?>();

do
{
    Console.WriteLine("");
    letterList.Add(Console.ReadLine());
    foreach (var letter in selectedWord)
    {
        if (letterList.Contains(letter.ToString()))
        {
            Console.Write(letter);
        }
        else
        {
            Console.Write("_");
        }

    }
} while (!IsWordGuessed(selectedWord, letterList));

return;

bool IsWordGuessed(string word, ICollection<string?> guesses)
{
    return word.All(letter => guesses.Contains(letter.ToString()));
}