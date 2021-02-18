namespace Legacy_solution
{
    public interface IHeater
    {
        bool RunSelfTest();
        void TurnOn();
        void TurnOff();
    }
}