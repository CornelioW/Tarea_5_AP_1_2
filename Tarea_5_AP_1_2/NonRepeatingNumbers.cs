using System;
using System.Collections.Generic;

public class NonRepeatingNumbers
{
    public static void GetNonRepeatingNumbers(int[] numbers)
    {
        Console.WriteLine("\nNúmeros que no se repiten:");

        var nonRepeating = new List<int>();

        foreach (var num in numbers)
        {
            if (numbers.Count(n => n == num) == 1)
            {
                nonRepeating.Add(num);
            }
        }

        foreach (var num in nonRepeating)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}
