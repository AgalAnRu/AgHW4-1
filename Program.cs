using System;

namespace AgHW4_1
{
    internal class Program
    {
        static string promtPressAnyKey = "Нажмите любую клавишу для продолжения...";
        //private static GetInput getInput = new GetInput();
        private static Random rnd = new Random();
        delegate void method();
        static string[] menuMainItems = new string[5];
        static string[] menuFoursItems = new string[7];
        static AgMenu menuMain = new AgMenu(menuMainItems);
        static AgMenu menuFours = new AgMenu(menuFoursItems);
        static method[] methodsHW4 = new method[] { HomeWork4.DoTask1, HomeWork4.DoTask2,
                                                    HomeWork4.DoTask3, HomeWork4.DoTask4,
                                                    HomeWork4.DoTask5, HomeWork4.DoTask6,
                                                    PreviousScreen};
        static void Main(string[] args)
        {
            MenuInitialization();

            //int selectedMenuItem;
            //AgMenu menuMain = new AgMenu(menuMainItems);

            ShowMainScreen();

        }
        static void MenuInitialization()
        {
            menuMainItems[0] = "Урок 1";
            menuMainItems[1] = "Урок 2";
            menuMainItems[2] = "Урок 3";
            menuMainItems[3] = "Урок 4";
            menuMainItems[4] = "Выход";

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
                    ShowFirstScreen();
                    break;
                case 1:
                    ShowSecondScreen();
                    break;
                case 2:
                    ShowThirdScreen();
                    break;
                case 3:
                    ShowFoursScreen();
                    break;
                default:
                    break;
            }

        }
        static void ShowFirstScreen()
        {
            Console.WriteLine("Раздел в разработке (выберите другой пункт)");
            Console.ReadKey();
            ShowMainScreen();
        }
        static void ShowSecondScreen()
        {
            Console.WriteLine("Раздел в разработке (выберите другой пункт)");
            Console.ReadKey();
            ShowMainScreen();
        }
        static void ShowThirdScreen()
        {
            Console.WriteLine("Раздел в разработке (выберите другой пункт)");
            Console.ReadKey();
            ShowMainScreen();
        }
        static void ShowFoursScreen()
        {
            int selectedMenuItem = 0;
            do
            {
                selectedMenuItem = menuFours.GetSelectedMenuItem();
                Console.Clear();
                methodsHW4[selectedMenuItem]();
                if (selectedMenuItem == menuFoursItems.Length - 1)
                    continue;
                NextScreen();
            } while (selectedMenuItem != menuFoursItems.Length - 1);
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
