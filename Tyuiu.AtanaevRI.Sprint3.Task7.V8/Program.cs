using Tyuiu.AtanaevRI.Sprint3.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        
        int startValue = -5;
        int stopValue = 5;

        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] value;
        value = new double[len];
        value = ds.GetMassFunction(startValue, stopValue);

        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("{0} -> {1:f2}" , startValue, value[i]);
            startValue++;
        }
        

    }
}