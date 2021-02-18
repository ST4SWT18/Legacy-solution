using Legacy_solution;
using NUnit.Framework;

namespace LegacySolution.UnitTest
{
    public class Tests
    {
        private ECS uut;
        private int thr = 30;
        private ITempSensor fakeTempSensor;
        private ITempSensor fakeTempSensorHT;

        [SetUp]
        public void Setup()
        {
            fakeTempSensor = new FakeTempSensor();
            fakeTempSensorHT = new FakeTempSensorHTThr();
            uut = new ECS( thr,new FakeHeaterTrue());
        }

        //[Test]
        //public void ECS_Regulate()
        //{
        //    fakeTempSensor.Temp = 20;
        //    uut.Regulate();

            

        //    //Assert.Multiple(() =>
        //    //{
        //    //    uut.SetThreshold(-5);
        //    //    uut.Regulate();
                
        //    //    Assert.That(uut.Regulate(),);
        //    //});
        //}

        [Test]
        public void ECS_GetCurTemp_45()
        {
            Assert.That(uut.GetCurTemp(fakeTempSensorHT), Is.EqualTo(45));
        }
        [Test]
        public void ECS_GetCurTemp_Minus5()
        {
            Assert.That(uut.GetCurTemp(fakeTempSensor), Is.EqualTo(-5));
        }

        [Test]
        public void ECS_RunSelfTest_True()
        {
            Assert.That(uut.RunSelfTest(fakeTempSensor, new FakeHeaterTrue()), Is.True);
        }

        [Test]
        public void ECS_RunSelfTest_False()
        {
            Assert.That(uut.RunSelfTest(fakeTempSensor, new FakeHeaterFalse()), Is.False);
        }
    }
}