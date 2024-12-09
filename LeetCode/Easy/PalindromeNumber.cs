namespace LeetCode;

public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        // string s = x.ToString();
        // char[] arr = s.ToCharArray();
        // Array.Reverse(arr);
        // var r = String.Join("", arr);
        // if ( s.Equals(r)){
        //     return true;
        // }
        // return false;
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        int rev = 0;
        while (x > rev)
        {
            rev = rev * 10 + x % 10;
            x = x / 10;
        }

        return x == rev || x == rev / 10;
    }
}