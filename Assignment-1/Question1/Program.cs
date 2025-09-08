/*Input: Consider n, and m as two float inputs
Implementation: Convert float inputs to binary and perform addition and convert the result back to float.*/
using System;

    

    
        internal class Program
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

            static void Main(string[] args)
            {
            FirstLine:
        Method1();

                // Convert valueOne raw bit  to binary representation
                int binOne = BitConverter.SingleToInt32Bits(valueOne);
                Console.WriteLine("Binary value of valueOne: " + Convert.ToString(binOne, 2));//base 2 conversion

                // Convert valueTwo raw bit to binary representation
                int binTwo = BitConverter.SingleToInt32Bits(valueTwo);
                Console.WriteLine("Binary value of valueTwo: " + Convert.ToString(binTwo, 2));//base 2 conversion

                //Addition of two float numbers
                float sum = valueOne + valueTwo;

                // Convert the sum to binary
                int binSum = BitConverter.SingleToInt32Bits(sum);
                Console.WriteLine("Binary value of the sum: " + Convert.ToString(binSum, 2));//base 2 conversion

                // Convert binary sum back to float
                float result = BitConverter.Int32BitsToSingle(binSum);
                Console.WriteLine("Float value from binary sum: " + result);
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
    


