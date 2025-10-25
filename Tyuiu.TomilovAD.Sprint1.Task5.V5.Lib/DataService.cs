using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TomilovAD.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            return (int)(x*10) - (int)(x) * 10;
        }
    }
}
