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

/**********************************/
/**** Highest int in each list ****/
/**********************************/
using System;
using System.Collections.Generic;

List<List<int>> maxNumberInLists = new()
{
    new List<int>(){ 1, 5, 3 },
    new List<int>(){ 9, 7, 3, -2 },
    new List<int>(){ 2, 1, 2 }
};
List<int?> allMaxNums = new ();
int? max = null;

foreach (List<int> l in maxNumberInLists)
{
    foreach (int num in l)
    {
        if (num > max && max != null)
        {
            max = num;
        }
        else max ??= num;
    }
    allMaxNums.Add(max);
    max = null;
}

for (int i = 0; i < allMaxNums.Count; i++)
{
    Console.Write($"List {i + 1} has a maximum of {allMaxNums.ElementAt(i)}. ");
}
