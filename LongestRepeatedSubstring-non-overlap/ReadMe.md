July 21, 2020<br>

It is tough learning experience how to solve this algorithm using dynamic programming. <br>

Longest repeatable substring<br>
[Here](https://www.geeksforgeeks.org/longest-repeating-and-non-overlapping-substring/) is the link on geeksforgeeks.com. <br>

The problem statement is here:<br>
Given a string str, find the longest repeating non-overlapping substring in it. In other words find 2 identical substrings of maximum length which do not overlap. If there exists more than one such substring return any of them.<br>

Case study: <br>
"ABGABG"<br>
I like to work on this test case, and explain the idea how to find longest repeated substring. <br>
Since the substring repeated is not defined in terms of length, start position and end position, so it is easy to figure out that we need to find the dynamic programming using dp[start, end], the value is longest repeated substring. <br>

It is easy to figure out the longest repeated substring is "ABG". The goal is to find a substring with repeated "G", and then a substring with repeated "BG", and then longest one, a substring with repeated "ABG". <br>

The most important is to build a recurrence formula to construct dynamic programming table. <br>
"ABGABG" <br>
Add one char at the end of string, '|'
"ABGABG|"
 0123456  <br>
First the substring "BGAB" has longest repeated substring "B", and then DP[1,4] = 1; <br>
"BGA" has three suffix strings: "BGA", "GA" and "A". <br>
prefix string has one which is "A". So it is easy to tell that "A" is the repeated string in substring(1,4). Last index position 4 is exclusive, last char 'B' is not included. <br>

Next the substring "GABG" has longest repeated substring "BG", and then DP[2,5] = 2, the most important is to understand the recurrence formula: Dp[2,5] = Dp[1,4] + 1, since "ABGABG" at position 1, str[1] = 'B', and str[4] = 'B', so we can argue that "BG" is longest repeated substring. <br>

"BGAB" has the repeated substring, and also first and last char are the same. <br>
"GABG" has the repeated substring, and also the first and last char are the same. <br>

One thing to argue is that repeated substring ending at last position.<br>
For example, "ABGABG|". 
Those are bigger than zero: dp[1,4], dp[2,5], dp[3,6], since previous start and previous end are the same characters. 
"ABG|"
DP[3,6] = DP[2,5] + 1 since str[2] == str[5] = 'G', so longest repeated substring is "ABG".  <br>

I am not sure how it works. But I just spent time to debug the code and then wrote down the ideas. <br>
I will look into more articles related to prefix and suffix. <br>

Let me reason about this dp[start, end] makes sense or not. <br>
dp[1,4] = 1, "BGAB" has longest repeated substring "A" with length 1. From design viewpoint, from start = 0 to 6, end = 0 to 6. Since it is true that First "A" is not in "BGAB", so it makes sense that nonoverlap is satisfied. <br>
So we have to argue that starting from index = 0, "A", "AB" (first two chars of string "ABGABG"), "ABG", "ABGA", "ABGAB" do not have repeated substring at all. <br>
In other words, the repeated string is outside the string itself, non-overlap, and it is in the front of the substring. <br>

Follow up July 22, 2020<br>

Statement from geeksforgeeks.com problem solving analysis<br>
The basic idea is to find the longest repeating suffix for all prefixes in the string str.<br>

suffix - <br>
all prefixes<br>
For exmple, "ABGABG", dp[1, 4], "BGAB", suffix string of "BGAB" are "B","AB","GAB","BGAB". <br>
dp[1, 4], "BGAB", all prefixes are "A". <br>
dp[start, end], suffix string ends at index end - 1, but prefix string ends at start - 1. So that prefix string will never overlap the suffix string. <br>







