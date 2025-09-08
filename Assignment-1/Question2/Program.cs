/*Take two strings as input and check whether the second string is a sub-string of the first or not. If yes, print the number of times occurred in S1 and print the index positions where the string appeared]

i/p : S1 = “abcdabcabd”
        S2 = “ab”
o/p: No.of times occurred = 3
        Index positions = 0 4 7*/
using System;

namespace Question2
{
    internal class Program
    {
        static string inputOne;   // Main string (S1)
        static string inputTwo;   // Substring to find (S2)

        public void Method1()
        {
            bool valid = false;
            Console.WriteLine("Checking whether the second string is a part of the first string and displaying the indexes and count the number of times it is repeated");

            // Input for first string
            while (!valid)
            {
                Console.WriteLine("Enter the first string (main string):");
                inputOne = Console.ReadLine();
                if (IsAlphabetic(inputOne))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid string (no numbers, spaces, or symbols allowed).");
                }
            }

            valid = false;
            // Input for second string
            while (!valid)
            {
                Console.WriteLine("Enter the second string (substring to find):");
                inputTwo = Console.ReadLine();
                if (IsAlphabetic(inputTwo))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid string (no numbers, spaces, or symbols allowed).");
                }
            }

            Console.WriteLine("The first input string: " + inputOne);
            Console.WriteLine("The second input string: " + inputTwo);
        }

        static void Main(string[] args)
        {
            int count = 0;
            Program obj = new Program();
            obj.Method1();

            // Check substring
            for (int i = 0; i <= inputOne.Length - inputTwo.Length; i++)
            {
                int j;
                for (j = 0; j < inputTwo.Length; j++)
                {
                    if (inputOne[i + j] != inputTwo[j])
                    {
                        break; // characters don’t match
                    }
                }

                // if full match found
                if (j == inputTwo.Length)
                {
                    Console.WriteLine("Found substring at index: " + i);
                    count++;
                }
            }

            // Final output
            if (count > 0)
            {
                Console.WriteLine("The number of times the substring occurred: " + count);
            }
            else
            {
                Console.WriteLine("There is no substring available in the main string");
            }
        }

        private static bool IsAlphabetic(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

    }
}

