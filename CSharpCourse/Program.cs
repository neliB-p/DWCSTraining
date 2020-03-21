using HomeworkTsveti;
using System;
using Utils;

namespace CSharpCourseR
{

    class Program
    {
        static void Main(string[] args)
        {

            //-------------20.03.2020--------------------

            //  {1,1,1,2,2}
            // 1 - 3 times, 2 - 2 times
            int[] number = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"Input number {i + 1}");
                number[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number.Length; i++)
            {
                int count = 0;

                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] == number[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{number[i]} - {count}"); 
            }

            //int[] numbers = new int[6];
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine($"Input number {i+1}");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}            
            //foreach (var item in Helpers.InvertNumbers(numbers))
            //{
            //    Console.WriteLine(item);
            //}

            //String text;
            //Console.WriteLine("Enter a word:");
            //text = Console.ReadLine();
            //Console.WriteLine(Helpers.InvertLetters(text.Trim()));

            //DateTime[] dates = { DateTime.Now, DateTime.Now.Add(TimeSpan.FromDays(1)), DateTime.Now.AddDays(2), DateTime.Now };
            //foreach (DateTime item in Filter(dates))
            //{
            //    Console.WriteLine(item);
            //}

            //-------------18.03.2020--------------------

            //string text = Console.ReadLine();
            //Console.WriteLine(Helpers.GetVowel(text));


            //Console.WriteLine("Enter a number");
            //int number = int.Parse(Console.ReadLine());
            //int[] arrayInt1 = new int[5];

            //for (int i = 0; i < arrayInt1.Length; i++)
            //{
            //    arrayInt1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"The sum of the array is {Helpers.SumOfArray(arrayInt1)}");
            //Console.WriteLine($"The index of the number {number} is {Helpers.IndexOf(arrayInt1, number)}");

            //int[] arrayInt1 = new int[5] {1,2,3,4,5};

            //for (int i = 0, j = 10; i != j; i++, j--)
            //{
            //    Console.WriteLine($"i: {i}; j: {j}");
            //}


            //-------------------------------------

            Homework1 task1 = new Homework1();
            task1.ChooseAction();

            //string input = Console.ReadLine();
            //int number = int.Parse(input);

            //for (int i = 1; i <= number; i++)
            //{
            //    for (int h = i; h < number; h++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j < i*2; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}


            //int count = 0;


            //Console.WriteLine();

            //for (int i = 0 ; i < input.Length; i++)
            //{
            //    if (Helpers.IsVowel(input[i]))
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"The count of vowel letters is: {count}");


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Hello {i}");
            //}

            //Console.ReadKey();
        }
    }
}
