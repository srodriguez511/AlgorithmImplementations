using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Parenthesis
    {
        public static void PrintParenthesis(int n)
        {
            if (n > 0)
            {
                PrintParenthesis(n, n, string.Empty);
            }
        }

        private static void PrintParenthesis(int left, int right, string current)
        {
            if (right == 0)
            {
                Console.WriteLine(current);
            }
            else
            {
                if (left > 0)
                {
                    PrintParenthesis(left - 1, right, current + "(");

                    if (left < right)
                    {
                        PrintParenthesis(left, right - 1, current + ")");
                    }
                }
                else
                {
                    PrintParenthesis(left, right - 1, current + ")");
                }
            }
        }
    }
}
