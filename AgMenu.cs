using System;

namespace AgHW4_1
{
    internal class AgMenu
    {
        string[] menuItems;
        int counter;
        internal AgMenu(string[] menuItems) => this.menuItems = menuItems;
        internal int GetSelectedMenuItem()
        {
            ConsoleKey key;
            do
            {
                Console.Clear();
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == counter)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(menuItems[i]);
                    if (i == counter)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("(Выберите пункт меню и нажмите Enter " +
                    "или нажмите Escape для выхода)");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.DownArrow)
                {
                    counter++;
                    if (counter == menuItems.Length)
                        counter = 0;
                }
                if (key == ConsoleKey.UpArrow)
                {
                    counter--;
                    if (counter == -1)
                        counter = menuItems.Length - 1;
                }
            } while (key != ConsoleKey.Enter && key != ConsoleKey.Escape);
            if (key == ConsoleKey.Escape)
                counter = menuItems.Length - 1;
            return counter;
        }
    }
}
