using Tyuiu.AtanaevRI.Sprint3.Task3.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string input = "!bt, g567kid f!";
        Console.WriteLine($"Исходная строка: {input}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            DataService ds = new DataService();
            int result = ds.ConvertStringToInt(input);
            Console.WriteLine($"Извлеченное число: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* КОНЕЦ ПРОГРАММЫ                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.ReadKey();
    }
}