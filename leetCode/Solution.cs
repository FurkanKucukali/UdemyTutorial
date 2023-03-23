using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
   public class Solution
    {
        public List<String> letterCombinations(String digits)
        {
            List<String> output;
            Dictionary<string,List<string>> keyboarddata = new Dictionary<string, List<string>>();
            keyboarddata.Add("2", new() { "a", "b", "c" });
            keyboarddata.Add("3", new() { "d", "e", "f" });
            keyboarddata.Add("4", new() { "g", "h", "i" });
            keyboarddata.Add("5", new() { "j", "k", "l" });
            keyboarddata.Add("6", new() { "m", "n", "o" });
            keyboarddata.Add("7", new() { "p", "q", "r", "s" });
            keyboarddata.Add("8", new() { "t", "u", "v" });
            keyboarddata.Add("9", new() { "w", "x", "y", "z"});
            string[] digitlist = digits.ToString().Split("");
           foreach(var digit in digitlist)
            {
                
            }
            return new() {"" };
        }
    }
}
