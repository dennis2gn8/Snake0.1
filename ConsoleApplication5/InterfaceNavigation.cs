using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class InterfaceNavigation
    {
        public void SetCourserOption()
        {
            
            int width = 18;
            int height = 6;

            while (true)
            {
                ControlCenterOutput controlCenterOut = new ControlCenterOutput();
                Console.SetCursorPosition(width, height);
                controlCenterOut.Movement();
                if (height == 6 && controlCenterOut.XMove == 2)
                {
                    Console.Clear();
                    Field gamefield = new Field();
                    gamefield.Gamingfeld();
                }
                else if (height == 9 && controlCenterOut.XMove == 2)
                {
                    Options options = new Options();
                    options.SelectOptions();
                }
                else if (height == 12 && controlCenterOut.XMove == 2)
                {
                    Exit exit = new Exit();
                    exit.Leaver();
                }
                if (height == 12)
                {
                    height = height - 3;
                    if (controlCenterOut.YMove == -1)
                    {
                        height = height - 3;
                    }
                }

                if (controlCenterOut.YMove == 1)
                {

                    height = height + 3;
                    if (height == 3)
                    {
                        height = height + 3;
                    }
                }

            }
        }
        public void SnakeNavigation()
        {

            int width = 50;
            int height = 25;
            while (true)
            {
                ControlCenterOutput controlCenterOut = new ControlCenterOutput();
                Console.SetCursorPosition(width, height);
                Console.ForegroundColor = ConsoleColor.Yellow;

  
                controlCenterOut.SnakeMovement();
                if (controlCenterOut.YSnakeMove == 1)
                {
                    height = height + 1;
                }
                if (controlCenterOut.YSnakeMove == -1)
                {
                    height = height - 1;
                }
                 if (controlCenterOut.XSnakeMove == -1)
                {
                    width = width - 1;
                }
                if (controlCenterOut.XSnakeMove == 1)
                {
                    width = width + 1;
                }
                if (controlCenterOut.XSnakeMove == 4)
                {
                    Console.Clear();
                    Interface gui = new Interface();
                    gui.GuiBuilder();
                    Console.SetCursorPosition(3, 6);
                    Console.WriteLine("Spiel Beendet");
                    Console.ReadLine();
                    Console.Clear();
                    gui.InterfaceCreation();
                }     
            }
        }
    }
}
