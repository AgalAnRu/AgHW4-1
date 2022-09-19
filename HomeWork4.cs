using System;
namespace AgHW4_1
{
    internal static class HomeWork4
    {
        private static readonly Random rnd = new Random();
        internal static void DoTask1()
        {
            Console.WriteLine("Задача 1");
            int boxTotal = rnd.Next(5, 51);
            int[] numberBoltsInBox = new int[boxTotal];
            int minValue;
            int maxValue;
            int boxNumber = 1;
            int count = 0;
            AgFillValues.ArrayRandomFill(numberBoltsInBox, 100, 400);
            AgFillValues.ArrayPrintAll(numberBoltsInBox);
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
            foreach (int bolt in numberBoltsInBox)
            {
                count++;
                if (boltDeference > (Math.Abs(bolt - boltsAverage)))
                {
                    boltDeference = (Math.Abs(bolt - boltsAverage));
                    boxNumber = count;
                }
            }
            Console.WriteLine($"Близжайшее значение {numberBoltsInBox[boxNumber - 1]} в {boxNumber}-м ящике");
        }
        internal static void DoTask2()
        {
            Console.WriteLine("Задача 2");
            int sizeN = AgGetValueFromInput.GetInt32("N-размер матрицы", 1);
            int sizeM = AgGetValueFromInput.GetInt32("M-размер матрицы", 1);
            int[,] matrix = new int[sizeN, sizeM];
            AgFillValues.ArrayRandomFill(matrix, 1, 20);
            Console.WriteLine($"Исходная матрица [{sizeN}x{sizeM}]: ");
            AgFillValues.ArrayPrintMatrix(matrix);
            Console.WriteLine($"Зеркальная (относительно главной диагонали матрица: ");
            PrintMirrorMatrix(matrix);
        }
        internal static void DoTask3()
        {
            Console.WriteLine("Задача 3");
            int vagonsTotal = AgGetValueFromInput.GetInt32("число вагонов", 0);
            int[] passangers = new int[vagonsTotal];
            int passangersTotal = 0;
            const int ROLL_LENGTH = 100;
            const double COMPLECT_LENGTH = 8;
            double rollTotal;
            AgFillValues.ArrayRandomFill(passangers, 0, 36);
            //AgFillValues.ArrayPrintAll(passangers);
            
            foreach (int passanger in passangers)
                passangersTotal += passanger;
            rollTotal = passangersTotal * COMPLECT_LENGTH / ROLL_LENGTH;
            Console.WriteLine($"Потребуется {rollTotal} рулонов ткани ");
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
        private static void PrintMirrorMatrix(int[,] matrix)
        {
            int nSize = matrix.GetLength(0);
            int mSize = matrix.GetLength(1);
            int minSize = (mSize < nSize) ? mSize : nSize;
            for (int n = 1; n <= minSize; n++)
            {
                for (int m = 1; m <= minSize; m++)
                {
                    Console.Write($"{matrix[n - 1, m - 1]}\t");
                }
                if (nSize == minSize)
                    Console.WriteLine();
                else
                {
                    for (int i = minSize + 1; i <= nSize; i++)
                    {
                        Console.Write($"{matrix[i - 1, n - 1]}\t");
                    }
                    Console.WriteLine();
                }
            }
            if (mSize > minSize)
            {
                for (int m = minSize + 1; m <= mSize; m++)
                {
                    for (int n = 1; n <= nSize; n++)
                    {
                        Console.Write($"{matrix[n - 1, m - 1]}\t");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
