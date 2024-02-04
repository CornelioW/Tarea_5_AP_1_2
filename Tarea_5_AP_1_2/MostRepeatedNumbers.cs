using System;
using System.Collections.Generic;
using System.Linq;

public class MostRepeatedNumbers
{
    public static void GetMostRepeatedNumbers(int[] numbers)
    {
        Console.WriteLine("\nNúmeros que más se repiten:");

        var groupedNumbers = numbers.GroupBy(n => n)
                                    .OrderByDescending(g => g.Count())
                                    .FirstOrDefault();

        if (groupedNumbers != null)
        {
            var mostRepeatedNumber = groupedNumbers.Key;
            var repetitionCount = groupedNumbers.Count();

            Console.WriteLine($"{mostRepeatedNumber} (repetido {repetitionCount} veces)");
        }
        else
        {
            Console.WriteLine("No hay números repetidos.");
        }
    }
}
