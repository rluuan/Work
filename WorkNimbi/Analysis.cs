using System;
using System.Collections.Generic;
using System.Text;

namespace WorkNimbi {
    class Analysis {

        public DateTime startTime;
        Commit commit = new Commit();

        public Analysis() {
            
        }
        public void StartTime() {
            string text;

            do {
                Console.Write("What are you analyzing?: ");
                text = Console.ReadLine();
            } while (text == "");
            

            startTime = DateTime.Now;
            Console.Write("Finish (Press Enter)?: ");
            Console.ReadKey();
            Console.Write("");

            commit.CrateCommitLine($"Foi gasto {Math.Abs((startTime - DateTime.Now).Minutes)} minutos analisando {text}");
        }
    }
}
