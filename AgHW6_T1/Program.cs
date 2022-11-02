using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgHW6_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = GetSentence();
            int numberChar = GetNumberChar();
            char[] charToFind = new char[numberChar];
            PrintResult(sentence, charToFind);
            Console.ReadKey();
        }
        static string GetSentence()
        {
            string userString = string.Empty;
            //input string
            return userString;
        }
        static int GetNumberChar()
        {
            int numberChar = 0;
            //input int
            return numberChar;
        }
        static char[] GetCharsToFind(int arrayLength)
        {
            char[] charsToFind = new char[arrayLength];
            for (int i = 0; i < charsToFind.Length; i++)
            {
                //input chars
            }
            return charsToFind;
        }
        static void PrintResult(string sentense, char[] charToFind)
        {
            //find
            //print
        }
    }
}
