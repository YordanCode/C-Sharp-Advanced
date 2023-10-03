using System;

static int FindMaxSubarraySum(int[] arr)
{
    int n = arr.Length;
    int maxSum = int.MinValue;
    int currentSum = arr[0];

    for (int i = 1; i < n; i++)
    {
        currentSum = Math.Max(arr[i], currentSum + arr[i]);
        maxSum = Math.Max(maxSum, currentSum);
    }
    return maxSum;
}

int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
int maxSum = FindMaxSubarraySum(arr);
Console.WriteLine("Maximum subarray sum: " + maxSum);
