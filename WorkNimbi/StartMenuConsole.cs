using System;
using System.Collections.Generic;
using System.Text;

namespace WorkNimbi {
    class StartMenuConsole {

        public static void CreateScreenInitial() {
            Console.Title = "RLUAN 1.0";
            Console.SetWindowSize(70, 20);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------- Menu @RLUANX ----------------");

            Console.WriteLine("      Choose an option and press ENTER       ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("| 1. Create log commit                      |");
            Console.WriteLine("| 2. Start an analysis                      |");
            Console.WriteLine(" --------------------------------------------");
            Console.ResetColor();
        }

    }
}
