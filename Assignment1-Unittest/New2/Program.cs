using System;
namespace New2
{
    using System;

   
        public class Program
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

            /// <summary>
            /// Prints the indexes where the substring occurs and returns the count.
            /// </summary>
            public static int FindSubstringOccurrences(string inputOne, string inputTwo)
            {
                int count = 0;

                Console.Write("Index positions = ");

                for (int i = 0; i <= inputOne.Length - inputTwo.Length; i++)
                {
                    int j;
                    for (j = 0; j < inputTwo.Length; j++)
                    {
                        if (inputOne[i + j] != inputTwo[j])
                        {
                            break; // mismatch
                        }
                    }

                    if (j == inputTwo.Length)
                    {
                        Console.Write(i + " "); // print index directly
                        count++;
                    }
                }

                Console.WriteLine(); // move to next line
                return count;
            }

            static void Main(string[] args)
            {
                Program obj = new Program();
                obj.Method1();

                // Call the method
                int count = FindSubstringOccurrences(inputOne, inputTwo);

                if (count > 0)
                {
                    Console.WriteLine("No. of times occurred = " + count);
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
