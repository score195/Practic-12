using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ObjectCounter
    {
        private static int counter = 0;

        public ObjectCounter()
        {
            counter++;
        }
        public static int GetCounter()
        {
            return counter;
        }
    }
}
