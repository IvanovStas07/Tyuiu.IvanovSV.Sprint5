namespace Tyuiu.IvanovSV.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Станислав\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo fileUnfo = new FileInfo(path);
            bool fileInfo = fileUnfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileInfo);
        }
    }
}