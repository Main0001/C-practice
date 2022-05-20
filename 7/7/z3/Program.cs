using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "how two one tab bound double electronic";
            Console.WriteLine($"input: {input}");

            string patternLetters = @"(?<first>(\w*(?<l>\w)))\s(?<second>(\<l>\w*))";

            var matchesLetters = Regex.Matches(input, patternLetters);

            matchesLetters.Select(match => new { FirstWord = match.Groups["first"].Value, SecondWord = match.Groups["second"].Value })
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.FirstWord} - {p.SecondWord}"));
        }
    }
}
