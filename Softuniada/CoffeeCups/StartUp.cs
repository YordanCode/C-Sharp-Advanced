using System;

namespace CoffeeCups
{
    internal class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine().ToUpper();
            CoffeeCup cup = new CoffeeCup(n, name);
            cup.PrintVapor(n);
            cup.PrintTop(n, name);
            cup.PrintWallsAndCoffee(n);
            cup.PrintBottom(n);
        }
    }
}
}
