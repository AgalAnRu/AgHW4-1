using System;

namespace AgHW4_1
{
    internal class AgMenu
    {
        private ConsoleColor AgMenuBackgroundColor;
        private ConsoleColor AgMenuForegroundColor;
        string[] menuItems;
        int leftPosition = 0;
        int counter;
        internal AgMenu(string[] menuItems, int leftPosition = 0)
        {
            this.menuItems = menuItems;
            this.leftPosition = leftPosition;
        }
        internal int GetSelectedMenuItem()
        {
            counter = menuItems.Length - 1;
            ConsoleKey key;
            Console.CursorVisible = false;
            DrawMenu();
            do
            {
                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.DownArrow)
                {
                    counter++;
                    if (counter == menuItems.Length)
                    {
                        counter = 0;
                        RedrawMenuItems(0, menuItems.Length - 1);
                    }
                    else
                        RedrawMenuItems(counter, counter - 1);
                }
                if (key == ConsoleKey.UpArrow)
                {
                    counter--;
                    if (counter == -1)
                    {
                        counter = menuItems.Length - 1;
                        RedrawMenuItems(counter, 0);
                    }
                    else
                        RedrawMenuItems(counter, counter + 1);
                }
            } while (key != ConsoleKey.Enter && key != ConsoleKey.Escape);
            Console.CursorVisible = true;
            if (key == ConsoleKey.Escape)
                counter = menuItems.Length - 1;
            return counter;
        }
        private void DrawMenu()
        {
            AgMenuBackgroundColor = Console.BackgroundColor;
            AgMenuForegroundColor = Console.ForegroundColor;
            Console.Clear();
            for (int i = 0; i < menuItems.Length - 1; i++)
            {
                Console.SetCursorPosition(leftPosition, i);
                Console.WriteLine(menuItems[i]);
            }
            Console.SetCursorPosition(leftPosition, menuItems.Length - 1);
            SetNegativeColor(true);
            Console.WriteLine(menuItems[menuItems.Length - 1]);
            SetNegativeColor(false);
            Console.WriteLine("(Выберите пункт меню и нажмите Enter " +
                "или нажмите Escape для выхода)");
        }
        private void RedrawMenuItems(int itemSelected, int itemDeselected)
        {
            Console.SetCursorPosition(leftPosition, itemSelected);
            SetNegativeColor(true);
            Console.WriteLine(menuItems[itemSelected]);
            SetNegativeColor(false);
            Console.SetCursorPosition(leftPosition, itemDeselected);
            Console.WriteLine(menuItems[itemDeselected]);
        }
        private void SetNegativeColor(bool setNegative = false)
        {
            if (setNegative)
            {
                Console.BackgroundColor = AgMenuForegroundColor;
                Console.ForegroundColor = AgMenuBackgroundColor;
            }
            if (!setNegative)
            {
                Console.BackgroundColor = AgMenuBackgroundColor;
                Console.ForegroundColor = AgMenuForegroundColor;
            }
        }
    }
}
