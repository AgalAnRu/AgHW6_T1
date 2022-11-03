using System;

namespace AgHW6_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = GetSentence();
            int numberChar = GetNumberChar();
            char[] charToFind = GetCharsToFind(numberChar);
            PrintResult(sentence, charToFind);
            Console.ReadKey();
        }
        static string GetSentence()
        {
            string userString = string.Empty;
            char userChar;
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            Console.WriteLine("Введите предложение:");
            do
            {
                cki = Console.ReadKey(true);
                userChar = cki.KeyChar;
                if (IsLegacyChar(userChar))
                {
                    userString += userChar;
                    Console.Write(userChar);
                }
                if (cki.Key == ConsoleKey.Backspace && userString.Length != 0)
                {
                    userString = userString.Remove(userString.Length - 1);
                    Console.Write("\b \b");
                }
            }
            while (cki.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return userString;
        }
        static int GetNumberChar()
        {
            int numberChar = GetInt32("Введите количество символов для поиска", minValue: 1, maxValue: 100);
            return numberChar;
        }
        static char[] GetCharsToFind(int arrayLength)
        {
            char userChar;
            char[] charsToFind = new char[arrayLength];
            Console.WriteLine($"Введите {arrayLength} символов для поиска");
            for (int i = 0; i < charsToFind.Length; i++)
            {
                userChar = Console.ReadKey(true).KeyChar;
                if (!IsLegacyChar(userChar))
                    i--;
                else
                {
                    Console.Write(userChar);
                    charsToFind[i] = userChar; 
                }
                //Ентер возвращает в начало строки!
            }
            return charsToFind;
        }
        static void PrintResult(string sentense, char[] charToFind)
        {
            //find
            //print
        }
        static bool IsLegacyChar(char ch)
        {
            if (Char.IsLetter(ch) || Char.IsPunctuation(ch) || Char.IsWhiteSpace(ch))
                return true;
            return false;
        }
        static int GetInt32(string prompt = "", int minValue = Int32.MinValue, int maxValue = Int32.MaxValue)
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
