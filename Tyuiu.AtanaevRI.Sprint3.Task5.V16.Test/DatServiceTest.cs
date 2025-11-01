using Tyuiu.AtanaevRI.Sprint3.Task5.V16.Lib;
namespace Tyuiu.AtanaevRI.Sprint3.Task5.V16.Test
{
    [TestClass]
    public sealed class DatServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(122,res);

        }
    }
}
