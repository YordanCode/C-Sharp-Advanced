using System;
using System.Linq;


int arrayLenght = int.Parse(Console.ReadLine());

int[] numbers = Console.ReadLine().Split(' ').
            Select(int.Parse).ToArray();
int swapNumber = 0;
int swapNumberTwo = 0;

for (int i = 0; i < arrayLenght - 1; i++)
{
    if (i % 2 == 0)
    {
        if (numbers[i] >= numbers[i + 1])
            continue;
        else
        {
            swapNumber = numbers[i];
            swapNumberTwo = numbers[i + 1];
            numbers[i + 1] = swapNumber;
            numbers[i] = swapNumberTwo;
        }
    }
    else
    {
        if (numbers[i] <= numbers[i + 1])
            continue;
        else
        {
            swapNumber = numbers[i];
            swapNumberTwo = numbers[i + 1];
            numbers[i + 1] = swapNumber;
            numbers[i] = swapNumberTwo;
        }
    }
}
Console.WriteLine(string.Join(" ", numbers));









