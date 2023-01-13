/*
 * Lab 2
 * Gabriel Nicholauson
 * 
 * This program will take a string, return all the letters that appear more than once, return 
 * all unique words, reverse the string and return the longest word.
*/

using System.Collections.Immutable;

string example = "San'. santa is{comin'n.} comin to to town"; // String used in each section

/******************************/
/**** Recurring Characters ****/
/******************************/
string recurringChars = ""; // Tracks chars that appear more than once
string chars = ""; // Tracks all unique chars used in the string

foreach(char c in example)
{
    if (!chars.Contains(c)) // if the char is not used yet
    {
        chars += c;
    } else if (chars.Contains(c) && !recurringChars.Contains(c)) // If that char was used already but not tracked
    {
        recurringChars += c; // It is recurring
    }
}
char[] allDuplicateChars = recurringChars.ToCharArray(); // Array to store the recurring chars
Array.Sort(allDuplicateChars);
Console.WriteLine(String.Join(", ", allDuplicateChars)); // Output array

/**********************/
/**** Unique Words ****/
/**********************/
string words = ""; // Tracks unique words
string buildWord = "";

for (int i = 0; i < example.Length; i++)
{
    if (char.IsLetter(example[i]) || example[i] == '\'') // Keeps words with apostrophies intact
    {
        buildWord += example[i]; // builds the word
    } else if (!words.Contains(buildWord)) // If that word isn't tracked yet
    {
        words += buildWord + " ";
        buildWord = "";
    } else
    {
        buildWord = "";
    }
}

if (buildWord.Length > 0) // Just in case there isn't any punctuation at the end of the string
{
    words += buildWord + " ";
}

Console.WriteLine(words);

/************************/
/**** Reverse String ****/
/************************/
string reversed = "";

for (int i = example.Length - 1; i >= 0; i--) // Goes backwards through the string
{
    reversed += example[i];
}

Console.WriteLine(reversed);

/**********************/
/**** Longest Word ****/
/**********************/
string[] allWords = example.Split(' '); // Puts all words into an array
string longestWord = ""; // Tracks the longest word

/*
 * I only seperate by spaces incase there is a word with punctuation such as an apostrophy.
 * I would like to keep those intact and not have an array of delimiters that make up
 * half my keyboard.
*/
foreach (string word in allWords)
{
    string currentWord = ""; // Tracks my current word. sb didn't work here
    foreach (char c in word)
    {
        if (char.IsLetter(c) || c == '\'') // keeps words with spostrophies intact
        {
            currentWord += c;
        } else // In case there is punctuation between two words.
        {
            if (currentWord.Length >= longestWord.Length) // Checks if the word is longer
            {
                longestWord = currentWord;
            }
            currentWord = ""; // resets the current word
        }

    }
    if (currentWord.Length >= longestWord.Length)
    {
        longestWord = currentWord;
    }
}

Console.WriteLine(longestWord);