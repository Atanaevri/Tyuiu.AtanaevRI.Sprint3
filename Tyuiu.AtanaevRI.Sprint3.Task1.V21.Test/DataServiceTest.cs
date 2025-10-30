using Tyuiu.AtanaevRI.Sprint3.Task1.V21.Lib;
namespace Tyuiu.AtanaevRI.Sprint3.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int stopvalue = 12;
            int startvalue = 1;
            
            double res = ds.GetMultiplySeries(value, startvalue ,stopvalue);
            Assert.AreEqual(16947810.88, res);

        }
    }
}
