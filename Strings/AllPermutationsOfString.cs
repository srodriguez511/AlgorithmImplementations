using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class AllPermutationsOfString
    {
        public static List<string> PrintPermutations(string s)
        {
            if (s.Length == 0)
            {
                return Enumerable.Empty<string>().ToList();
            }

            if (s.Length == 1)
            {
                return new List<string> { s };
            }
            else
            {
                var permsRemaining = PrintPermutations(s.Substring(1));
                var totalPerms = new List<string>();
                foreach (var perm in permsRemaining)
                {
                    var newPerms = FindPositions(s[0], perm);
                    totalPerms.AddRange(newPerms);
                }

                return totalPerms;
            }
        }

        private static List<string> FindPositions(char c, string perm)
        {
            var result = new List<string>();
            for (int i = 0; i <= perm.Length; i++)
            {
                var pre = perm.Substring(0, i);
                var end = perm.Substring(i);
                var str = pre + c + end;
                result.Add(str);
            }

            return result;
        }
    }
}
