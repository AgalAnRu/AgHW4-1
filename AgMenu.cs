using System;

namespace AgHW4_1
{
    internal class AgMenu
    {
        string[] menuItems;
        int counter;
        //internal enum EscapeStatus {Off, On}
        internal AgMenu(string[] menuItems) => this.menuItems = menuItems;
        internal int GetSelectedMenuItem()
        {
            counter = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            DrawMenu(counter);
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
        private void DrawMenu(int counter)
        {
            Console.Clear();
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i != counter)
                    Console.WriteLine(menuItems[i]);
                if (i == counter)
                {
                    SetNegativeColor(true);
                    Console.WriteLine(menuItems[i]);
                    SetNegativeColor(false);
                }
            }
            Console.WriteLine("(Выберите пункт меню и нажмите Enter " +
                "или нажмите Escape для выхода)");
        }
        private void RedrawMenuItems(int itemSelected, int itemDeselected)
        {
            Console.SetCursorPosition(0, itemSelected);
            SetNegativeColor(true);
            Console.WriteLine(menuItems[itemSelected]);
            SetNegativeColor(false);
            Console.SetCursorPosition(0, itemDeselected);
            Console.WriteLine(menuItems[itemDeselected]);
        }
        private void SetNegativeColor(bool setNegative = false)
        {
            if (setNegative)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            if (!setNegative)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
