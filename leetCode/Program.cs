using System;
using System.Collections.Generic;
using leetCode;

namespace leetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            letterCombinations("245");


            
        }

        public static List<String> letterCombinations(String digits)
        {
            List<String> output;
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                {2, "abc"},
                {3, "def"},
                {4, "ghi"},
                {5, "jkl"},
                {6, "mno"},
                {7, "pqrs"},
                {8, "tuv"},
                {9, "wxyz"}
            };
            Dictionary<string, List<string>> keyboarddata = new Dictionary<string, List<string>>();
            keyboarddata.Add("2", new() { "a", "b", "c" });
            keyboarddata.Add("3", new() { "d", "e", "f" });
            keyboarddata.Add("4", new() { "g", "h", "i" });
            keyboarddata.Add("5", new() { "j", "k", "l" });
            keyboarddata.Add("6", new() { "m", "n", "o" });
            keyboarddata.Add("7", new() { "p", "q", "r", "s" });
            keyboarddata.Add("8", new() { "t", "u", "v" });
            keyboarddata.Add("9", new() { "w", "x", "y", "z" });
            string[] digitlist = digits.Split(digits);


            Console.WriteLine(dictionary[3]);
            foreach (var digit in digitlist)
            {
                Console.WriteLine(digit);
            }
            return new() ;
        }
    }
}
