using Tyuiu.TomilovAD.Sprint1.Task6.V18.Lib;

namespace Tyuiu.TomilovAD.Sprint1.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Convert                                                           *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ;                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить,               *");
            Console.WriteLine("* что строка является символьным представлением натурального числа        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите строку:");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckNumber(value));
            Console.ReadLine();
        }
    }
}