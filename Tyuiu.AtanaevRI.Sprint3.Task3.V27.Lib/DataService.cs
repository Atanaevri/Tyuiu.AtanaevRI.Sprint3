using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AtanaevRI.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            
                string numbers = "";

                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                    {
                        numbers += c;
                    }
                }

                if (string.IsNullOrEmpty(numbers))
                {
                    throw new ArgumentException("В строке отсутствуют цифры");
                }

                return int.Parse(numbers);
            }
        }
    }





    


    

