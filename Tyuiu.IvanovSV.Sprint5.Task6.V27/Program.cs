
using System.IO;
using Tyuiu.IvanovSV.Sprint5.Task6.V27.Lib;

internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Иванов С. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: обработка текстовых файлов.                                        ");
            Console.WriteLine("* Задание #6                                                               ");
            Console.WriteLine("* Вариант #27                                                              ");
            Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                       ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан файл InPutDataFileTask6V27.txt, в котором есть набор символьных      ");
            Console.WriteLine("* данных. Найти количество трехзначных чисел в заданной строке.            ");

        string path = @"C:\DataSprint5\InPutDataFileTask6V27.txt";
        Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
