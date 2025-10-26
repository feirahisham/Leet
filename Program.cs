int[][] nums = [
    [2, 7, 11, 15]
    , [3, 2, 4]
    , [3, 3]
];

int[] target = [9, 6, 6];

Console.WriteLine("--- Two Sum Problem Solver ---");

try
{
    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine($"===========================");
        Console.WriteLine($"Input Array: [{string.Join(", ", nums[i])}]");
        Console.WriteLine($"Target Value: {target[i]}");
        
        int[] result = Solutions.TwoSum(nums[i], target[i]);


        if (result.Length == 2)
        {
            Console.WriteLine("\nSolution Found:");
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
            Console.WriteLine($"Check: {nums[i][result[0]]} + {nums[i][result[1]]} = {nums[i][result[0]] + nums[i][result[1]]}");
        }
        Console.WriteLine($"===========================");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\nError: {ex.Message}");
}