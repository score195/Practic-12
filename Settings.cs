using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Settings
    {
        private static readonly string configPath;

        static Settings()
        {
            configPath = "C:\\Program Files\\settings\\config.txt";
        }
        public static void PrintConfigPath()
        {
            Console.WriteLine($"Путь к файлу конфигурации: {configPath}");
        }
    }
}
