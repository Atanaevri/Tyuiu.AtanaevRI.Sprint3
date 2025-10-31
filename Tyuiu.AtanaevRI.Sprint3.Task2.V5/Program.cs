using Tyuiu.AtanaevRI.Sprint3.Task2.V5.Lib;
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
        double value = 0.75;
        int startValue = 1;
        int stopValue = 20;
        Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
    }
}