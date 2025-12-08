using Tyuiu.DolganovAV.Sprint6.Task6.V12.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V12.txt";
            string wait = "iKDOjtfsPmw";
            Assert.AreEqual(wait, ds.CollectTextFromFile(path));
        }
    }
}
