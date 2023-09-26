using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Dollar : ItemInBoard
    {
        public Dollar(Board myboard) : base(myboard)
        {
            MyChar = ' ';
            MyColor = ConsoleColor.Red;
            MyBackColor = ConsoleColor.Red;

        }

        protected override void InitItem()
        {
            MyPlaces.Clear();
            Random rand = new Random();
            Place p ;
            do
            {
                p = new Place(rand.Next(25) + 2, rand.Next(47)+3);
            }
            while (p.Equals(MyBoard.SnakePlaces()));
            
            MyPlaces.Add(p);
            
            PrintItem();
        }
        public  void NewDollar()
        {
            Random rand = new Random();
            Place p; 
            do
            {
                p = new Place(rand.Next(25) + 2, rand.Next(47)+3);
            }
            while (p.Equals(MyBoard.SnakePlaces()));
            
            MyPlaces.Add(p);

            Printer.DeleteItem(MyPlaces[0]);
            MyPlaces.RemoveAt(0);
            PrintItem();
        }
    }
}
