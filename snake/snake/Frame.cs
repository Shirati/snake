using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Frame : ItemInBoard
    {
        public const int FRAME_HEIGHT = 25;
        public const int FRAME_WIDTH = 50;

        public Frame(Board myboard) : base(myboard)
        {
            MyChar = ' ';
            MyColor = ConsoleColor.Gray;
            MyBackColor = ConsoleColor.Gray;
        }
        protected override void InitItem()
        {
            for (int i = 1; i < FRAME_WIDTH; i++)
            {
                // למעלה
                MyPlaces.Add(new Place(1, i));
                // למטה
                MyPlaces.Add(new Place(FRAME_HEIGHT + 3, i));

            }
            for (int i = 1; i <= FRAME_HEIGHT + 3; i++)
            {
                // שמאל
                MyPlaces.Add(new Place(i, 1));
                MyPlaces.Add(new Place(i, 2));

                // ימין
                MyPlaces.Add(new Place(i, FRAME_HEIGHT * 2));
                MyPlaces.Add(new Place(i, FRAME_HEIGHT * 2 + 1));
            }
        }
    }
}
