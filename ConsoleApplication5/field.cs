using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

    class Field
    {

        InterfaceNavigation navigation = new InterfaceNavigation();

        public void Gamingfeld()
        {
            
            Console.WindowWidth = 100;
            Console.WindowHeight = 50;
            char border = 'X';
            string row = new String(border, Console.WindowWidth);
            Console.Write(row);
            Console.SetCursorPosition(0, Console.WindowHeight - 2);
            Console.Write(row);
                   for (int borderY = 0; borderY < Console.WindowHeight - 2; borderY++)
            {
                Console.SetCursorPosition(0, borderY);
                Console.Write(border.ToString());
                Console.SetCursorPosition(Console.WindowWidth - 1, borderY);
                Console.Write(border.ToString());
                
            }
            navigation.SnakeNavigation();
        }
    }
}
