using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = ("C:/Users/marve/Desktop/Рисунки/Работа");
            if (Directory.Exists(path))
            {
                Console.WriteLine("Папки:");
                string[] Directories = Directory.GetDirectories(path);
                foreach (string d in Directories)
                {
                    Console.WriteLine(d);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] Files = Directory.GetFiles(path);
                foreach (string f in Files)
                {
                    Console.WriteLine(f);
                }
                Console.WriteLine();
                foreach (string d in Directories)
                {
                    Console.WriteLine("Подпапки {0}:", d);
                    string[] SubDirectories = Directory.GetDirectories(d);
                    foreach (string sd in SubDirectories)
                    {
                        Console.WriteLine(sd);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Файлы подпапки {0}:", d);
                    string[] SubFiles = Directory.GetFiles(d);
                    foreach (string sf in SubFiles)
                    {
                        Console.WriteLine(sf);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
