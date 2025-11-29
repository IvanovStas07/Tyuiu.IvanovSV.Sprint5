// See https://aka.ms/new-console-template for more information

using Tyuiu.IvanovSV.Sprint5.Task5.V9.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Иванов С. В. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема:  Чтение набора данных из текстового файла                         *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл, в котором есть набор значений. Найти максимальное целое число *");
        Console.WriteLine("* в файле. Полученный результат вывести на консоль. У вещественных        *");
        Console.WriteLine("* значений округлить до трёх знаков после запятой.                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Максимальное целое число в файле = " + res);

        Console.ReadKey();
    }
}
