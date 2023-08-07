class Program
{
    /// <summary>
    /// Kadane's algorithm
    /// finds the highest sum of a continuous subsequence within an array or list of integers
    /// </summary>
    /// <param name="arr">input array</param>
    /// <returns>maximum sum</returns>
    public static int MaxSequence(int[] arr)
    {
        if (arr == null || !arr.Any()) return 0;

        int maxEndingHere = arr[0];
        int maxSoFar = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
    static void Main(string[] args)
    {
        //tests
        Console.WriteLine(MaxSequence(null));
        Console.WriteLine(MaxSequence(new int[0]));
        Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        Console.WriteLine(MaxSequence(new int[] { -2, -6, -3, -4, -1, -2, -1, -5, -4 }));
        Console.WriteLine(MaxSequence(new int[] { 2, 6, 3, 4, 1, 2, 1, 5, 4 }));
        Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, -44, -1, 2, 1, -50, 4 }));
    }
}