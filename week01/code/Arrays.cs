public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create a new double array with a size equal to length parameter
        double[] multiplesArray = new double[length];

        // 2. Create a loop that counts from 1 to the value passed on length
        for (var i = 1; i <= length; i++)
        {
            // 3. Multiply the number by the current loop assigned variable
            double multiple = number * i;

            // 4. Add the result to the array. Because index starts at 0, subtract 1 to the loop variable to use it as the array index
            multiplesArray[i - 1] = multiple;
        }

        // 5. Return the new multiples array
        return multiplesArray; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Use modulo to deal with wrapping around the index number back to 0
        amount %= data.Count;

        // 2. Get the range from the end of the list by the amount passed to the function
        List<int> range = data.GetRange(data.Count - amount, amount);

        // 3. Remove the range from the end of the original list by the amount passed to the function
        data.RemoveRange(data.Count - amount, amount);

        // 4. Add the new created range list at the beginning of the passed list
        data.InsertRange(0, range);
    }
}
