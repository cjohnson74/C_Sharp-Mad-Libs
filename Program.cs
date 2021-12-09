using System;

namespace C_SharpMadLibs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Init Variables
            string theMatrix, system, neo, enemy, inside, save, unplugged, fight;
            string[] profession = new string[4], adj = new string[2];

            // Get Input from User
            Console.WriteLine("Welcome user!");
            Console.WriteLine("Let's Play a game of madlibs!");
            Console.WriteLine("Please share with me your name!");
            neo = Console.ReadLine();


            String madlibsStory =
            $"{theMatrix} is a {system}, {neo}. That {system} is our {enemy}. " +
            $"But when you're {inside}, you look around, what do you see? " +
            $"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}. " +
            $"The very minds of the people we are trying to {save}. But until we do, " +
            $"these people are still a part of that {system} and that makes " +
            $"them our {enemy}. You have to understand, most of these people are " +
            $"not ready to be {unplugged}. And many of them are so {adj[0]}, so " +
            $"hopelessly {adj[0]} on the {system}, that they will {fight} to protect it.";

            // Init Story

            // Print Story
            Console.WriteLine(madlibsStory);
        }
    }
}
