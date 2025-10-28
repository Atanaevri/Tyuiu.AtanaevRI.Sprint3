using Tyuiu.AtanaevRI.Sprint3.Task0.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        {
            Console.WriteLine("================================================");
            Console.WriteLine("    ВЫЧИСЛЕНИЕ СУММЫ РЯДА");
            Console.WriteLine("================================================");
            Console.WriteLine();
            DataService ds = new DataService();
            // Выводим подробное вычисление
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("Результат вычисления:");

            // Получаем итоговую сумму
            double result = ds.GetSumSeries(value,  startValue, stopValue);
            Console.WriteLine($"S = ∑(t^k + 2/(k+1)) * sin(t) = {result:F6}");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
    
