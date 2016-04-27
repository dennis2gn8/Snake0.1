using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Interface
    {
        public void GuiBuilder()
        {
            int länge = 25;
            int breite = 50;
            Console.WindowHeight = länge;
            Console.WindowWidth = breite;
            char set1 = '║';
            char set2 = '═';
            char set3 = '╔';
            char set4 = '╗';
            char set5 = '╚';
            char set6 = '╝';
            writeborder(1, länge, breite, 1, set1);
            writeborder(1, länge, 0, 1, set1);
            writeborder(1, breite, länge, 2, set2);
            writeborder(1, breite, 0, 2, set2);
            writeborder(0, 1, 0, 2, set3);
            writeborder(50, 51, 0, 2, set4);
            writeborder(0, 1, 25, 2, set5);
            writeborder(50, 51, 25, 2, set6);
        }
        public void InterfaceCreation()
        {
            int länge = 25;
            int breite = 50;
            Console.WindowHeight = länge;
            Console.WindowWidth = breite;
            char set1 = '║';
            char set2 = '═';
            char set3 = '╔';
            char set4 = '╗';
            char set5 = '╚';
            char set6 = '╝';


            writeborder(1, länge, breite, 1, set1);
            writeborder(1, länge, 0, 1, set1);
            writeborder(1, breite, länge, 2, set2);
            writeborder(1, breite, 0, 2, set2);
            writeborder(0, 1, 0, 2, set3);
            writeborder(50, 51, 0, 2, set4);
            writeborder(0, 1, 25, 2, set5);
            writeborder(50, 51, 25, 2, set6);
            writeOption(20, 6, 1);
            writeOption(20, 9, 2);
            writeOption(21, 12, 3);
            writeOption(1, 1, 4);
            writeOption(26, 24, 5);
            Console.ReadKey();

            InterfaceNavigation navigation = new InterfaceNavigation();
            navigation.SetCourserOption();
        }
        static void writeborder(int start, int end, int fix, int vertical, char output)
        {
            for (int i = start; i < end; i++)
            {
                if (vertical == 1)
                {
                    Console.SetCursorPosition(fix, i);
                }
                else if (vertical == 2)
                {
                    Console.SetCursorPosition(i, fix);
                }
                Console.WriteLine(output);
            }
        }

        static void writeOption(int startposition, int endposition, int option)
        {
            //Alternative Switch case :
            Console.ForegroundColor = ConsoleColor.Red;
            if (option == 1)
            {
                Console.SetCursorPosition(startposition, endposition);
                Console.WriteLine("START GAME");
            }
            else if (option == 2)
            {
                Console.SetCursorPosition(startposition, endposition);
                Console.WriteLine("OPTIONS");
            }
            else if (option == 3)
            {
                Console.SetCursorPosition(startposition, endposition);
                Console.WriteLine("EXIT");
            }
            else if (option == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(startposition, endposition);
                Console.WriteLine("Version 1.0 Alpha");
            }
            else if (option == 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(startposition, endposition);
                Console.WriteLine("Created by Dennis Andre");
            }
        }
    }
}
