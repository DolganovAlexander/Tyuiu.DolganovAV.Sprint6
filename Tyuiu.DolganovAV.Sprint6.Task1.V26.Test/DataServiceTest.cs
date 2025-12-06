using Tyuiu.DolganovAV.Sprint6.Task1.V26.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] res = ds.GetMassFunction(start, end);

            double[] wait = new double[11];
            wait[0] = 28.05;
            wait[1] = 22.27;
            wait[2] = 17.01;
            wait[3] = 12.35;
            wait[4] = 7.51;
            wait[5] = 0.00;
            wait[6] = 1.62;
            wait[7] = -7.03;
            wait[8] = -12.99;
            wait[9] = -17.55;
            wait[10] = -21.43;
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
