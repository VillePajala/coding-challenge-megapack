using System;
using System.Collections.Generic;

namespace ConvertNumbersToRomanNumerals
{
    public class ConvertNumbersToRomanNumerals
    {
        public static void ConvertNumberToRomanNumerals(string challengeSelected)
        {
            Console.WriteLine("Welcome trying out the converting of numbers to Roman numerals!");
            askUserForNumberToConvert();
        }

        public static void askUserForNumberToConvert()
        {
            int inputNumber;
            try
            {
                Console.WriteLine("Type in the number you would like to convert");
                convertInput(inputNumber = Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Something went wrong. Make sure to input a NUMBER");
                askUserForNumberToConvert();
            }
        }

        public static void convertInput(int inputNumber)
        {
            

            string romanNumeralOutput = "";

            int thousandscount = inputNumber / 1000;
            int fivehundredscount = (inputNumber % 1000) / 500;
            int hundredscount = ((inputNumber % 1000) % 500) / 100;
            int tensCount = (((inputNumber % 1000) % 500) % 100) / 10;
            int fivesCount = ((((inputNumber % 1000) % 500) % 100) % 10) / 5;
            int onesCount = ((((inputNumber % 1000) % 500) % 100) % 10) & 5;

            Dictionary<String, Int32> romanNumeralDict = new Dictionary<String, Int32>()
            romanNumeralDict.Add("M", thousandscount); 
            romanNumeralDict.Add("D", fivehundredscount);
            romanNumeralDict.Add("C", hundredscount);
            romanNumeralDict.Add("X", tensCount);
            romanNumeralDict.Add("V", fivesCount);
            if (onesCount == 4) romanNumeralDict.Add("IV", 1); 
            else romanNumeralDict.Add("I", onesCount);



            foreach (KeyValuePair<String, Int32> romanNumeralAndTimes in romanNumeralDict)
            {
                romanNumeralOutput = romanNumeralOutput + addRomanNumeralString(romanNumeralAndTimes.Key, romanNumeralAndTimes.Value);
                
            }
            Console.WriteLine("The result of the conversion: " + romanNumeralOutput);
        }


            public static string addRomanNumeralString(string romanNumeralCharacter, int timesTheCharacterwillBeAdded)
        {
            int loopCount = 0;
            string romanNumeralString = "";
            while(loopCount < timesTheCharacterwillBeAdded)
            {
                romanNumeralString = romanNumeralString + romanNumeralCharacter;
                loopCount = loopCount + 1;
            }
            return romanNumeralString;
        }
    }
}
