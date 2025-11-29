using Tyuiu.IvanovSV.Sprint5.Task7.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Иванов С. В.| ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Иванов С. В.| ИСТНб-25-1                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Удалить все строчные латинские буквы из файла.Полученный результат      *");
        Console.WriteLine("* сохранить в файл OutPutDataFileTask7V10.txt.                            *");
        Console.WriteLine("*                                                                         *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";
        string pathSaveFile = "";
        Console.WriteLine("Данные находятся в файле: " + path);
        string fileContentOld = File.ReadAllText(path);
        Console.WriteLine(fileContentOld);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Находится в файле: ");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);
        Console.WriteLine("***************************************************************************");
        string fileContentNew = File.ReadAllText(pathSaveFile);
        Console.WriteLine(fileContentNew);
        Console.ReadKey();
    }
}