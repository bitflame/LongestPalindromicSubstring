﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(LongestPalindrome("babad"));
            //Console.WriteLine(PrepareString("babad"));
            //Console.WriteLine(PrepareString("cbbd"));
            //Console.WriteLine(PrepareString("bb"));
            //Console.WriteLine(PrepareString("forgeeksskeegfor"));
            //Console.WriteLine(PrepareString("abaaba"));
            //Console.WriteLine(PrepareString("abababa"));
            //Console.WriteLine(PrepareString("abcbabcbabcba"));
            ////Need to pass ""(should give "" or length of 0), "ac" (should give a or lenth of 1) 
            //Console.WriteLine($"Result of Manacher's algorithm for {"babad"} is:{FindPalManacherVid(Program.PrepareString("babad"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"cbbd"} is:{FindPalManacherVid(Program.PrepareString("cbbd"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"bb"} is:{FindPalManacherVid(Program.PrepareString("bb"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"forgeeksskeegfor"} is:{FindPalManacherVid(Program.PrepareString("forgeeksskeegfor"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"abaaba"} is:{FindPalManacherVid(Program.PrepareString("abaaba"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"abababa"} is:{FindPalManacherVid(Program.PrepareString("abababa"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"abcbabcbabcba"} is:{FindPalManacherVid(Program.PrepareString("abcbabcbabcba"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"a"} is:{FindPalManacherVid(Program.PrepareString("a"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"ac"} is:{FindPalManacherVid(Program.PrepareString("a"))} !");
            //Console.WriteLine($"Result of Manacher's algorithm for {"abb"} is:{FindPalManacherVid(Program.PrepareString("abb"))} !");
            ////longest palindrome
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"babad"} is:{Program.LongestPalindrome("babad")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"cbbd"} is:{Program.LongestPalindrome("cbbd")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"bb"} is:{Program.LongestPalindrome("bb")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"forgeeksskeegfor"} is:{Program.LongestPalindrome("forgeeksskeegfor")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"abaaba"} is:{Program.LongestPalindrome("abaaba")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"abababa"} is:{Program.LongestPalindrome("abababa")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"abcbabcbabcba"} is:{Program.LongestPalindrome("abcbabcbabcba")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"a"} is:{Program.LongestPalindrome("a")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"ac"} is:{Program.LongestPalindrome("ac")} !");
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"abb"} is:{Program.LongestPalindrome("abb")} !");
            //var longString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Console.WriteLine($"Result of Longest Palindrome algorithm for {"longString"} is:{Program.LongestPalindrome(longString)} !");
            var longString2 = "jglknendplocymmvwtoxvebkekzfdhykknufqdkntnqvgfbahsljkobhbxkvyictzkqjqydczuxjkgecdyhixdttxfqmgksrkyvopw" +
                "prsgoszftuhawflzjyuyrujrxluhzjvbflxgcovilthvuihzttzithnsqbdxtafxrfrblulsakrahulwthhbjcslceewxfxtavljpimaqqlcbrdgtgjr" +
                "yjytgxljxtravwdlnrrauxplempnbfeusgtqzjtzshwieutxdytlrrqvyemlyzolhbkzhyfyttevqnfvmpqjngcnazmaagwihxrhmcibyfkccyrqwnzl" +
                "zqeuenhwlzhbxqxerfifzncimwqsfatudjihtumrtjtggzleovihifxufvwqeimbxvzlxwcsknksogsbwwdlwulnetdysvsfkonggeedtshxqkgbhosc" +
                "jgpiel";
            Console.WriteLine($"Result of Longest Palindrome algorithm for {"longStrings2"} is:{Program.LongestPalindrome(longString2)} !");
            Console.ReadLine();
        }
        //This is the alg from the video
        
        public static string FindPalManacherVid(string t)
        {
            int[] p = new int[t.Length];
            int c = 0, r = 0, palCtr = 0;
            string lgstPal = t;
            for (int i = 0; i < t.Length; i++)
            {
                int mirr = 2 * c - 1;
                if (i < r)
                    p[i] = Math.Min(r - i, p[mirr]);
                try
                {
                while (t[i + (1 + p[i])] == t[i - (1 + p[i])])
                    {
                     p[i]++;
                      
                    }
                }
                catch (IndexOutOfRangeException)
                {

                    continue;
                }
                
                if (i + p[i] > r)
                {
                    c = i;
                    r = i + p[i];
                }
            }
            var palCent = Math.Max(Array.IndexOf(p, p.Max()), 1);
            //Console.WriteLine(t.Substring(palCtr - p.Max(), p.Max() * 2 + 1));
            return RemoveStringFillers(t.Substring(palCent-p.Max(),p.Max()*2+1));
            //return RemoveStringFillers(lgstPal);
        }
        public static string RemoveStringFillers(string s)
        {
            var charsToRemove = new string[] { "$" , "#", "@"};
            foreach (var c in charsToRemove)
            {
                s = s.Replace(c, string.Empty);
            }
            return s;
        }
        public static string PrepareString(string s)
        {
            
            string result = s;
            for (int i = 0; i < s.Length-1; i++)
            {
                //string result = string.Join(".", someString.AsEnumerable());
                result = string.Join(@"#", s.AsEnumerable());
            }
            StringBuilder sb = new StringBuilder();
            result = sb.Append('$' + result + '@').ToString();
            return result;
        }
        public static string ManacherAlg(string s)
        {
            if (s == null || s.Length == 0)
            {
                return null;
            }   
            char[] s2 = AddBoundaries(s.ToArray<char>());
            int[] p = new int[s2.Length];
            int c = 0, r = 0;
            int m = 0, n = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                if (i > r)
                {
                    p[i] = 0;m = i - 1; n = i + 1;
                } else
                {
                    int i2 = c * 2 - i;
                    if (p[i2] < (r - i - 1))
                    {
                        p[i] = p[i2];
                        m = -1;
                    } else
                    {
                        p[i] = r - i;
                        n = r + 1; m = i * 2 - n;
                    }
                }
                while (m>=0 && n < s2.Length && s2[m]==s2[n])
                {
                    p[i]++; m--; n++;
                }
                if ((i + p[i]) > r)
                {
                    c = i; r = i + p[i];
                }
            }
            int len = 0; c = 0;
            for (int i = 1; i < s2.Length; i++)
            {
                if (len < p[i])
                {
                    len = p[i]; 
                    c = i;
                }
            }
            return s;
            //return removeBoundaries(s);
        }
        private static char[] AddBoundaries(char [] cs)
        {
            if (cs == null || cs.Length == 0)
            {
                return "||".ToArray<char>();
            }
            char[] cs2 = new char[cs.Length * 2 + 1];
            for (int i = 0; i < (cs2.Length-1); i=i+2)
            {
                cs2[i] = '|';
                cs2[i + 1] = cs[i / 2];
            }
            cs2[cs2.Length - 1] = '|';
            return cs2;
        }
        private static char[] removeBoundaries(char [] cs)
        {
            if (cs==null || cs.Length < 3)
            {
                return "".ToArray<char>();
            }
            char[] cs2 = new char[(cs.Length - 1) / 2];
            for (int i = 0; i < cs2.Length; i++)
            {
                cs2[i] = cs[i * 2 + 1];
            }
            return cs2;
        }
        public static void printSubStr(string str,
                               int low, int high)
        {
            Console.WriteLine(str.Substring(low,
                             (high + 1) - low));
        }

        // This function prints the longest  
        // palindrome substring (LPS) of str[].  
        // It also returns the length of the  
        // longest palindrome  
        public static int longestPalSubstr(string str)
        {
            int maxLength = 1; // The result (length of LPS) 

            int start = 0;
            int len = str.Length;

            int low, high;

            // One by one consider every  
            // character as center point 
            // of even and length palindromes  
            for (int i = 1; i < len; ++i)
            {
                // Find the longest even length  
                // palindrome with center points  
                // as i-1 and i.  
                low = i - 1;
                high = i;
                while (low >= 0 && high < len &&
                       str[low] == str[high])
                {
                    if (high - low + 1 > maxLength)
                    {
                        start = low;
                        maxLength = high - low + 1;
                    }
                    --low;
                    ++high;
                }

                // Find the longest odd length  
                // palindrome with center point as i  
                low = i - 1;
                high = i + 1;
                while (low >= 0 && high < len &&
                       str[low] == str[high])
                {
                    if (high - low + 1 > maxLength)
                    {
                        start = low;
                        maxLength = high - low + 1;
                    }
                    --low;
                    ++high;
                }
            }

            Console.Write("Longest palindrome substring is: ");
            printSubStr(str, start, start + maxLength - 1);

            return maxLength;
        }
        public static string LongestPalindrome(String s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 1)
            {
                return "";
            }
            int start = 0, end = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundTheCenter(s, i, i);
                int len2 = expandAroundTheCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len> end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                    
                }
            }
            //if (start == 0 && end == 0) return s.First().ToString();
            return s.Substring(start, end - start +1);
        }
        public static int  expandAroundTheCenter(string s, int Left, int Right)
        {
            int L = Left ;
            int R = Right;
            while(L >= 0 && R < s.Length && s.ElementAt(L) == s.ElementAt(R))
            {
                L--;
                R++;
            }
            
            return R - L - 1;
        }
    }

}
