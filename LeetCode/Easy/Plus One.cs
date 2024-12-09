namespace LeetCode;

public class Plus_One
{
    public static int[] PlusOne(int[] digit)
    {

        for (int i = digit.Length - 1; i >= 0; i--)
        {
            if (digit[i] < 9)
            {
                digit[i]++;
                return digit;
            }
            digit[i] = 0;
        }
        int[] result = new int[digit.Length + 1];
        result[0] = 1;
        return result;
    }
}