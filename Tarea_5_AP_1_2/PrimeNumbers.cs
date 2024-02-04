using System;

public class PrimeNumbers
{
    public static void GetPrimes(int[] numbers)
    {
        Console.WriteLine("\nNúmeros primos:");

        foreach (var num in numbers)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }

        Console.WriteLine();
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
