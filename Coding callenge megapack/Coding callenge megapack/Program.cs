using System;
using ConvertNumbersToRomanNumerals;

namespace Coding_callenge_megapack
{
    public class ChallengeMenu
    {
        
        public static void ChooseChallenge()
        {
            String challengeNumber;

            Console.WriteLine("Welcome to Coding challenge megapack!");
            Console.WriteLine("Type the number of the challenge you want to try out");
            Console.WriteLine("");
            Console.WriteLine("Convert numbers to roman numerals: 1");
            challengeNumber = Console.ReadLine();

            RunChallenge(challengeNumber);
        }

        public static void RunChallenge(string challengeSelected)
        {
            switch (challengeSelected)
            {
                case "1":
                    ConvertNumbersToRomanNumerals.ConvertNumbersToRomanNumerals.ConvertNumberToRomanNumerals(challengeSelected);
                    ChooseChallenge();
                    break;
                default:
                    break;
            }
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
