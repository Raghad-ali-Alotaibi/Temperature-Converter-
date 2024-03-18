using System;
class TemperatureConverter
{
    public static string TempConvert(double temperature, string unit)
    {
        if (unit == "F")
        {
            double newTemp = (temperature - 32) * 5 / 9;
            return $"converted:{newTemp} C";
        }
        else if (unit == "C")
        {
            double newTemp = temperature * 9 / 5 + 32;
            return $"converted:{newTemp} F";
        }
        else
        {
            return "Invalid unit";
        }
    }

    static void Main(string[] args)
    {

        // Console.WriteLine("Enter a temperature and its unit (C or F):");
        // string input = Console.ReadLine() ?? "";

        Console.WriteLine(TempConvert(32, "F")); // Output: 0 C 
        Console.WriteLine(TempConvert(100, "C")); // Output: 212 F }
    }

}


