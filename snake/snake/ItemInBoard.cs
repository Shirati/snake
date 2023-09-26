using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    abstract class ItemInBoard : Item
    {

        protected virtual Board MyBoard { get; set; }

        protected ItemInBoard(Board myboard)
        {
            MyBoard = myboard;
            InitItem();
        }

        protected abstract void InitItem();
        public void RefreshItem()
        {
            InitItem();
        }
        public bool IsItemInPlace(Place place1)
        {
            foreach (var item in MyPlaces)
            {
                if (item.X == place1.X && item.Y == place1.Y)
                    return true;
            }
            return false;
        }





    }
}
