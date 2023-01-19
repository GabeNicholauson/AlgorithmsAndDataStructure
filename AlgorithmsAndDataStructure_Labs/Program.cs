/*
 * Lab 4
 * Gabriel Nicholauson
 * 
 * This program will do 3 things:
 * - Take a list of lists of ints and return a list with the highest number in each list.
 * - Take a list of lists of ints and return the highest number out of all the lists,
 *   the list and index it was found in.
 * - orders a list of ints from lowest to highest.
*/
using System;
using System.Collections.Generic;
using System.Linq;

/**********************************/
/**** Highest int in each list ****/
/**********************************/

// The time complexity of this solution is O(n^2)
List<List<int>> maxNumberInLists = new()
{
    new List<int>(){ 1, 5, 3 },
    new List<int>(){ 9, 7, 3, -2 },
    new List<int>(){ 2, 1, 2 }
};

List<int> allMaxNums = new (); //tracks all the max nums
int max = Int32.MinValue; // lowest value possible incase there are really low values

foreach (List<int> l in maxNumberInLists) // goes through each list
{
    foreach (int num in l) // goes through each int in the current list
    {
        if (num > max)
        {
            max = num;
        }
    }
    allMaxNums.Add(max);
    max = Int32.MinValue;
}

for (int i = 0; i < allMaxNums.Count; i++) // Prints the highest numbers in O(n) time
{
    Console.WriteLine($"List {i + 1} has a maximum of {allMaxNums.ElementAt(i)}. ");
}

/**************************************/
/**** Highest int out of all lists ****/
/**************************************/

// The time complexity of this solution is O(n^2)
List<List<int>> grades = new()
{
    new List<int>(){ 85,92, 67, 94, 94 },
    new List<int>(){ 50, 60, 57, 95 },
    new List<int>(){ 95 }
};
string location = ""; // The index or indecis of the highest grade
int highestGrade = 0; // tracks highest grade

for (int i = 0; i < grades.Count; i++) // goes through each list
{
    foreach (int g in grades.ElementAt(i)) // goes through each int in the current list
    {
        if (g > highestGrade)
        {
            highestGrade = g;
            location = (i + 1).ToString();
        } else if (g == highestGrade && location != (i + 1).ToString()) // Checks if it's still in the same list
        {
            location += ", " + (i + 1).ToString(); 
        }
        {

        }
    }
}

Console.WriteLine($"The highest grade is {highestGrade}. This grade was found in class(es) {location}");

/*******************************************/
/**** Order list from least to greatest ****/
/*******************************************/

// The time complexity of this solution is O(n^2)
List<int> orderThese = new() { 6, -2, 5, 3, 6, 3 ,8, 0 ,9, 76, 4, 1, -6, -7, 3 };

for (int i = 1; i < orderThese.Count; i++) // goes through each element in the list
{
    for (int j = i; j > 0; j--) // goes backwards through the list starting at the current element
    {
        if (orderThese.ElementAt(j) < orderThese.ElementAt(j - 1))
        {
            int save = orderThese.ElementAt(j); // preserves element
            orderThese[j] = orderThese[j - 1]; // moves an element up 1
            orderThese[j - 1] = save; // replaces duplicate element with preserved element
        }
    }
}

Console.WriteLine(String.Join(", ", orderThese));