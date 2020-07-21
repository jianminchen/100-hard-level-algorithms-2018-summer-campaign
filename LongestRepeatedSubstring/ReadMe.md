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




