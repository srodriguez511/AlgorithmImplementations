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
        }
    }
}
