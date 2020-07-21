using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_repeated_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTestcase1(); 
        }

        /// <summary>
        /// July 21, 2020
        /// </summary>
        public static void RunTestcase1()
        {
            longestRepeatedSubstring("ABGABG");
        }

        /// Longest repeatable substring - 
        /// https://www.geeksforgeeks.org/longest-repeating-and-non-overlapping-substring/
        /// dynamic programming 
        /// Dynamic Programming : This problem can be solved in O(n^2) time using Dynamic Programming. 
        /// The basic idea is to find the longest repeating suffix for all prefixes in the string str.
        /// 
        /// To avoid overlapping we have to ensure that the length of suffix is less than (j-i) 
        /// at any instant.
        /// The maximum value of LCSRe(i, j) provides the length of the longest repeating substring 
        /// and the substring itself can be found using the length and the ending index of the common 
        /// suffix.
        /// 
        public static String longestRepeatedSubstring(String str)
        {
            int n = str.Length;
            var LCSRe = new int[n + 1, n + 1];

            var longestSubstring = "";    
            int maxLength = 0; // To store length of result  

            // building table in bottom-up manner  
            int start;
            int index = 0;

            // work on substring [start, end] inclusive
            for (start = 1; start <= n; start++)
            {
                for (int end = start + 1; end <= n; end++)
                {
                    var previousStart = start - 1;
                    var previousEnd = end - 1; 

                    // (end - start) > LCSRe[start - 1][end - 1] to remove overlapping                    
                    if ( str[previousStart] == str[previousEnd] &&
                         LCSRe[previousStart, previousEnd] < (end - start))
                    {
                        LCSRe[start, end] = LCSRe[start - 1, end - 1] + 1;

                        // updating maximum length of the  
                        // substring and updating the finishing  
                        // index of the suffix  
                        if (LCSRe[start, end] > maxLength)
                        {
                            maxLength = LCSRe[start, end];
                            index = Math.Max(start, index);
                        }
                    }
                    else
                    {
                        LCSRe[start, end] = 0;
                    }
                }
            }

            // If we have non-empty result, then insert all  
            // characters from first character to last  
            // character of String  
            if (maxLength > 0)
            {
                for (start = index - maxLength + 1; start <= index; start++)
                {
                    longestSubstring += str[start - 1];
                }
            }

            return longestSubstring;
        }
    }
}
