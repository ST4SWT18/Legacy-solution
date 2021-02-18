using System;

namespace Legacy_solution
{
    internal class TempSensor:ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            Temp= gen.Next(-5, 45);
            return Temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }

        public int Temp { get; set; }
    }
}