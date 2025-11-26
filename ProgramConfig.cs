using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProgramConfig
    {
        public const string version = "1.0.0";
        public const string DeveloperName = "Linux";

        public static void ProgramInfo()
        {
            Console.WriteLine($"Весрия: {version} , разработчик: {DeveloperName}");
        }
    }
}
