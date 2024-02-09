using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestingTask;
namespace Testing_Task_Test
{
    [TestClass]
    public class WeightCalculator
    {
        [TestMethod]
        public void GetWeight_m_180_72_5()
        {
            WeightCalculator sut = new WeightCalculator
            {
                Height = 180,
                Gender = 'm'

            };

            double actual = sut.GetWeight();
            double expected = 72.5;

            Assert.AreEqual(expected, actual);
        }
    }
}
