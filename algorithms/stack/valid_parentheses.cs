using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifeanyi_algorithm_solutions.algorithms.stack
{
    public class valid_parentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if (c == ')' && top != '(') return false;
                    if (c == '}' && top != '{') return false;
                    if (c == ']' && top != '[') return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
