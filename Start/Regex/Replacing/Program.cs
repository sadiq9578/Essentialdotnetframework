﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for Replacing content with Regexes 
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";

Regex CapWords = new Regex(@"[A-Z]\w+");

// TODO: Regular expressions can be used to replace content in strings
string result = CapWords.Replace(teststr1, "***");
Console.WriteLine(teststr1);
Console.WriteLine(result);
// in addition to just searching for content


// TODO: Replacement text can be generated on the fly using MatchEvaluator
string MakeUpper(Match m) {
string s = m.ToString();
if (m.Index == 0) {
return s;
}
return s.ToUpper();
}
// This is a delegate that computes the new value of the replacement

