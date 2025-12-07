using Tyuiu.DolganovAV.Sprint6.Task5.V29.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V29.txt";
            double[] wait = { 12, 12.89, 35, 13.83, 12.76 };
            CollectionAssert.AreEqual(wait, ds.LoadFromDataFile(path));
        }
    }
}
