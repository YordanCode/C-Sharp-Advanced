using System;
using System.Collections.Generic;
using System.Linq;

List<int> universe = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToList();
int n = int.Parse(Console.ReadLine());
int[][] sets = new int[n][];

for (int i = 0; i < n; i++)
{
    int[] inputRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    sets[i] = new int[inputRow.Length];
    for (int j = 0; j < inputRow.Length; j++)
    {
        sets[i][j] = inputRow[j];
    }
}
List<int[]> selectedSets = new();
List<int[]> ChooseSets(int[][] sets)
{
    while (universe.Count() > 0)
    {
        int[] longestSet = sets.OrderByDescending(s => s.Count(x => universe.Contains(x))).FirstOrDefault();
        selectedSets.Add(longestSet);
        sets = sets.Where(s => !s.SequenceEqual(longestSet)).ToArray();
        List<int> matchingNums = longestSet.Where(num => universe.Contains(num)).ToList();
        universe.RemoveAll(num => matchingNums.Contains(num));
    }
    return selectedSets;
}
int selectedSetsCount = ChooseSets(sets).Count();
Console.WriteLine($"Sets to take ({selectedSetsCount}):");
for (int i = 0; i < selectedSets.Count; i++)
{
    Console.WriteLine("{ " + string.Join(", ", selectedSets[i]) + " }");
}
