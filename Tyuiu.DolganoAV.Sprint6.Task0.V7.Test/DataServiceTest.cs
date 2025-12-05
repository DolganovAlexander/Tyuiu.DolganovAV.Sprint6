using Tyuiu.DolganoAV.Sprint6.Task0.V7.Lib;
namespace Tyuiu.DolganoAV.Sprint6.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 5;
            Assert.AreEqual(0.625, ds.Calculate(x));
        }
    }
}
