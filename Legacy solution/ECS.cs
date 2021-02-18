﻿namespace Legacy_solution
{
    public class ECS
    {
        private int _threshold;
        public ITempSensor TempSensor{ get; set; }
        private readonly IHeater _heater;

        public ECS(int thr, IHeater heater)
        {
            SetThreshold(thr);
            TempSensor = new TempSensor();
            _heater = heater;
        }

        public void Regulate()
        {
            var t = TempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return TempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return TempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}