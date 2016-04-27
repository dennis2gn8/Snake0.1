using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Exit
    {
        public void Leaver()
        {
            Console.Clear();
            Interface gui = new Interface();
            gui.GuiBuilder();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Wollen Sie das Spiel wirklich verlassen?");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("[JA/NEIN]");
            Console.SetCursorPosition(23, 8);
            string antwort = Console.ReadLine();
            antwort = antwort.ToLower();
            if (antwort == "ja")
            {
                Environment.Exit(0);
            }
            else if (antwort == "nein")
            {
                Console.Clear();
                Interface inverface = new Interface();
                inverface.InterfaceCreation();
            }
        }
    }
}
