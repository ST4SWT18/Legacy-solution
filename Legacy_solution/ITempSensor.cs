namespace Legacy_solution
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
        //nyt
        public int Temp { get; set; }
    }
}