namespace FizzBuzz
{
    /* Written by: Geoff Gariepy, 03-FEB-2022
     * Purpose: a rethinking of FizzBuzz using C# version 9.0 records
     * and an extensible design.
     */

    // Declare a C# 9.0 record that contains an array of divisors 
    // to be used as the test, and a message string to be 
    // displayed if all of the tests pass.
    public record Condition(int[] DivisorArray, string Message);

    public class Program
    {
        // Just to make things maximally configurable,
        // set up readonly integers for the lower and upper bounds
        // of the range to be tested.
        static readonly int lowestInt = 1;
        static readonly int highestInt = 100;

        // Create an array of conditions for FizzBuzz
        // such that the first condition tested has 
        // the maximum number of divisors, the second has
        // the second-most number of divisors, etc.
        static readonly Condition[] FizzBuzzConditions = new Condition[]
        {
            new Condition(new int[] { 3, 5 }, "FizzBuzz"), // This one must be first!
            new Condition(new int[] { 3 }, "Fizz"),
            new Condition(new int[] { 5 }, "Buzz")
        };

        static void Main()
        {
            // Loop through the entire range of numbers to
            // be tested as either 'Fizz', 'Buzz', 'FizzBuzz' or int.
            for (int i = lowestInt; i <= highestInt; i++)
            {
                bool output = false;    // If this remains false after the tests, output int.

                // Iterate through all of the conditions and perform 
                // the modulo test to see if the current value
                // matches a condition.
                foreach (var condition in FizzBuzzConditions)
                {
                    bool allConditionsMet = true;       // If all the tests pass, this remains true
                    foreach(var divisor in condition.DivisorArray)
                    {
                        if (i % divisor != 0)
                            allConditionsMet = false;   // We failed a test, so this condition wasn't met.
                    }
                    if (allConditionsMet)
                    {
                        Console.WriteLine(condition.Message);
                        output = true;                  // We wrote output to the console.
                        continue;                       // Dont test any more conditions for this number.
                    }
                }
                if (output == false)
                    Console.WriteLine(i);               // We didn't output to the console, so write the int.
            }
        }
    }
}
