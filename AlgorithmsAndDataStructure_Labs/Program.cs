/*
 * Lab 2
 * Gabriel Nicholauson
 * 
 * This program will take a string, return all the letters that appear more than once, return 
 * all unique words, reverse the string and return the longest word.
*/

using System.Text;

string example = "Today I will eat cereal, watch a movie, and then shovel my driveway.";

/**** Reverse String ****/

StringBuilder sb = new StringBuilder();

for (int i = example.Length - 1; i >= 0; i--)
{
    sb.Append(example[i]);
}
Console.WriteLine(sb.ToString());