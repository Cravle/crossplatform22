using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container
{
    class ArrEx: Exception
    {

        public ArrEx()
        {

        }

        public ArrEx(string message): base(message)
        {
        }

        public ArrEx(string message, Exception inner): base(message, inner)
        {

        }
    }
}
