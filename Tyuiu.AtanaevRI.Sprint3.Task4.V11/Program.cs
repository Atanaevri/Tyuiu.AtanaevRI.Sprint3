using Tyuiu.AtanaevRI.Sprint3.Task4.V11.Lib;
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
        Console.WriteLine(ds.Calculate( startValue, stopValue));
    }
}