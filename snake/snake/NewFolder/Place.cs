using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Place
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Place(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(ConsoleKey dir)
        {
            if (dir == ConsoleKey.RightArrow)
                Y++;
            else if (dir == ConsoleKey.LeftArrow)
                Y--;
            else if (dir == ConsoleKey.UpArrow)
                X--;
            else
                X++;
        }

        public bool Equals(List<Place> places)
        {
            foreach (var item in places)
            {
                if (Equals(item))
                    return true;
            }
            return false;
        }
        public bool Equals(Place p)
        {
            return (p.X == X && p.Y == Y);
        }
        public override string ToString()
        {
            return "x: " + X + " y: " + Y;
        }

    }
}
