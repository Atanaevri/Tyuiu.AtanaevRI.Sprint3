
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AtanaevRI.Sprint3.Task0.V15.Lib
{
    public class DataService : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            int k;
            double sumseries = 0;
            
            for (k = startValue; k <= stopValue;  k++);
            {
                sumseries = sumseries + ((Math.Pow(value, k) + (2 / k + 1))*Math.Sin(value));
            }
            return Math.Round(sumseries, 3);
        }
    }
}
