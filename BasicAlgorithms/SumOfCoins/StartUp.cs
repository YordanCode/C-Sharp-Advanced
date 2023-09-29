using System;
using System.Collections.Generic;
using System.Linq;

List<int> coins = Console.ReadLine().Split(", ").
    Select(int.Parse).ToList();
List<int> coinsReturned = new();
int desiredSum = int.Parse(Console.ReadLine());

int change = 0;
Dictionary<int, int> coinsValueAndCoinsCount = new();
coins = coins.OrderByDescending(x => x).ToList();

while (change < desiredSum || change + coins[coins.Count - 1]
    <= desiredSum)
{
    for (int i = 0; i < coins.Count; i++)
    {
        if (change + coins[i] <= desiredSum)
        {
            if (!coinsValueAndCoinsCount.ContainsKey(coins[i]))
            {
                coinsValueAndCoinsCount[coins[i]] = 0;
            }
            coinsValueAndCoinsCount[coins[i]]++;
            change += coins[i];
            break;
        }
    }
}
if (desiredSum > change)
{
    Console.WriteLine("Error");
    return;
}
Console.WriteLine($"Number of coins to take: {coinsValueAndCoinsCount.Values.Sum()}");
foreach (var coin in coinsValueAndCoinsCount)
{
    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
}