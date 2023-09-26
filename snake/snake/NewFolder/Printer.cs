using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    static class Printer
    {
        public static void PrintItem(List<Place> places, char charToPrint, ConsoleColor color, ConsoleColor bColor)
        {
            foreach (Place item in places)
            {
                Console.SetCursorPosition(item.Y, item.X);
                Console.ForegroundColor = color;
                Console.BackgroundColor = bColor;
                Console.Write(charToPrint);
            }
        }

        public static void PrintItem(Place place1, char charToPrint, ConsoleColor color,ConsoleColor bColor)
        {
            Console.SetCursorPosition(place1.Y, place1.X);
            Console.ForegroundColor = color;
            Console.BackgroundColor = bColor;
            Console.Write(charToPrint);
        }

        public static void DeleteItem(List<Place> places)
        {
            Console.BackgroundColor = ConsoleColor.Black;

            foreach (Place item in places)
            {
                Console.SetCursorPosition(item.Y, item.X);
                Console.Write(" ");
            }
        }

        public static void DeleteItem(Place place1)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(place1.Y, place1.X);
            Console.Write(" ");
        }












    }
}
