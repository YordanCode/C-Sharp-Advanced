using System;
using CoffeeCups;

namespace CoffeeCups
{
    public class CoffeeCup
    {
        private int nextRow;
        public CoffeeCup(int number, string name)
        {
            Number = number;
            Name = name;
        }
        public int Number { get; set; }
        public string Name { get; set; }
        public void PrintBottom(int x)
        {
            string bottom = new string('-', 3 * x + 6 - 1);
            Console.Write(string.Join("", bottom));
        }

        public void PrintWallsAndCoffee(int x)
        {
            int cursorLeftPosition = 0;
            string coffeeVizualization = new string('@', 6 + ((x - 1) * 2));
            nextRow = (x + 3) + (x - 2) + 1;
            for (int i = 0; i < x; i++)
            {
                Console.Write('\\');
                Console.Write(coffeeVizualization);
                coffeeVizualization = coffeeVizualization.Remove(0, 2);
                Console.WriteLine('/');
                cursorLeftPosition++;
                nextRow++;
                if (x - i == 1)
                    Console.SetCursorPosition(0, nextRow);
                else
                    Console.SetCursorPosition(cursorLeftPosition, nextRow);
            }
        }
        public void PrintTop(int x, string name)
        {
            int cursorLeftPosition = 0;
            string firstPartOfTop = new string('=', 3 * x + 6 - 1);
            Console.Write(string.Join("", firstPartOfTop));
            nextRow = x + 3;
            Console.SetCursorPosition(cursorLeftPosition, nextRow);
            for (int i = 0; i < x - 2; i++)
            {
                Console.Write('|');
                string secondPartOfTop = new string('~', (x * 2) + 4);
                if (i == ((x - 2) / 2))
                {
                    secondPartOfTop = secondPartOfTop.Remove(0, name.Length
                        + (x * 2 / 2));
                    Console.Write(string.Join("", secondPartOfTop));
                    Console.Write(name);
                    Console.Write(string.Join("", secondPartOfTop));
                }
                else
                {
                    Console.Write(string.Join("", secondPartOfTop));
                }
                Console.Write('|');
                string secondPartOfTopEmptySpaces = new string(' ', x - 1);
                Console.Write(string.Join("", secondPartOfTopEmptySpaces));
                Console.WriteLine('|');
            }
            Console.WriteLine(string.Join("", firstPartOfTop));
        }
        public void PrintVapor(int x)
        {
            char[] vapor = { '~', '~', '~' };
            for (int i = 0; i < x; i++)
            {
                Console.CursorLeft = x + 1;
                Console.WriteLine(string.Join(" ", vapor));
            }
        }
    }
}
