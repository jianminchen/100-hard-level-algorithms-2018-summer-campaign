July 21, 2020<br>

It is tough learning experience how to solve this algorithm using dynamic programming. <br> I also found the algorithm called "1044. Longest Duplicate Substring" hard level on Leetcode.com. <br>

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
First the substring "BGAB" has longest repeated substring "B", and then DP[1,4] = 1; End is exclusive, so "BGA" is the string, and suffix strings are "BGA", "GA" and "A".<br>
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

**Follow up on July 22, 2020**<br>
It is a good philosophy. Work on easy level first, and also work on medium level next. But in reality, I have to learn how to solve a hard level algorithm in order to be competitive. <br>
I like to write somethings about designing this hard level algorithm, the recurrence formula, and things should be added into a full check list before the design is final. <br>
Let me start from substring [2, 5]. <br>
"ABGABG|"<br>
 012345<br>
 Substring(2,5] should be "GABG". <br>
 Actually a substring starting from beginning "ABGAB", substring(2) "GAB"'s suffix "AB" is same as prefix of "GAB", so "GAB" ...





