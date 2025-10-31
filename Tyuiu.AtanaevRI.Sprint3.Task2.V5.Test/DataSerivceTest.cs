using Tyuiu.AtanaevRI.Sprint3.Task2.V5.Lib;
namespace Tyuiu.AtanaevRI.Sprint3.Task2.V5.Test
{
    [TestClass]
    public sealed class DataSerivceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            double value = 0.75;
            int stopValue =20 ;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(0.332,res);
        }
    }
}
