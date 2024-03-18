using System;
class TemperatureConverter
{

    // function Convert Temperature
    public static string ConvertTemperature(double temperature, string unit)
    {
        double newTemperature = 0;
        string newUnit = "";
        if (unit.ToUpper() == "C")
        {
            newTemperature = (temperature * 9 / 5) + 32;
            newUnit = "F";
        }
        else
        {
            newTemperature = (temperature - 32) * 5 / 9;
            newUnit = "C";
        }
        return $"Converted:{temperature} {unit} = {newTemperature:F2} {newUnit}";

    }

    public static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Enter a temperature and its unit (C or F), or type 'Quit' to exit:");
                string input = Console.ReadLine() ?? "";

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                string[] inputs = input.Split(' ');
                if (inputs.Length != 2)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric temperature.");
                    continue;
                }

                if (!double.TryParse(inputs[0], out double temperature))
                {
                    Console.WriteLine("Invalid input. Please enter a numeric temperature.");
                    continue;
                }

                string unit = inputs[1].ToUpper();
                if (unit != "C" && unit != "F")
                {
                    Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                    continue;
                }

                Console.WriteLine(ConvertTemperature(temperature, unit));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }
}