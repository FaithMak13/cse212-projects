using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
        // Problem 1 Plan: MultiplesOf Function using an Array
        // 1. Create a new array of doubles with a length equal to the number of multiples.
        // 2. Use a loop to go from 0 to the number of multiples - 1.
        // 3. On each loop iteration, calculate the multiple by multiplying the starting number by (i + 1).
        // 4. Store that value in the array at index i.
        // 5. After the loop is complete, return the array.
        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
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
        // Problem 2 Plan: RotateListRight Function using a List<T>
        // 1. The function takes a list and an amount to rotate to the right.
        // 2. First, use GetRange() to get the last 'amount' elements from the list.
        // 3. Then, use GetRange() again to get the remaining elements from the front.
        // 4. Clear the original list.
        // 5. Use AddRange() to add the two parts in rotated order: last part first, then the front part.
        // 6. This creates a rotated version of the list.

        int count = data.Count;

        if (count <= 1 || amount <= 0 || amount == count)
            return;

        // Get the last 'amount' elements
        List<int> tail = data.GetRange(count - amount, amount);

        // Get the remaining elements from the beginning
        List<int> head = data.GetRange(0, count - amount);

        // Clear the original list and add rotated elements
        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}

