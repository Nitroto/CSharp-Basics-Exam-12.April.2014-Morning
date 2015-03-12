using System;
using System.Globalization;
using System.Threading;

class Pairs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] userInput = Console.ReadLine().Split(' ');
        int[] nums = new int[userInput.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(userInput[i]);
        }
        int maxDiff = 0;
        int previusPairSum = nums[0] + nums[1];
        for (int i = 2; i < nums.Length; i += 2)
        {
            int sumOfPair = nums[i] + nums[i + 1];
            int diff = Math.Abs(previusPairSum - sumOfPair);
            maxDiff = Math.Max(diff, maxDiff);
            previusPairSum = sumOfPair;
        }
        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", previusPairSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
