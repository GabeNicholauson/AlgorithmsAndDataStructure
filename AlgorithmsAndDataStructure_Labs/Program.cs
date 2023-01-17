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
using System.Linq;

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
    Console.WriteLine($"List {i + 1} has a maximum of {allMaxNums.ElementAt(i)}. ");
}

/**************************************/
/**** Highest int out of all lists ****/
/**************************************/

List<List<int>> grades = new()
{
    new List<int>(){ 85,92, 67, 94, 94 },
    new List<int>(){ 50, 60, 57, 95 },
    new List<int>(){ 95 }
};
string location = "";
int highestGrade = 0;

for (int i = 0; i < grades.Count; i++)
{
    foreach (int g in grades.ElementAt(i))
    {
        if (g > highestGrade)
        {
            highestGrade = g;
            location = (i + 1).ToString();
        } else if (g == highestGrade && location != (i + 1).ToString())
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