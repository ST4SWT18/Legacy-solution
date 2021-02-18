using Legacy_solution;

namespace LegacySolution.UnitTest
{
    public class FakeTempSensorHTThr:ITempSensor
    {
        public int GetTemp()
        {
            return 45;
        }

        public bool RunSelfTest()
        {
            throw new System.NotImplementedException();
        }

        public int Temp { get; set; }
    }
}