

    using System;

    namespace New3
{
        public class Program
        {
            static float valueOne, valueTwo;

            public static void Method1()
            {
                bool valid = false;
                Console.WriteLine("Binary Addition of Floating-Point Numbers");

                // Input for valueOne
                while (!valid)
                {
                    try
                    {
                        Console.Write("Enter the first float value (n): ");
                        valueOne = float.Parse(Console.ReadLine());
                        valid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid float number.");
                    }
                }

                valid = false;

                // Input for valueTwo
                while (!valid)
                {
                    try
                    {
                        Console.Write("Enter the second float value (m): ");
                        valueTwo = float.Parse(Console.ReadLine());
                        valid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid float number.");
                    }
                }
            }

            public static (string binOne, string binTwo, string binSum, float result) AddAndConvert(float valueOne, float valueTwo)
            {
                // Convert valueOne raw bits to binary
                int binOneInt = BitConverter.SingleToInt32Bits(valueOne);
                string binOne = Convert.ToString(binOneInt, 2);

                // Convert valueTwo raw bits to binary
                int binTwoInt = BitConverter.SingleToInt32Bits(valueTwo);
                string binTwo = Convert.ToString(binTwoInt, 2);

                // Perform float addition
                float sum = valueOne + valueTwo;

                // Convert sum to binary
                int binSumInt = BitConverter.SingleToInt32Bits(sum);
                string binSum = Convert.ToString(binSumInt, 2);

                // Convert binary sum back to float
                float result = BitConverter.Int32BitsToSingle(binSumInt);

                return (binOne, binTwo, binSum, result);
            }

            static void Main(string[] args)
            {
FirstLine:
                Method1();

                var (binOne, binTwo, binSum, result) = AddAndConvert(valueOne, valueTwo);

                Console.WriteLine("Binary value of valueOne: " + binOne);
                Console.WriteLine("Binary value of valueTwo: " + binTwo);
                Console.WriteLine("Binary value of the sum: " + binSum);
                Console.WriteLine("Float value from binary sum: " + result);

                Console.WriteLine("Would you like to compile again (yes/no):");
                string repeatcompile = Console.ReadLine();
                if (repeatcompile == "yes" || repeatcompile == "Yes" || repeatcompile == "y" || repeatcompile == "Y" || repeatcompile == "YES")
                {
                    Console.WriteLine("Compiling again...");
                    goto FirstLine;
                }
                else
                {
                    Console.WriteLine("Bye");
                }
            }
        }
    }


