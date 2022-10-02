using System;

namespace AgHW
{
    internal class Program
    {
        static readonly string promtPressAnyKey = "Нажмите любую клавишу для продолжения...";
        delegate void methods();
        static readonly string[] menuMainItems = new string[5];
        static readonly string[] menuHW3Items = new string[5];
        static readonly string[] menuHW4Items = new string[7];
        static readonly AgMenu menuMain = new AgMenu(menuMainItems, 5);
        static readonly AgMenu menuHW3 = new AgMenu(menuHW3Items, 5);
        static readonly AgMenu menuHW4 = new AgMenu(menuHW4Items, 5);
        static readonly methods[] methodsHW3 = new methods[] { HomeWork3.DoTask1, HomeWork3.DoTask2,
                                                    HomeWork3.DoTask3, HomeWork3.DoTask4,
                                                    PreviousScreen};
        static methods[] methodsHW4 = new methods[] { HomeWork4.DoTask1, HomeWork4.DoTask2,
                                                    HomeWork4.DoTask3, HomeWork4.DoTask4,
                                                    HomeWork4.DoTask5, HomeWork4.DoTask6,
                                                    PreviousScreen};
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "VAST C# Learning";
            MenuInitialization();
            ShowMainScreen();
        }
        static void MenuInitialization()
        {
            menuMainItems[0] = "Урок 1";
            menuMainItems[1] = "Урок 2";
            menuMainItems[2] = "Урок 3";
            menuMainItems[3] = "Урок 4";
            menuMainItems[4] = "<Выход";

            menuHW3Items[0] = "Задание 1";
            menuHW3Items[1] = "Задание 2";
            menuHW3Items[2] = "Задание 3";
            menuHW3Items[3] = "Задание 4";
            menuHW3Items[4] = "<<Возврат";

            menuHW4Items[0] = "Задание 1";
            menuHW4Items[1] = "Задание 2";
            menuHW4Items[2] = "Задание 3";
            menuHW4Items[3] = "Задание 4";
            menuHW4Items[4] = "Задание 5";
            menuHW4Items[5] = "Задание 6";
            menuHW4Items[6] = "<<Возврат";
        }
        static void ShowMainScreen()
        {
            int selectedMenuItem = menuMain.GetSelectedMenuItem();
            switch (selectedMenuItem)
            {
                case 0:
                    ShowUnderConstractionScreen();
                    break;
                case 1:
                    ShowUnderConstractionScreen();
                    break;
                case 2:
                    ShowSecondScreen(menuHW3, menuHW3Items, methodsHW3);
                    break;
                case 3:
                    ShowSecondScreen(menuHW4, menuHW4Items, methodsHW4);
                    break;
                default:
                    break;
            }
        }
        static void ShowUnderConstractionScreen()
        {
            Console.Clear();
            Console.WriteLine("Раздел в разработке (выберите другой пункт)");
            Console.ReadKey();
            ShowMainScreen();
        }
        static void ShowSecondScreen(AgMenu menu, Array item, methods[] method)
        {
            int selectedMenuItem = 0;
            do
            {
                selectedMenuItem = menu.GetSelectedMenuItem();
                Console.Clear();
                method[selectedMenuItem]();
                if (selectedMenuItem == item.Length - 1)
                    continue;
                NextScreen();
            } while (selectedMenuItem != item.Length - 1);
            ShowMainScreen();
        }
        static void PreviousScreen()
        {
            Console.Clear();
        }
        static void NextScreen()
        {
            Console.WriteLine(promtPressAnyKey);
            Console.ReadKey();
        }
    }
}
