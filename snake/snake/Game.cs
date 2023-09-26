using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace snake
{
    class Game
    {
        private readonly int MAX_NUM_OF_TRYINGS = 3;
        private readonly ConsoleKey DFFAULT_DIR = ConsoleKey.RightArrow;
        private readonly int TIME_TO_SLEEP = 100;

        private Board myBoard;

        private ConsoleKey current_dir;
        private int currner_try;
        private Place currentPlace;

        public Game()
        {
            myBoard = new Board();
            currner_try = 0;
            currentPlace = myBoard.SnakeHeadPlace();

        }
        private void Mistake()
        {
            currner_try++;
            Console.SetCursorPosition(60, 20);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER!!!!");
            Console.SetCursorPosition(60, 23);
            Console.WriteLine($"You have more {MAX_NUM_OF_TRYINGS - currner_try} tries");
            Thread.Sleep(1000);
        }

        public void StartGame()
        {
            bool flag = false;
            PlaceStatus status;

            myBoard.PrintBoard();
            while (currner_try < MAX_NUM_OF_TRYINGS)
            {
                while (true)
                {
                    // שינוי כיוון
                    if (Console.KeyAvailable)
                        current_dir = Console.ReadKey().Key;
                    // הזזת הנחש
                    currentPlace.Move(current_dir);
                    myBoard.HandleMoveOnBoard(currentPlace, flag);
                    // בדיקה
                    flag = false;
                    status = myBoard.WhatStatus(currentPlace);
                    if (status == PlaceStatus.INVALID)
                    {
                        Mistake();
                        break;
                    }
                    if (status == PlaceStatus.DOLLAR)
                    {
                        flag = true;
                        myBoard.RefreshDollar();
                    }
                    Sleep();

                }
                myBoard.Refresh();
                current_dir = DFFAULT_DIR;
                currentPlace = myBoard.SnakeHeadPlace();

            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.SetCursorPosition(15, 15);
            Console.CursorSize = 40;
            Console.WriteLine("THE SNAKE DIED :(");
        }
        private void Sleep()
        {
            {
                Thread.Sleep(200);
            }



        }
    }
}