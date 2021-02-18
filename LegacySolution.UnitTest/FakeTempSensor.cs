using Legacy_solution;

namespace LegacySolution.UnitTest
{
    public class FakeTempSensor:ITempSensor
    {
        public int Temp{ get; set; }

        public int GetTemp()
        {
            return -5;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}