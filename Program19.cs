\\Devlop the concept to create a class that does metric conversion from meters,centimeter to feet,inches respectively.create a class called meter.txt and raed the data  from the user by promoting.convert this dat into  feet and inches and save it in another file called feet.txt.\\
    using System;
using System.IO;

class MetricConverter
{
    public static void ConvertAndSave()
    {
        Console.Write("Enter value in meters: ");
        double meters = double.Parse(Console.ReadLine());

        double feet = meters * 3.28084;
        double inches = meters * 39.3701;

        File.WriteAllText("feet.txt", $"Meters: {meters}, Feet: {feet}, Inches: {inches}");
        Console.WriteLine("Data saved to feet.txt");
    }

    static void Main()
    {
        ConvertAndSave();
    }
}
