/*
Showing Creativity:

I have added an option to Enable and Disable an autosave feature. This will save the files automatically
every time the Autosave is enabled or disabled, a goal is created, or an event is recorded.

The name of the file in which the goals are stored is showed every time the autosave is enabled/disabled.

*/

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager program = new GoalManager();
        program.Start();
    }
}