using System;

//int i = 2.4.Round();  // i = 2
//int j = 2.5.Round();  // j = 3



public class ExtensionMethod
{
    public static void Main()
    {
        double value = 2.4;
        for (int i = 0; i <= 1; i++)
            value = RoundValueAndAdd(value);

        Console.WriteLine();

        value = 2.5;
        RoundValueAndAdd(value);

    }

    private static double RoundValueAndAdd(double value)
    {
        
        Console.WriteLine("{0} --> {1}", value, Math.Round(value));
        return value + .1;

    }

}


