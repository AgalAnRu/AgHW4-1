using System;
namespace AgHW4_1
{
    internal static class AgGetInput
    {
        internal static int GetInt32(string prompt = "", int minValue = Int32.MinValue, int maxValue = Int32.MaxValue)
        {
            string inputStr = string.Empty;
            while (true)
            {
                Console.WriteLine($"Введите {prompt}");
                Console.Write($"(Целое число от {minValue} до {maxValue}): ");
                inputStr = Console.ReadLine();
                if (int.TryParse(inputStr, out int value))
                    if (value >= minValue && value <= maxValue)
                    {
                        return value;
                    }

            }
        }
    }
}

