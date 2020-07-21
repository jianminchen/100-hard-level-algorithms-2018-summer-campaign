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
 012345  <br>
First the substring "BGAB" has longest repeated substring "B", and then DP[1,4] = 1; <br>
Next the substring "GABG" has longest repeated substring "BG", and then DP[2,5] = 2, the most important is to understand the recurrence formula: Dp[2,5] = Dp{1,4] + 1, since "ABGABG" at position 1, str[1] = 'B', and str[4] = 'B', so we can argue that "BG" is longest repeated substring. <br>

"BGAB" has the repeated substring, and also first and last char are the same. <br>
"GABG" has the repeated substring, and also the first and last char are the same. <br>





