namespace LeetCode;

public class Valid_Parentheses
{
    public static bool IsValid(string s)
    {
        if (s.Length < 2)
        {
            return false;
        }
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
           
            if (c == '('  || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char top = stack.Pop();
                if ( top == '(' && c != ')' || top == '{' && c != '}' || top == '[' && c != ']')
                {
                    return false;
                }
            }
            
        }
        return stack.Count() == 0;
    }

    public static bool IsValid1(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '(') stack.Push(')');
            else if (c == '{') stack.Push('}');
            else if (c == '[') stack.Push(']');
            else if (stack.Count == 0 || stack.Pop() != c) return false;
        }

        return stack.Count == 0;
    }
}