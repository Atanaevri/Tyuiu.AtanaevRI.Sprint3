using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AtanaevRI.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
         


            double[] value;
            int len = (stopValue - startValue) + 1;
            value = new double[len];
            double y;
            int count = 0;
            for (int x = startValue;  x < stopValue; x++)
            {
                double d = ((Math.Cos(x) + 1) / (2 - x));
                double g = Math.Sin(x) + d + 2 * x;
                value[count] = g;
                count++;

            }
            return value;
        }
    }
}
