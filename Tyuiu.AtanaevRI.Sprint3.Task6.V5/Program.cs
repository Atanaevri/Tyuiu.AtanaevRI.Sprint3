using Tyuiu.AtanaevRI.Sprint3.Task6.V5.Lib;
// See https://aka.ms/new-console-template for more information

DataService ds = new DataService();

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int startValue = 15;
int stopValue= 22;

Console.WriteLine(ds.GetSumTheDivisors(startValue,stopValue));