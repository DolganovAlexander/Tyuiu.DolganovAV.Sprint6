using Tyuiu.DolganovAV.Sprint6.Task4.V25.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] res = ds.GetMassFunction(start, end);
            double[] wait = new double[11];
            wait[0] = 4.67;
            wait[1] = 0.43;
            wait[2] = -8.26;
            wait[3] = -9.87;
            wait[4] = -3.98;
            wait[5] = 1.00;
            wait[6] = 0.02;
            wait[7] = -1.87;
            wait[8] = 3.74;
            wait[9] = 16.43;
            wait[10] = 24.67;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
