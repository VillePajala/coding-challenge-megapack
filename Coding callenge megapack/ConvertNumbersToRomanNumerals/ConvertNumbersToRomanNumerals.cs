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
            Dictionary<String, Int32> romanNumeralDict = new Dictionary<String, Int32>();
            romanNumeralDict.Add("M", inputNumber / 1000); 
            romanNumeralDict.Add("D", (inputNumber % 1000) / 500);
            romanNumeralDict.Add("C", ((inputNumber % 1000) % 500) / 100);
            romanNumeralDict.Add("X", (((inputNumber % 1000) % 500) % 100) / 10);
            romanNumeralDict.Add("V", ((((inputNumber % 1000) % 500) % 100) % 10) / 5);
            romanNumeralDict.Add("IV", (((((inputNumber % 1000) % 500) % 100) % 10) % 5) / 4);
            romanNumeralDict.Add("I", ((((((inputNumber % 1000) % 500) % 100) % 10) % 5) % 4) / 1);

            string romanNumeralOutput = constructRomanNumeralString(romanNumeralDict);
            Console.WriteLine("The result of the conversion: " + romanNumeralOutput);
        }

        public static string constructRomanNumeralString(Dictionary<String, Int32> romanNumeralDict)
        {
            string romanNumeralOutput = "";
            foreach (KeyValuePair<String, Int32> romanNumeralAndTimes in romanNumeralDict)
            {
                romanNumeralOutput = romanNumeralOutput + addRomanNumeralString(romanNumeralAndTimes.Key, romanNumeralAndTimes.Value);
            }
            return romanNumeralOutput;
        }

        public static string addRomanNumeralString(string romanNumeralCharacter, int timesTheCharacterwillBeAdded)
        {
            int loopCount = 0;
            string romanNumeralString = "";
            while (loopCount < timesTheCharacterwillBeAdded)
            {
                romanNumeralString = romanNumeralString + romanNumeralCharacter;
                loopCount = loopCount + 1;
            }
            return romanNumeralString;
        }
    }
}
