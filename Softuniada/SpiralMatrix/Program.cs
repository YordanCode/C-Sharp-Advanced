using System;
using System.Collections.Generic;
using System.Linq;

int countRows = int.Parse(Console.ReadLine());
int countCols = int.Parse(Console.ReadLine());
int[,] numbers = new int[countRows, countCols];
for (int i = 0; i < countRows; i++)
{
    int[] values = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    for (int j = 0; j < countCols; j++)
    {
        numbers[i, j] = values[j];
    }
}
List<int> spiralOrder = new();

int top = 0;
int bottom = numbers.GetLength(0) - 1;
int right = numbers.GetLength(1) - 1;
int left = 0;


while (spiralOrder.Count < countRows * countCols)
{
    //From left to right
    for (int i = left; i <= right; i++)
    {
        spiralOrder.Add(numbers[left, i]);
    }
    top++;
    //From top to bottom
    for (int i = top; i <= bottom; i++)
    {
        spiralOrder.Add(numbers[i, right]);
    }
    right--;
    if (top <= bottom && left <= right)
    {
        //From right to left
        for (int i = right; i >= left; i--)
        {
            spiralOrder.Add(numbers[bottom, i]);
        }
        bottom--;
        //From bottom to top
        for (int i = bottom; i >= top; i--)
        {
            spiralOrder.Add(numbers[i, left]);
        }
        left++;
    }
}

foreach (var num in spiralOrder)
{
    Console.Write(num + " ");
}
