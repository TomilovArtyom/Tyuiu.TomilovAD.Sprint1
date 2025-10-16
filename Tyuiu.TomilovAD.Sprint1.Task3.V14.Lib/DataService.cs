using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TomilovAD.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            return (number % 100 - number % 10) + (number % 10 * 100) + ((number - (number % 100)) / 100);
        }
    }
}
