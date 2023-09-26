using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    abstract class Item
    {
        protected virtual char MyChar { get; set; }
        protected virtual ConsoleColor MyColor { get; set; } = ConsoleColor.White;
        protected virtual ConsoleColor MyBackColor { get; set; } = ConsoleColor.Black;
        public List<Place> MyPlaces { get; set; } = new List<Place>();


        protected Item(char myChar, ConsoleColor myColor, ConsoleColor myBackColor)
        {
            MyChar = myChar;
            MyColor = myColor;
            MyBackColor = myBackColor;
        }
        protected Item()
        {
        }

        public void PrintItem()
        {
            Printer.PrintItem(MyPlaces, MyChar, MyColor, MyBackColor);
        }
        public void PrintItem(Place p)
        {
            Printer.PrintItem(p, MyChar, MyColor, MyBackColor);
        }
        public void DeleteFromScreen()
        {
            Printer.DeleteItem(MyPlaces);
        }
        static public void DeleteFromScreen(Place p)
        {
            Printer.DeleteItem(p);
        }
    }
}
