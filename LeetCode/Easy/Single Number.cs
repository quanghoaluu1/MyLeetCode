namespace LeetCode;

public class Single_Number
{
    public static int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
        {
            result ^= num;
        }

        return result;
    }
}