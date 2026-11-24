using System;
using System.IO;
using Tyuiu.BolohovcevaSV.Sprint5.Task0.V25.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint5.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 5 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 5                                                                *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание №0                                                              *");
            Console.WriteLine("* Вариант №25                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение выражения при x = 3.                                 *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask0.txt                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int x = 3;

            Console.WriteLine("* x = " + x + "                                                           *");

            string path = ds.SaveToFileTextData(x);
            string res = File.ReadAllText(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* y = " + res + "                                                               *");
            Console.WriteLine("* Файл сохранен: " + path);
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}