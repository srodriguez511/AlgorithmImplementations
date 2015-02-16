using Arrays;
using Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            var perms = AllPermutationsOfString.PrintPermutations("hey");
            foreach (var perm in perms)
            {
                Console.WriteLine(perm);
            }

            Console.WriteLine();
            var sets = SubsetsOfASet.Subsets(new List<int> { 1, 2, 3 });
            foreach (var set in sets)
            {
                foreach (var item in set)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
