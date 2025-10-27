using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TomilovAD.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            value = value.Replace("ноль", "0");
            value = value.Replace("один", "1");
            value = value.Replace("два", "2");
            value = value.Replace("три", "3");
            value = value.Replace("четыре", "4");
            value = value.Replace("пять", "5");
            value = value.Replace("шесть", "6");
            value = value.Replace("семь", "7");
            value = value.Replace("восемь", "8");
            value = value.Replace("девять", "9");
            value = value.Replace(" ", "");
            if (value.StartsWith("0"))
                return false;
            else return true;
        }
    }
}
