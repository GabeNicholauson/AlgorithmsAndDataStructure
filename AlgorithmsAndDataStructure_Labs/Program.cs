/*
 * Lab 2
 * Gabriel Nicholauson
 * 
 * This program will take a string, return all the letters that appear more than once, return 
 * all unique words, reverse the string and return the longest word.
*/

using System.Text;
string example = "Today I will eat ceareal, watch a movie and shovel my driveway.";
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


/************************/
/**** Reverse String ****/
/************************/

for (int i = example.Length - 1; i >= 0; i--)
{
    sb.Append(example[i]);
}

Console.WriteLine(sb.ToString());