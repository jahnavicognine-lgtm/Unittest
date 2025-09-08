/*Take two strings as input and check whether the second string is a sub-string of the first or not. If yes, print the number of times occurred in S1 and print the index positions where the string appeared]

i/p : S1 = “abcdabcabd”
      S2 = “ab”
o/p: No.of times occurred = 3
      Index positions = 0 4 7*/
namespace Question3
{
  
    using System;
    using System.Threading.Channels;

    class Program
    {
        static void Main()
        {
        FirstLine:
            string number;

            while (true)
            {
                Console.WriteLine("Enter a string of digits (at least 4 digits):");
                number = Console.ReadLine();

                if (!string.IsNullOrEmpty(number) && number.Length >= 4 && IsAllDigits(number))
                {
                    break;
                }

                Console.WriteLine("Invalid input. Please enter a valid string of at least 4 digits.");
            }

            int maxProduct = 0;
            string maxDigits = "";

            // Find the maximum product of 4 adjacent digits
            for (int i = 0; i <= number.Length - 4; i++)
            {
                int digit1 = int.Parse(number[i].ToString());
                int digit2 = int.Parse(number[i+1].ToString());
                int digit3 = int.Parse(number[i+2].ToString());
                int digit4 = int.Parse(number[i+3].ToString());

                int product = digit1 * digit2 * digit3 * digit4;

                if (product > maxProduct)
                {
                    maxProduct = product;
                    maxDigits = $"{digit1}*{digit2}*{digit3}*{digit4}";
                }
            }

            Console.WriteLine($"{maxDigits} = {maxProduct}");


           
            static bool IsAllDigits(string s)
            {
                foreach (char c in s)
                {
                    if (!char.IsDigit(c))
                        return false;
                }
                return true;
            }
            Console.WriteLine("Would Like to compile again(yes/no):");
            string repeatcompile = Console.ReadLine();
            if (repeatcompile=="yes"||repeatcompile=="Yes"||repeatcompile=="y"||repeatcompile=="Y"||repeatcompile=="YES")
            {
                Console.WriteLine("Compiling again");
                goto FirstLine;
            }
            else
            {
                Console.WriteLine("Bye");
            }
        }
    }
}