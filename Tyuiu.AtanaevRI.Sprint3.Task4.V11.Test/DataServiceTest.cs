using Tyuiu.AtanaevRI.Sprint3.Task4.V11.Lib;
namespace Tyuiu.AtanaevRI.Sprint3.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(0.84, res);
        }
    }
}
