/*
 * Lab 2
 * Gabriel Nicholauson
 * 
 * This program will take a string, return all the letters that appear more than once, return 
 * all unique words, reverse the string and return the longest word.
*/

using System.Text;
string example = "Santa santa my man my";
StringBuilder sb = new StringBuilder();

/******************************/
/**** Recurring Characters ****/
/******************************/
string recurringChars = "";

foreach(char c in example)
{
    string sbString = sb.ToString();
    if (!sbString.Contains(c))
    {
        sb.Append(c);
    } else if (sbString.Contains(c) && !recurringChars.Contains(c) && char.IsLetter(c))
    {
        recurringChars += c;
    }
}

sb.Clear();
char[] allDuplicateChars= new char[recurringChars.Length];

for (int i = 0; i < recurringChars.Length; i++)
{
    allDuplicateChars[i] = recurringChars[i];
}

Console.WriteLine(String.Join(", ", allDuplicateChars));

/**********************/
/**** Unique Words ****/
/**********************/
string words = "";

for (int i = 0; i < example.Length; i++)
{
    if (char.IsLetter(example[i]))
    {
        sb.Append(example[i]);
    } else if (!words.Contains(sb.ToString()))
    {
        words += sb.ToString() + " ";
    } 

    if (words.Contains(sb.ToString()))
    {
        sb.Clear();
    }
}

if (sb.Length > 0)
{
    words += sb.ToString() + " ";
}

Console.WriteLine(words);
sb.Clear();

/************************/
/**** Reverse String ****/
/************************/

for (int i = example.Length - 1; i >= 0; i--)
{
    sb.Append(example[i]);
}

Console.WriteLine(sb.ToString());
sb.Clear();

/**********************/
/**** Longest Word ****/
/**********************/

char[] delimiters = new char[] {' ', '.', '?', '!'};
string[] allWords = example.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
string longestWord = "";

foreach (string word in allWords)
{
    string currentWord = "";
    foreach (char c in word)
    {
        if (char.IsLetter(c))
        {
            currentWord += c;
        }
    }

    if (currentWord.Length >= longestWord.Length)
    {
        longestWord = currentWord;
    }
}

Console.WriteLine(longestWord);