using BowlingExampleTemplate.Bowling;
using System;

namespace BowlingExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a bowling game...");
            BowlingLogic.bowlingGameWithRNG();
        }
    }
}
