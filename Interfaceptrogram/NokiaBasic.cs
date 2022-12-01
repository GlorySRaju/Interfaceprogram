using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaceptrogram
{
    class NokiaBasic : INormalPhone
    {
        public void Call()
        {
            Console.WriteLine("call Works");
        }

        public void Message()
        {
            Console.WriteLine("Message Works");
        }
    }
}
