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
        internal static int GetTimeHHMM()
        {
            string inputStr = string.Empty;
            char inputChar = ' ';
            int time = 0;
            int digit = 0;
            Console.WriteLine("Введите время в формате hh:mm");
            digit = GetDigit(0, 2);
            time = digit * 600;
            Console.Write(digit);
            if (digit == 2)
                digit = GetDigit(0, 3);
            else
                digit = GetDigit();
            time += digit * 60;
            Console.Write($"{digit} : ");
            digit = GetDigit(0, 5);
            Console.Write(digit);
            time += digit * 10;
            digit = GetDigit();
            Console.WriteLine(digit);
            time += digit;
            return time;
        }
        internal static int GetDigit(int minDigit = 0, int maxDigit = 9)
        {
            char inChar = '0';
            int digit = 0;
            while (true)
            {
                inChar = Console.ReadKey(true).KeyChar;
                if (Char.IsDigit(inChar))
                    digit = Convert.ToInt32(inChar) - 48;
                if (digit >= minDigit && digit <= maxDigit)
                    return digit;
            }
        }
    }
}

