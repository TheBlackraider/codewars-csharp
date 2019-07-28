using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace codewars_csharp
{
    public static class kata7kyu
    {
        public static int SumOfABeach(String phrase)
        {

            string[] words = { "Sand", "Water", "Fish", "Sun" };

            int result = 0;

            foreach (String word in words)
            {
                result += Regex.Matches(phrase, word, RegexOptions.IgnoreCase).Count;
            }

            return result;
        }
    }
}
