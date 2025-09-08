

    using System;
    namespace New1
    {

        public class Program
        {
            public static (int maxProduct, string maxDigits) FindMaxProduct(string number)
            {
                int maxProduct = 0;
                string maxDigits = "";

                for (int i = 0; i <= number.Length - 4; i++)
                {
                    int digit1 = int.Parse(number[i].ToString());
                    int digit2 = int.Parse(number[i + 1].ToString());
                    int digit3 = int.Parse(number[i + 2].ToString());
                    int digit4 = int.Parse(number[i + 3].ToString());

                    int product = digit1 * digit2 * digit3 * digit4;

                    if (product > maxProduct)
                    {
                        maxProduct = product;
                        maxDigits = $"{digit1}*{digit2}*{digit3}*{digit4}";
                    }
                }

                return (maxProduct, maxDigits);
            }

            static void Main()
            {
                Console.WriteLine("Enter a string of digits (at least 4 digits):");
                string number = Console.ReadLine();


                if (!string.IsNullOrEmpty(number) && number.Length >= 4 && IsAllDigits(number))
                {
                    var result = FindMaxProduct(number);
                    Console.WriteLine($"{result.maxDigits} = {result.maxProduct}");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

            }


            public static bool IsAllDigits(string s)
            {
                foreach (char c in s)
                {
                    if (!char.IsDigit(c)) return false;
                }
                return true;
            }

        }
    }


