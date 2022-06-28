namespace Csharp_Simplified_Fractions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            program();
        }

        public static void program()
        {
            try
            {
                Console.WriteLine("Input Fraction to Simplify.");
                Console.WriteLine("Input Numerator.");
                string str_numerator = Console.ReadLine();
                Console.WriteLine("Input Denominator.");
                string str_denominator = Console.ReadLine();
                Console.WriteLine();
                string org_fraction = str_numerator + "/" + str_denominator;

                int int_numerator = Int32.Parse(str_numerator);
                int int_denominator = Int32.Parse(str_denominator);

                int remainder = int_denominator % int_numerator;

                if (remainder != 0)
                {
                    int int_result_numerator = int_numerator / remainder;
                    int int_result_denominator = int_denominator / remainder;

                    Console.WriteLine(org_fraction + " => " + int_result_numerator.ToString() + "/" + int_result_denominator);
                    program();
                }
                else if (remainder == 0)
                {
                    if (int_numerator < int_denominator)
                    {
                        int int_result_numerator = int_numerator / int_numerator;
                        int int_result_denominator = int_denominator / int_numerator;

                        Console.WriteLine(org_fraction + " => " + int_result_numerator.ToString() + "/" + int_result_denominator);
                        program();
                    }
                    else if (int_denominator > int_numerator)
                    {
                        int int_result = int_denominator / int_numerator;
                        Console.WriteLine(org_fraction + " => " + int_result);
                        program();
                    }
                    else if (int_denominator == int_numerator)
                    {
                        Console.WriteLine(org_fraction + " => " + "1");
                        program();
                    }
                }
            }
            catch (Exception x)
            {
                program();
            }
        }
    }
}