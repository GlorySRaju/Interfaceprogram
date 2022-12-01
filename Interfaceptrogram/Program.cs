using System;

namespace Interfaceptrogram

{ 
    class Program
    {
        static void Main(string[] args)
        {
            var nokia = new NokiaBasic();
            nokia.Call();

            var galaxy = new Galaxy();
            galaxy.Call();
            galaxy.MultiMediaMsg();
        }
    }
    
}
