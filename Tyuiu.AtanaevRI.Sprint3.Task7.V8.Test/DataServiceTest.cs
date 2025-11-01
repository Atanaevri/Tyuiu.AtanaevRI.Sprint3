using Tyuiu.AtanaevRI.Sprint3.Task7.V8.Lib;
namespace Tyuiu.AtanaevRI.Sprint3.Task7.V8.Test
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
            int len = stopValue - startValue + 1;
            double[] value;

            value = new double[len];
            value[0] =0.96;
            value[1] =0.76; 
            value[2] =-0.14; 
            value[3] =-0.91; 
            value[4] =-0.84;
            value[5] =0.00; 
            value[6] =0.84; 
            value[7] =-.91;
            value[8] =0.14;
            value[9] =-0.76;
            value[10] =-0.96;

            double[] res;
            
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(value,res);



        }
    }
}
