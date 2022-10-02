using System;

namespace AgHW4_1
{
    internal class Program
    {
        static string promtPressAnyKey = "Нажмите любую клавишу для продолжения...";
        //private static GetInput getInput = new GetInput();
        private static Random rnd = new Random();
        delegate void methods();
        static string[] menuMainItems = new string[5];
        static string[] menuThirdItems = new string[5];
        static string[] menuFoursItems = new string[7];
        static AgMenu menuMain = new AgMenu(menuMainItems, 5);
        static AgMenu menuThird = new AgMenu(menuThirdItems, 5);
        static AgMenu menuFours = new AgMenu(menuFoursItems, 5);
        static methods[] methodsHW3 = new methods[] { HomeWork3.DoTask1, HomeWork3.DoTask2,
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

            menuThirdItems[0] = "Задание 1";
            menuThirdItems[1] = "Задание 2";
            menuThirdItems[2] = "Задание 3";
            menuThirdItems[3] = "Задание 4";
            menuThirdItems[4] = "<<Возврат";

            menuFoursItems[0] = "Задание 1";
            menuFoursItems[1] = "Задание 2";
            menuFoursItems[2] = "Задание 3";
            menuFoursItems[3] = "Задание 4";
            menuFoursItems[4] = "Задание 5";
            menuFoursItems[5] = "Задание 6";
            menuFoursItems[6] = "<<Возврат";
        }
        static void ShowMainScreen()
        {
            int selectedMenuItem = 0;
            selectedMenuItem = menuMain.GetSelectedMenuItem();
            switch (selectedMenuItem)
            {
                case 0:
                    ShowUnderConstractionScreen();
                    break;
                case 1:
                    ShowUnderConstractionScreen();
                    break;
                case 2:
                    ShowSecondScreen(menuThird, menuThirdItems, methodsHW3);
                    break;
                case 3:
                    ShowSecondScreen(menuFours, menuFoursItems, methodsHW4);
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
        static void _ShowSecondScreen()
        {
            Console.WriteLine("Раздел в разработке (выберите другой пункт)");
            Console.ReadKey();
            ShowMainScreen();
        }
        static void QuitFromConsole()
        {
            //NextScreen();
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
