using System;
using System.Collections.Generic;
using System.Linq;

// This is the class structure used by LeetCode
public class Solution
{
    /**
     * LeetCode Problem #1: Two Sum
     * Given an array of integers `nums` and an integer `target`, return indices
     * of the two numbers such that they add up to `target`.
     * * @param nums The array of numbers.
     * @param target The target sum.
     * @return An array of two indices [index1, index2].
     */
    public static int[] TwoSum(int[] nums, int target)
    {
        int x = 0, y = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    x = i;
                    y = j;
                }
            }
        }

        return [x, y];
    }
}

// This is the runner class needed to actually execute and test the solution
public class Program
{
    public static void Main(string[] args)
    {
        // --- Setting up the test environment ---

        // 1. Instantiate the Solution class
        Solution solution = new Solution();

        // 2. Define the inputs (This is where the missing arguments usually occur!)
        int[][] nums = [
            [2, 7, 11, 15]
            , [3, 2, 4]
            , [3, 3]
        ];

        int[] target = [9, 6, 6];
        
        Console.WriteLine("--- Two Sum Problem Solver ---");
        Console.WriteLine($"Input Array: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Target Value: {target}");

        try
        {
            for (int i = 0; i < nums.Length; i++)
            {
                // 3. Call the TwoSum method with the defined arguments
            int[] result = Solution.TwoSum(nums[i], target[i]);

            // 4. Display the results
            if (result.Length == 2)
            {
                Console.WriteLine("\nSolution Found:");
                Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
                Console.WriteLine($"Check: {nums[i][result[0]]} + {nums[i][result[1]]} = {nums[i][result[0]] + nums[i][result[1]]}");
            }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
    }
}
