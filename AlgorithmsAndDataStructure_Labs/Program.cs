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
List<int> ints = new() { 13, 1, 2, 3, 4, 7, 9, 2, 4, 13 };
HashSet<int> trackedNums = new HashSet<int>(); // Tracks unique nums
string recurringNums = ""; // tracks the recurring nums

foreach (int num in ints)
{
    if (!trackedNums.Contains(num)) // Contains on a HashSet is O(1) time
    {
        trackedNums.Add(num);
    } else
    {
        recurringNums += num + " ";
    }
}
Console.WriteLine(recurringNums.Trim());

/**************************************/
/**** Combine arrays and sort them ****/
/**************************************/

// It is not possible to merge the arrays and sort them in O(n) time.
// sorting arrays is O(n log n) or O(n^2) time.
int[] array1 = { 1, 2, 3, 4, 5, 5, 6, 7, 5, 6, 9, 4, 2 };
int[] array2 = { 2, 5, 7, 9, 13, 9, 9, 13, 2 };
int[] merge = array1.Concat(array2).ToArray(); // Concat() will combine both arrays
Array.Sort(merge); // sorts in O(n log n) time
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