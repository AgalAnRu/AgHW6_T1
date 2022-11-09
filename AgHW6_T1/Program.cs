using System;
using System.Collections.Generic;

namespace AgHW6_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = GetSentence();
            List<char> charToFind = GetCharsToFind();
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
        static List<char> GetCharsToFind()
        {
            List<char> charsToFind = new List<char>();
            char userChar;
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            Console.WriteLine("Введите символы для поиска и нажмите Enter:");
            do
            {
                cki = Console.ReadKey(true);
                userChar = cki.KeyChar;
                if (cki.Key == ConsoleKey.Enter)
                    continue;
                if (IsLegacyChar(userChar))
                {
                    charsToFind.Add(userChar);
                    Console.Write(userChar);
                }
            }
            while (cki.Key != ConsoleKey.Enter || charsToFind.Count == 0);
            Console.WriteLine();
            return charsToFind;
        }
        static void PrintResult(string sentense, List<char> charToFind)
        {
            int numberChars = 0;
            Console.WriteLine("Количество вхождений символов:");
            foreach (char ch in charToFind)
            {
                numberChars = GetNumberChars(sentense, ch);
                Console.WriteLine($"{ch} - {numberChars}");
            }
        }
        static int GetNumberChars(string sentense, char ch)
        {
            int numberChars = 0;
            int lastCharIndex = - 1;
            do
            {
                lastCharIndex = sentense.IndexOf(ch, lastCharIndex + 1);
                if (lastCharIndex != -1)
                    numberChars++;
            }
            while (lastCharIndex != -1);
            return numberChars;
        }
        static bool IsLegacyChar(char ch)
        {
            if (Char.IsLetter(ch) || Char.IsPunctuation(ch) || Char.IsWhiteSpace(ch))
                return true;
            return false;
        }
    }
}
