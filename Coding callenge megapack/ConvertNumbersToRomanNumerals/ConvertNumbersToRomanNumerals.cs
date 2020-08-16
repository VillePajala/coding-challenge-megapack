using System;

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
            int thousandsCount = inputNumber / 1000;
            inputNumber = inputNumber - (thousandsCount * 1000);
            int fiveHundredsCount = inputNumber / 500;
            inputNumber = inputNumber - (fiveHundredsCount * 500);
            int hundredsCount = inputNumber / 100;
            inputNumber = inputNumber - (hundredsCount * 100);
            string romanNumeralOutput = "";


            int loopCount = 0;
            while(loopCount < thousandsCount)
            {
                romanNumeralOutput = romanNumeralOutput + "M";
                loopCount = loopCount + 1;
            }
            
            loopCount = 0;
            while (loopCount < fiveHundredsCount)
            {
                romanNumeralOutput = romanNumeralOutput + "D";
                loopCount = loopCount + 1;
            }
            
            loopCount = 0;
            while (loopCount < hundredsCount)
            {
                romanNumeralOutput = romanNumeralOutput + "C";
                loopCount = loopCount + 1;
            }
            
            Console.WriteLine("The result of the conversion: " + romanNumeralOutput);
        }
    }
}
