using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class SubsetsOfASet
    {
        public static List<List<int>> Subsets(List<int> set)
        {
            if (set.Count() == 0)
            {
                return new List<List<int>>();
            }

            if (set.Count() == 1)
            {
                return new List<List<int>> { set };
            }

            var final = new List<List<int>> { };
            var first = set.ElementAt(0);
            var firstList = new List<int> { first };
            var remaining = set.Except(firstList).ToList();
            var others = Subsets(remaining);

            foreach (var otherSet in others)
            {
                var additionalSets = new List<List<int>> { otherSet };
                var otherAndItem = new List<int>();
                otherAndItem.AddRange(otherSet);
                otherAndItem.Add(first);
                additionalSets.Add(otherAndItem);
                final.AddRange(additionalSets);
            }

            final.AddRange(new List<List<int>> { firstList });

            return final;
        }
    }
}
