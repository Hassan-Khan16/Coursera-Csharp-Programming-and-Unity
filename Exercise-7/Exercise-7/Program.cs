using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Choose a data type. \n[1] Int\n[2] Float\n[3] Double\n[4] Quit");
                int x = Int32.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            // Declare 3 variables in int
                            int originalFahr;
                            int calcCelsius;
                            int calcFahr;

                            // Assign temperature 0 in int;
                            originalFahr = 0;
                            Console.WriteLine("Original: " + originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Calculated Celsius: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);

                            // Assign temperature 32 in int;
                            originalFahr = 32;
                            Console.WriteLine("Original: " + +originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Calculated Celsius: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);

                            // Assign temperature 212 in int;
                            originalFahr = 212;
                            Console.WriteLine("Original: " + originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Calculated Celsius: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);
                            break;
                        }
                    case 2:
                        {
                            // Declare 3 variables in float
                            float originalFahr;
                            float calcCelsius;
                            float calcFahr;

                            // Assign temperature 0 in int;
                            originalFahr = 0;
                            Console.WriteLine("Original: " + originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Calculated Celsius: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);

                            // Assign temperature 32 in int;
                            originalFahr = 32;
                            Console.WriteLine("Original: " + originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Calculated Celsius: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);

                            // Assign temperature 212 in int;
                            originalFahr = 212;
                            Console.WriteLine("Original: " + originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Calculated Celsius: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);
                            break;
                        }
                    case 3:
                        {
                            // Declare 3 variables in double
                            double originalFahr;
                            double calcCelsius;
                            double calcFahr;

                            // Assign temperature 0 in int;
                            originalFahr = 0;
                            Console.WriteLine(originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Original: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);

                            // Assign temperature 32 in int;
                            originalFahr = 32;
                            Console.WriteLine("Calculated Celsius: " + originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Calculated Celsius: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);

                            // Assign temperature 212 in int;
                            originalFahr = 212;
                            Console.WriteLine("Original: " + originalFahr);

                            // Convert to Celsius
                            calcCelsius = ((originalFahr - 32) / 9) * 5;
                            Console.WriteLine("Calculated Celsius: " + calcCelsius);

                            // Convert back to Fahrenheit 
                            calcFahr = (((originalFahr * 9) / 5) + 32);
                            Console.WriteLine("Calculated Fahrenheit: " + calcFahr);
                            break;
                        }
                }
            
        }
    }
}
