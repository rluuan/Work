using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;

namespace WorkNimbi {
    class Commit {
        
        private string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/LogsNimbi/";
        private string pathComplete;

        public Commit() {
            pathComplete = desktopPath + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            

            if (!Directory.Exists(desktopPath)) {
                Directory.CreateDirectory(desktopPath);
            }

            
        }
        public void CrateCommitLine(string text) {
            var sw = new StreamWriter(pathComplete, true);
            try {
                sw.WriteLine(text);
                sw.WriteLine("");
                sw.Close();
            } catch (Exception e) {
                Console.WriteLine($"Error, try again. {e.Message}");
            }
            
        }

        public void Quiz() {
            Console.Write("Whats module?: ");
            string module = Console.ReadLine();

            Console.Write("Object Changed?: ");
            string textObject = Console.ReadLine();

            Console.Write("Short description: ");
            string shortDescription = Console.ReadLine();
            Console.Write("");

            var sw = new StreamWriter(pathComplete, true);
            try {
                sw.WriteLine($"No modulo {module} foi alterado a/o {textObject}");
                sw.WriteLine($"(Resumo: {shortDescription})");
                sw.WriteLine("");
                sw.Close();
            } catch (Exception e) {
                Console.WriteLine($"Error, try again. {e.Message}");
            }
            

        }
    }
}
