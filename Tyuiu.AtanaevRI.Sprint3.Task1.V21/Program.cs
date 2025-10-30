using Tyuiu.AtanaevRI.Sprint3.Task1.V21.Lib;
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
        int value = 1;
        int startValue = 1;
        int stopValue = 12;
        Console.WriteLine(ds.GetMultiplySeries( value ,startValue,stopValue));
    }
}