List<int> list = Console.ReadLine().Split(' ').
                Select(int.Parse).ToList();

Console.WriteLine(ArraySum(list, 0));
int ArraySum(List<int> list, int currentIndex)
{
    if (currentIndex >= list.Count)
        return 0; // Base case: when there are no more elements in the array
    else
    {
        int currentElement = list[currentIndex];

        int sumOfNextElements = ArraySum(list, currentIndex + 1);
        return currentElement + sumOfNextElements;
    }
}
