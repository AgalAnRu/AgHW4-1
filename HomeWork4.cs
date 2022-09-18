using System;
namespace AgHW4_1
{
    internal static class HomeWork4
    {
        internal static void DoTask1()
        {
            Console.WriteLine("Задача 1");
            Random rnd = new Random();
            int boxTotal = rnd.Next(5, 11);
            int[] numberBoltsInBox = new int[boxTotal];
            int minValue = 400;
            int maxValue = 100;
            int boxNumber = 1;
            int count = 0;
            AgFillValues afv = new AgFillValues();
            afv.ArrayRandomFill(numberBoltsInBox, 100, 401);
            afv.ArrayPrintAll(numberBoltsInBox);
            minValue = numberBoltsInBox[0];
            foreach (int bolts in numberBoltsInBox)
            {
                count++;
                if (bolts < minValue)
                {
                    minValue = bolts;
                    boxNumber = count;
                }
            }
            Console.WriteLine($"Минимальное количество {minValue} в {boxNumber}-м ящике");

            maxValue = numberBoltsInBox[0];
            count = 0;
            boxNumber = 1;
            foreach (int bolts in numberBoltsInBox)
            {
                count++;
                if (bolts > maxValue)
                {
                    maxValue = bolts;
                    boxNumber = count;
                }
            }
            Console.WriteLine($"Максимальное количество {maxValue} в {boxNumber}-м ящике");

            int boltsTotal = 0;
            foreach (int bolt in numberBoltsInBox)
                boltsTotal += bolt;
            int boltsAverage = boltsTotal / boxTotal;
            Console.WriteLine($"Среднее количество болтов: {boltsAverage}");
            int boltDeference = 400;
            count = 0;
            boxNumber = 1;
            //ЭТУ ЧАСТЬ проверить! считает неправильно
            foreach(int bolt in numberBoltsInBox)
            {
                count++;
                if (boltDeference > (Math.Abs(bolt - boltsAverage)))
                {
                    boltDeference = (Math.Abs(bolt - boltsAverage));
                    boxNumber = count;
                }
            }
            Console.WriteLine($"Близжайшее значение {numberBoltsInBox[boxNumber]} в {boxNumber}-м ящике");
        }
        internal static void DoTask2()
        {
            Console.WriteLine("Задача 2");
        }
        internal static void DoTask3()
        {
            Console.WriteLine("Задача 3");
        }
        internal static void DoTask4()
        {
            Console.WriteLine("Задача 4");
        }
        internal static void DoTask5()
        {
            Console.WriteLine("Задача 5");
        }
        internal static void DoTask6()
        {
            Console.WriteLine("Задача 6");
        }

    }
}
