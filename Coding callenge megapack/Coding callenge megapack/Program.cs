﻿using System;

namespace Coding_callenge_megapack
{
    public class ChallengeMenu
    {
        
        public static void ChooseChallenge()
        {
            String challengeNumber;

            Console.WriteLine("Welcome to Coding challenge megapack!");
            Console.WriteLine("");
            Console.WriteLine("Type the number of the challenge you want to try out");
            Console.WriteLine("");
            Console.WriteLine("Convert numbers to roman numerals: 1s");
            challengeNumber = Console.ReadLine();

            RunChallenge(challengeNumber);
        }

        public static void RunChallenge(string challengeSelected)
        {
            Console.WriteLine(challengeSelected);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChallengeMenu.ChooseChallenge();
        }
    }
}
