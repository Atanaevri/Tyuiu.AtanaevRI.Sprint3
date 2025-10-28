using Tyuiu.AtanaevRI.Sprint3.Task0.V15.Lib;
namespace Tyuiu.AtanaevRI.Sprint3.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1 ;
            int stopValue = 10;
            double value = 5;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(-46822475, 308, res);
        }
    }
}
