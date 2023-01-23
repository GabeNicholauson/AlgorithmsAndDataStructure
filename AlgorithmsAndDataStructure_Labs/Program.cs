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

string noSongQueued = "No song queued"; // informs user that there are no more songs queued
string noSongPlaying = "No song playing"; // informs user that there is no song playing
string currentSong = noSongPlaying; // the current song playing, taken from the queue
string nextSong = noSongQueued; // the next song to be played
Queue<string> songQueue = new Queue<string>(); // The queue for the songs
Queue<string> prioritySongs = new Queue<string>(); // saves songs if the user goes back to previous songs
Stack<string> previousSongs = new Stack<string>(); // previously listened to songs, used when the user wants to listen to them again
bool stop = false; // used to stop application

while (!stop)
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
        /******************************************************************/
        /**** ADD SONG TO PLAYLIST ****************************************/
        /******************************************************************/
        case "1":
            Console.WriteLine("\nEnter song name:\n");
            userInput = Console.ReadLine();
            songQueue.Enqueue(userInput); // puts song in queue
            Console.WriteLine($"\n\"{userInput}\" added to your playlist\n");
            break;
        /******************************************************************/
        /**** PLAY NEXT SONG **********************************************/
        /******************************************************************/
        case "2":
            if (currentSong != noSongPlaying) // if there is a song playing
                previousSongs.Push(currentSong);

            if (prioritySongs.Count > 0) // if user has gone back one or more songs
                currentSong = prioritySongs.Dequeue(); // play song
            else if (songQueue.Count > 0) // if there is a song in the queue
                currentSong = songQueue.Dequeue();
            else // no songs coming up
                currentSong = noSongPlaying;

            if (prioritySongs.Count > 0) //checks if there is still songs in the queues
                nextSong = prioritySongs.Peek();
            else if (songQueue.Count > 0)
                nextSong = songQueue.Peek();
            else // there isn't
                nextSong = noSongQueued;

            Console.WriteLine($"\nNow playing: {currentSong}\n");
            Console.WriteLine($"Next song: {nextSong}\n");
            break;
        /******************************************************************/
        /**** SKIP NEXT SONG **********************************************/
        /******************************************************************/
        case "3":
            if (prioritySongs.Count > 0) // if user has gone back one or more songs
                previousSongs.Push(prioritySongs.Dequeue()); // remove next song from the queue
            else if (songQueue.Count > 0) // if there is a song in the queue
                previousSongs.Push(songQueue.Dequeue());
            else // there are no songs in the queue
            {
                Console.WriteLine($"\n{noSongQueued}\n");
                break;
            }

            if (prioritySongs.Count > 0) //checks if there is still songs in the queues
                nextSong = prioritySongs.Peek();
            else if (songQueue.Count > 0)
                nextSong = songQueue.Peek();
            else // there isn't'
                nextSong = noSongQueued;

            Console.WriteLine($"\nNow playing: {currentSong}\n");
            Console.WriteLine($"Next song: {nextSong}\n");
            break;
        /******************************************************************/
        /**** REWIND ONE SONG *********************************************/
        /******************************************************************/
        case "4": // rewind one song
            if(previousSongs.Count == 0) // if there aren't songs to go back to
            {
                Console.WriteLine("\nNo previous songs\n");
                break;
            }

            if(currentSong != noSongPlaying) // if there is a song playing
            {
                prioritySongs.Enqueue(currentSong); // that song will play next
                nextSong = prioritySongs.Peek();
            }

            currentSong = previousSongs.Pop(); // play previous song

            Console.WriteLine($"\nNow playing: {currentSong}\n");
            Console.WriteLine($"Next song: {nextSong}\n");
            break;
        /******************************************************************/
        /**** EXIT APPLICATION ********************************************/
        /******************************************************************/
        case "5": // exit application
            stop = true;
            break;

    }
    
}

Console.WriteLine("\nThanks for listening!");


