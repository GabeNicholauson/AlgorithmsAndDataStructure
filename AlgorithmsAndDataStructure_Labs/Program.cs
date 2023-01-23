/*
 * Lab 5
 * Gabriel Nicholauson
 * 
 * Simple command line playlist app that allows a user to add a song to a playlist,
 * play the next song, skip the upcoming song or rewind by one song many times to 
 * play a previous track.
*/

using System;
using System.Collections;
using System.Collections.Generic;

Queue<string> songQueue = new Queue<string>();
Stack<string> previousSongs = new Stack<string>();

while(true)
{
    string userInput = string.Empty;
    Console.WriteLine
        (
        "Choose an option:\n" +
        "1. Add a song to your playlist\n" +
        "2. Play the next song in your playlist\n" +
        "3. Skip the next song\n" +
        "4. Rewind one song\n" +
        "5. Exit"
        );

    userInput= Console.ReadLine();

    if(userInput == "1")
    {
        Console.WriteLine("Enter song name")
        userInput = Console.ReadLine();
        songQueue.Enqueue(userInput);
        Console.WriteLine($"\"{userInput}\" added to your playlist")
    }
    
}


