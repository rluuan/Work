using System;

namespace WorkNimbi {



    class Program {
        static void Main(string[] args) {
            int number;

            StartMenuConsole.CreateScreenInitial();

            Commit createCommit = new Commit();
            Analysis analysis = new Analysis();

            while (true) {
                Console.WriteLine("");
                Console.Write("Option: ");
                int.TryParse(Console.ReadLine(), out number);

                if (number > 10 || number < 0 || number == 0) continue;

                switch (number) {
                    case 1: createCommit.Quiz();
                        break;
                    case 2: analysis.StartTime();
                        break;

                }
                Console.Clear();
                StartMenuConsole.CreateScreenInitial();

            }
            
        }
    }
}
