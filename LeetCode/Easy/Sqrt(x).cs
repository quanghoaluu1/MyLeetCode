namespace LeetCode;

public class Sqrt_x_
{
    public static int Sqrt(int x)
    {
        double num = Convert.ToDouble(x);
        double a = num;
        double b = 1;
        double e = 0.00000001;

        while (a - b > e)
        {
            a = (a + b) / 2;
            b = num / a;
        }
        return (int)a;
    }
}