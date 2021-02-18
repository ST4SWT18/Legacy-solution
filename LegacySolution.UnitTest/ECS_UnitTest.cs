using Legacy_solution;
using NUnit.Framework;

namespace LegacySolution.UnitTest
{
    public class Tests
    {
        private ECS uut;
        private int thr = 30;
        private ITempSensor fakeTempSensor;

        [SetUp]
        public void Setup()
        {
            fakeTempSensor = new FakeTempSensor();
            uut = new ECS( thr,new FakeHeater());
        }

        [Test]
        public void ECS_Regulate()
        {
            fakeTempSensor.Temp = 20;
            uut.Regulate();

            

            //Assert.Multiple(() =>
            //{
            //    uut.SetThreshold(-5);
            //    uut.Regulate();
                
            //    Assert.That(uut.Regulate(),);
            //});
        }
    }
}