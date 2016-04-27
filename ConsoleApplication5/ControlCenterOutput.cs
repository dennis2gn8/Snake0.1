using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class ControlCenterOutput
    {
        public int YMove { set; get; }
        public int XMove { set; get; }
        public int YSnakeMove { get;  set; }
        public int XSnakeMove { get;  set; }

        public void Movement()
        {
            ConsoleKeyInfo k = Console.ReadKey();
            if (k.Key == ConsoleKey.UpArrow)
            {
                YMove = -1;
            }
            else if (k.Key == ConsoleKey.DownArrow)
            {
                YMove = 1;
            }
            else if (k.Key == ConsoleKey.LeftArrow)
            {
                XMove = -1;

            }
            else if (k.Key == ConsoleKey.RightArrow)
            {
                XMove = 1;
            }
            else if (k.Key == ConsoleKey.Enter)
            {
                XMove = 2;
            }
        }
        public void SnakeMovement()
        {
            ConsoleKeyInfo k = Console.ReadKey();
            if (k.Key == ConsoleKey.UpArrow)
            {
                YSnakeMove = -1;
            }
            else if (k.Key == ConsoleKey.DownArrow)
            {
                YSnakeMove = 1;
            }
            else if (k.Key == ConsoleKey.LeftArrow)
            {
                XSnakeMove = -1;

            }
            else if (k.Key == ConsoleKey.RightArrow)
            {
                XSnakeMove = 1;
            }
            else if (k.Key == ConsoleKey.End)
            {
                XSnakeMove = 4;
            }
        }
    }
}

