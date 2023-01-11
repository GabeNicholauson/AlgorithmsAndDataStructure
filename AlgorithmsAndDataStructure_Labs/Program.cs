/**********************************************/
/**** Deciding how big the array should be ****/
/**********************************************/
Console.WriteLine("Please enter the desired length of the array:");
string[] chosenWords; // tracks all chosen words
string length = Console.ReadLine(); // reads user input

while (!length.All(char.IsDigit) || length == "0" || length.Length == 0) { // Checks for letters, if the user typed anything and if the size is 0
    Console.WriteLine("Please enter a whole number greater than 0"); //retry
    length = Console.ReadLine();
}

chosenWords = new string[Int32.Parse(length)]; // create array of desired length

/**************************************************/
/**** deciding the words to put into the array ****/
/**************************************************/
Console.WriteLine("Please enter the words you would like to add to the array:");
for (int i = 0; i < chosenWords.Length; i++) // puts each typed word into the array
{
    chosenWords[i] = Console.ReadLine();
    while (chosenWords[i].Contains(" ")) // checks if the word has a space
    {
        Console.WriteLine("Please enter one word at a time:"); // try again if word has space
        chosenWords[i] = Console.ReadLine();
    }
}
/*****************************************/
/**** choosing the character to count ****/
/*****************************************/
Console.WriteLine("Please enter the letter to count:");
char desiredChar = Console.ReadKey().KeyChar; // reads the first character typed
Console.WriteLine(); // space
while (!Char.IsLetter(desiredChar)) // if the char entered isn't a letter
{
    Console.WriteLine("Please enter a letter:"); // retry
    desiredChar = Console.ReadKey().KeyChar;
    Console.WriteLine();
}
/***************************************************************************************/
/**** counting how many times that character is used accross all words in the array ****/
/***************************************************************************************/
int charInstances = 0; // how many times the chosen char is used
int totalChars = 0; // total amount of chars accross all words
foreach (string word in chosenWords) // goes through each word
{
    totalChars += word.Length; // updates total chars with the amount of chars in the current word
    foreach (char character in word) // goes through each char in a word
    {
        if (char.ToUpper(character) == char.ToUpper(desiredChar)) // convert char to upper case to make program case insensitive
        {
            charInstances++;
        }
    }
}
/*****************************/
/**** Printing the result ****/
/*****************************/
double percentageAim = 0.25;
if ((double)charInstances / (double)totalChars > percentageAim) // if the character shows up more than the percentage aim
{
    Console.WriteLine("The letter " + desiredChar + " appears " + charInstances + " times in the array." +
                      " This letter makes up more than 25 % of the total number of characters.");
}
else
{
    Console.WriteLine(desiredChar + " appears " + charInstances + " times");
}