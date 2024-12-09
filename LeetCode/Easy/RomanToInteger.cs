namespace LeetCode;

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        int RomanCharToInt(char c)
        {
            return c switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };
        }
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int cur = RomanCharToInt(s[i]);
            int next = (i + 1 < s.Length) ? RomanCharToInt(s[i + 1]) : 0;
            if (cur < next)
            {
                result += next - cur;
                i++;
            }
            else
            {
                result += cur;
            }
        }
        return result;
    }
    
    //Dùng dictionary
    public int RomanToIntDictionary(string s) {
        Dictionary<string, int> roman = new Dictionary<string, int>();
        roman.Add("I", 1);
        roman.Add("V", 5);
        roman.Add("X", 10);
        roman.Add("L", 50);
        roman.Add("C", 100);
        roman.Add("D", 500);
        roman.Add("M", 1000);

        int result = 0;
        for(int i = 0; i < s.Length; i++){
            if ( i + 1 < s.Length && roman[s[i].ToString()] < roman[s[i + 1].ToString()]){
                result += roman[s[i + 1].ToString()] - roman[s[i].ToString()];
                i++;
            }else{
                result += roman[s[i].ToString()];
            }
        }
        return result;
    }
}