﻿using System;
using System.Linq;

namespace WinFormsApp_FibonacciWithFiles
{
    class Methods
    {
        public static int NumberFromString(string stringFromFile)
        {
            string string_digits = string.Empty;

            for (int i = 0; i < stringFromFile.Length; i++)
            {
                if (Char.IsDigit(stringFromFile[i]))
                    string_digits += stringFromFile[i];
            }

            if (string_digits.Length > 0)
                return int.Parse(string_digits);

            return 0;
        }
        public static bool IsFibanacci(int numberFromFile)
        {
            int[] FibanacciNumbers = { 0, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233,
                                     377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 };

            if (FibanacciNumbers.Contains(numberFromFile))
            {
                return true;
            }

            return false;
        }
        public static string ReverseString(string stringToReverse)
        {
            char[] reversedCharArray = new char[stringToReverse.Length];

            for (int i = stringToReverse.Length - 1; i > -1; i--)
                reversedCharArray[stringToReverse.Length - i - 1] = stringToReverse[i];
            return new string(reversedCharArray);
        }
    }
}
