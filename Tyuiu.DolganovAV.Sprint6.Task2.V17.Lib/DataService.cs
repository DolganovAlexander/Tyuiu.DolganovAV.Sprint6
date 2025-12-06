using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DolganovAV.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                result[count] = Math.Round(Math.Cos(x) + 2*x - Math.Sin(x) * 3 * x, 2);
                count++;
            }
            return result;
        }
    }
}
