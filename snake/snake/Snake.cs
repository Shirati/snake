using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Snake : ItemInBoard
    {
        private const int SNAKE_BASE_LENGTH = 5;

        private Place head;

        public Place Head
        {
            get
            {
                Place p = new Place(head.X, head.Y);
                return p;
            }
            set
            {
                Place p = new Place(value.X, value.Y);
                head = p;
            }
        }


        public Snake(Board myboard)
            : base(myboard)
        {
            MyChar = ' ';
            MyColor = ConsoleColor.DarkCyan;
            MyBackColor = ConsoleColor.DarkCyan;
        }

        protected override void InitItem()
        {
            int i = 0;
            MyPlaces = new List<Place>();
            for (; i < SNAKE_BASE_LENGTH; MyPlaces.Add(new Place(2, 3 + i)), i++) ;
            head = new Place(MyPlaces[i - 1].X, MyPlaces[i - 1].Y);
        }

        public void Move(Place newPlace)
        {
            //Console.BackgroundColor = ConsoleColor.DarkCyan;
            Head = newPlace;
            MyPlaces.Add(Head);
            Printer.PrintItem(Head, MyChar, MyColor,MyBackColor);
            Printer.DeleteItem(MyPlaces[0]);
            MyPlaces.RemoveAt(0);
        }

        public void Grow(Place newPlace)
        {
            Head = newPlace;
            MyPlaces.Add(Head);
            Printer.PrintItem(MyPlaces, MyChar, MyColor,MyBackColor);

        }
    }
}
