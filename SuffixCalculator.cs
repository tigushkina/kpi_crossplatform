using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;


namespace MyLib
{
    public class SuffixCalculator
    {
        static void Main()
        {

           // Program.Run();
        }

        public String RunSuffixCalculator(String input, String suffix)
        {
            return Program.FindLongestCommonSubstring(input, suffix);
        }
        
    }

    class Program
    {
        public static string FindLongestCommonSubstring(string s1, string s2)
        {
            int[,] a = new int[s1.Length + 1, s2.Length + 1];
            int row = 0;    // s1 index
            int col = 0;    // s2 index

            for (var i = 0; i < s1.Length; i++)
                for (var j = 0; j < s2.Length; j++)
                    if (s1[i] == s2[j])
                    {
                        int len = a[i + 1, j + 1] = a[i, j] + 1;
                        if (len > a[row, col])
                        {
                            row = i + 1;
                            col = j + 1;
                        }
                    }

            return s1.Substring(row - a[row, col], a[row, col]);
        }


        /* public static void Run()
         {


             var lines = new String[] { "ABCD", "BCDE"};

                int lineCount = lines.GetLength(0);

                string currentSuffix = lines[0];
                int currentSuffixLength = currentSuffix.Length;
                for (int i = 1; i < lineCount; i++)
                {
                    string thisLine = lines[i];
                    if (!thisLine.EndsWith(currentSuffix))
                    {
                        int thisLineLength = thisLine.Length;
                        int maxPossible = thisLineLength < currentSuffixLength ? thisLineLength : currentSuffixLength;

                        if (maxPossible == 0)
                        {
                            Console.WriteLine("String is empty ");

                        }

                        for (int j = 1; j < maxPossible; j++)
                        {
                            if (currentSuffix[currentSuffixLength - j] != thisLine[thisLineLength - j])
                            {
                                currentSuffix = currentSuffix.Substring(currentSuffixLength - j + 1, j - 1);
                                currentSuffixLength = j - 1;
                                break;
                            }
                        }
                    }
                }

            }

            public static IEnumerable<string> LongestCommonSubstrings(List<string> strings)
            {
                var firstString = strings.FirstOrDefault();

                var allSubstrings = new List<string>();
                for (int substringLength = firstString.Length - 1; substringLength > 0; substringLength--)
                {
                    for (int offset = 0; (substringLength + offset) < firstString.Length; offset++)
                    {
                        string currentSubstring = firstString.Substring(offset, substringLength);
                        if (!System.String.IsNullOrWhiteSpace(currentSubstring) && !allSubstrings.Contains(currentSubstring))
                        {
                            allSubstrings.Add(currentSubstring);
                        }
                    }
                }

                return allSubstrings.OrderBy(subStr => subStr).ThenByDescending(subStr => subStr.Length).Where(subStr => strings.All(currentString => currentString.Contains(subStr)));
            }

            private static BestStrings LongestCommonSubstring(string s1, string s2)
            {
                var lcs = new BestStrings();

                for (var i = 1 - s2.Length; i < s1.Length; i++)
                {
                    var substrings = BestSubstringWithAlignment(s1, s2, i);

                    if (substrings.Length == 0) continue;

                    lcs.Add(substrings);
                }

                return lcs;
            }

            private static BestStrings BestSubstringWithAlignment(string s1, string s2, int offset)
            {
                var substrings = new BestStrings();

                var substring = "";
                for (var i = Math.Max(0, offset); i < s1.Length && i < s2.Length + offset; i++)
                {
                    var c1 = s1[i];

                    var c2 = s2[i - offset];

                    if (c1 == c2)
                    {
                        substring = substring + c1;
                    }
                    else
                    {
                        substrings.Add(substring);
                        substring = "";
                    }
                }
                substrings.Add(substring);

                return substrings;
            }

            sealed class BestStrings : Collection<string>
            {
                public int Length
                {
                    get { return base[0].Length; }
                }

                public BestStrings()
                {
                    base.Add("");
                }

                public new void Add(string s)
                {
                    if (s.Length == 0 || s.Length < Length || Contains(s)) return;

                    if (s.Length > Length) Clear();
                    base.Add(s);
                }

                public void Add(IEnumerable<string> collection)
                {
                    foreach (var s in collection) Add(s);
                } */
    }
    }