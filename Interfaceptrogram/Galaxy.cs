using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaceptrogram
{
    class Galaxy : INormalPhone, ISmartPhone
    {
        public void Call()
        {
            Console.WriteLine("call Works");
        }

        public void Message()
        {
            Console.WriteLine("Message Works");
        }

        public void MultiMediaMsg()
        {
            Console.WriteLine("MultiMedia-Message Works");
        }
    }
}
