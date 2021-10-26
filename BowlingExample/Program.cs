using BowlingExampleTemplate.Bowling;
using System;

namespace BowlingExample
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a bowling game...");
            BowlingLogic.bowlingGameWithRNG();
        }
    }
}
