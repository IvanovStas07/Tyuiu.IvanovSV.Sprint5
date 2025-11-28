using Tyuiu.IvanovSV.Sprint5.Task4.V23.Lib;


internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Иванов С. В. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов                                                  *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("*  Выполнил: Иванов С. В. | ИСТНб-25-1                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Создать папку в ручную С:DataSprint5 и скопировать в неё файл) в котором*");
        Console.WriteLine("* есть вещественное значение. Прочитать значение из файла и подставить    *");
        Console.WriteLine("* вместо Х в формуле y = x^-3 + 2 + cos(x)                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask4V23.txt";
        Console.WriteLine("Данные в: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат                                                               *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
