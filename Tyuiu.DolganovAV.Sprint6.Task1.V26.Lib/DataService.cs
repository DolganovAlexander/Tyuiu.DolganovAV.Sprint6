using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DolganovAV.Sprint6.Task1.V26.Lib;

public class DataService : ISprint6Task1V26
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] value;
        int len = (stopValue - startValue) + 1;
        value = new double[len];
        double y;
        int c = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
            value[c] = y;
            c++;
        }
        return value;
    }
}
