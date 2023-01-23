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
using System.Globalization;

Queue<string> songQueue = new Queue<string>();
Stack<string> previousSongs = new Stack<string>();
string currentSong = "";

while (true)
{
    string userInput;

    Console.WriteLine
        (
        "Choose an option:\n" +
        "1. Add a song to your playlist\n" +
        "2. Play the next song in your playlist\n" +
        "3. Skip the next song\n" +
        "4. Rewind one song\n" +
        "5. Exit\n"
        );

    userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Console.WriteLine("\nEnter song name:\n");
            userInput = Console.ReadLine();
            songQueue.Enqueue(userInput);
            Console.WriteLine($"\n\"{userInput}\" added to your playlist\n");
            break;
        case "2":
            if (currentSong.Length != 0)
                previousSongs.Push(currentSong);

            if (songQueue.Count > 0)
                currentSong = songQueue.Dequeue();
            else
                currentSong = "None queued";

            Console.WriteLine($"\nNow playing: {currentSong}\n");

            if (songQueue.Count > 0)
                Console.WriteLine($"Next song: {songQueue.Peek()}\n");
            else
                Console.WriteLine($"Next song: None queued\n");
            break;

    }
    
}


