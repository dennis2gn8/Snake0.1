using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ConsoleApplication5
{
    class Options
    {
        public void SelectOptions()
        {
            Console.Clear();
            Interface gui = new Interface();
            gui.GuiBuilder();
            Console.SetCursorPosition(2,3);
            Console.WriteLine("Dieser Bereich befindet");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("sich noch in der Entwicklung");
            Thread.Sleep(5000);
            Console.Clear();
            Interface inverface = new Interface();
            inverface.InterfaceCreation();


        }

    }
}
