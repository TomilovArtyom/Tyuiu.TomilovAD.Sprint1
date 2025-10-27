using Tyuiu.TomilovAD.Sprint1.Task7.V22.Lib;

namespace Tyuiu.TomilovAD.Sprint1.Task7.V22;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил Томилов А. Д. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Convert                                                           *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите X:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите Y:");
        double y = Convert.ToDouble(Console.ReadLine());



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    }
}