using Tyuiu.AtanaevRI.Sprint3.Task6.V5.Lib;
namespace Tyuiu.AtanaevRI.Sprint3.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()

        {
            DataService ds = new DataService(); 
            int x = 15;
            int y = 22;
            int res = ds.GetSumTheDivisors(x, y);
            Assert.AreEqual(242 , res);
        }
    }
}
