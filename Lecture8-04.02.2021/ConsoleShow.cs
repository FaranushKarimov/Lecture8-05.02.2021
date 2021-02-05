using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture8_04._02._2021
{
    public static class ConsoleShow
    {
        public static void ShowTable(string tempId, string tempFirst, string tempSecond, string tempMiddle, string tempDate)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.Write($"{tempId}");
            for (int i = 0; i < tempId.Length - 2; i++)
            {
                System.Console.Write("\t");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write($"\t\t{tempFirst}");

            for (int i = 0; i < 9 - tempFirst.Length; i++)
            {
                System.Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.Write($"\t\t{tempSecond}");

            for (int i = 0; i < 8 - tempSecond.Length; i++)
            {
                System.Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write($"\t\t{tempMiddle}");

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 10 - tempMiddle.Length; i++)
            {
                System.Console.Write(" ");
            }
            System.Console.Write($"\t\t{tempDate}\n");
        }
    }
}
