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

foreach (int num in ints)
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

// It is not possible to merge the arrays and keep them sorted in O(n) time.
// Combining the arrays and sorting them are both O(n) operations.
int[] array1 = { 1, 2, 3, 4, 5, 5, 6, 7, 5, 6, 9, 4, 2 };
int[] array2 = { 2, 5, 7, 9, 13, 9, 9, 13, 2 };
int[] merge = array1.Concat(array2).ToArray(); // Concat() will combine both arrays
Array.Sort(merge);
Console.WriteLine(String.Join(", ", merge));
/********************************/
/**** Reverse integer digits ****/
/********************************/

// The time complexity of this solution is O(n).
int number = 345;
string reversedNum = "";

for (int i = number.ToString().Length - 1; i >= 0; i--)
{
    reversedNum += number.ToString()[i];
}

Console.WriteLine(reversedNum);