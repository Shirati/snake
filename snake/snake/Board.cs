using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    enum PlaceStatus { VALID, DOLLAR, INVALID }
    class Board
    {
        private Snake mySnake;
        private Dollar myDollar;
        private Frame myFrame;
        private List<ItemInBoard> itemsInBoard = new List<ItemInBoard>();
        public Board()
        {
            mySnake = new Snake(this);
            myDollar = new Dollar(this);
            myFrame = new Frame(this);
            itemsInBoard.Add(mySnake);
            itemsInBoard.Add(myDollar);
            itemsInBoard.Add(myFrame);
        }

        public void PrintBoard()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (ItemInBoard item in itemsInBoard)
            {
                item.PrintItem();
            }
        }
        public PlaceStatus WhatStatus(Place p)
        {

            if (p.Equals(myDollar.MyPlaces))
            {
                return PlaceStatus.DOLLAR;
            }
            if (p.Equals(myFrame.MyPlaces))
            {
                return PlaceStatus.INVALID;
            }
            List<Place> l = SnakePlaces();
            l.RemoveAt(l.Count-1);
            if (p.Equals(l))
            {
                return PlaceStatus.INVALID;
            }
            return PlaceStatus.VALID;
        }
        public void HandleMoveOnBoard(Place otherplace, bool flag)
        {
            if (flag == true)
            {
                mySnake.Grow(otherplace);
            }
            else mySnake.Move(otherplace);
        }
        public List<Place> SnakePlaces()
        {
            List<Place> l = new List<Place>();
            foreach (var item in mySnake.MyPlaces)
            {
                l.Add(item);
            }
            return l;
        }
        public Place SnakeHeadPlace() { return mySnake.Head; }
        public void Refresh()
        {
            Console.Clear();
            foreach (ItemInBoard item in itemsInBoard)
            {
                item.RefreshItem();
            }
            foreach (ItemInBoard item in itemsInBoard)
            {
                item.PrintItem();
            }
        }
        public void RefreshDollar()


        {
            myDollar.NewDollar();
        }
    }
}
