/*
 * Lab 3 
 * Gabriel Nicholauson
 * 
 * Complexity
 * This program will:
 * - Find all duplicate elements in an array
 * - Combine two arrays and sort them
 * - reverse the digits of an integer
 * 
*/

/*********************************************/
/**** Find recurring numbers in O(n) time ****/
/*********************************************/
int[] ints = new int[] { 1, 2, 3, 4, 7, 9, 2, 4 };
string trackedNums = "";
string recurringNums = "";

foreach(int num in ints)
{
    if (!trackedNums.Contains(num.ToString()))
    {
        trackedNums += num.ToString() + ' ';
    } else if (!recurringNums.Contains(num.ToString()))
    {
        recurringNums += num.ToString() + " ";
    }
}

Console.WriteLine(recurringNums);

/**************************************/
/**** Combine arrays and sort them ****/
/**************************************/