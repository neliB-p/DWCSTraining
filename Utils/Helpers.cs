using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Helpers
    {
        public static int[] InvertNumbers(int[] numbers)
        {
            int temp = 0;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                temp = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }

        public static string InvertLetters(string text)
        {
            string invertedLetter = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                invertedLetter += text[i];
            }
            return invertedLetter;
        }
        public static int SumOfArray(int[] arrayOfNumbers)
        {
            int sum = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                sum += arrayOfNumbers[i];
            }

            return sum;
        }


        public static int IndexOf(int[] arrayOfNumbers, int number)
        {
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }


        public static int MaxNumber(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
                return num2;
        }

        public static bool IsVowel(char letter)
        {
            char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < vowel.Length; i++)
            {
                if (letter == vowel[i])
                {
                    return true;
                }
            }
            return false;
        }

        public static string GetVowel(string text)
        {
            string extractVowel = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[i]))
                {
                    extractVowel += text[i];
                }
            }
            return extractVowel;
        }

        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
                return number1;
            else
                return number2;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static string FizBiz(int number)
        {
            string result = "";

            if (number % 3 == 0)
            {
                result += "FIZ";
            }

            if (number % 5 == 0)
            {
                result += "BIZ";
            }

            if (result == "")
            {
                result = "Nope";
            }

            return result;
        }
    }
}
