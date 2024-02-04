using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 2, 5, 7, 2, 8, 5, 3, 1, 7, 9, 3, 8, 6, 4, 5, 2, 1, 3, 9, 6, 10, 21, 21, 100, 100, 154, 14, 15, 14, 11,13};

        PrimeNumbers.GetPrimes(numbers);
        NonRepeatingNumbers.GetNonRepeatingNumbers(numbers);
        MostRepeatedNumbers.GetMostRepeatedNumbers(numbers);
    }
}
