This is the algorithm I asked in mock interview over five times. 

Given a binary tree, output all nodes in vertically order from left to right. If two nodes are in the same horizontal position, then the order will not be specified. In other words, the nodes can be in any order. 

The algorithm is a simple version compared to [Leetcode 987 vertical order traversal of a binary tree](https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/).

Feb. 9, 2020<br>
My performance as an interviweee on Feb. 9, 2020. <br>
[My C# code](https://gist.github.com/jianminchen/f764c85561eb69397b3f6b87910e4b5b) Feedback see the following:<br>
The interviewer works for Yahoo.com. He told me that there is no need to use hashMap, no need to sort keys by value in ascending order. 

I was told after the mock interview that the algorithm can be solved without using hashmap, and also no need to sort keys. So I wrote the the algorithm to avoid using hashmap and sorting of keys. Here is my leetcode discussion post<br>
[C#  vertical traverse binary tree algorithm (trial and error) in 2020](https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/discuss/504546/C-vertical-traverse-binary-tree-algorithm-(trial-and-error)-in-2020) <br>

Feb. 9, 2020 The interviewee is very hard working engineer.<br>
[Python solution](https://gist.github.com/jianminchen/4e5fe1bf8d2899427cd4119e16c21f97) <br>

Feb. 10, 2020 - the interviewee solved 500 algorithms on Leetcode. He solved three algorithms on my mock interview.<br>
[C++ solution](https://gist.github.com/jianminchen/1d9becd14d75cfe3f409e07b83ce6a51) <br>

Feb. 14, 2020 <br>
I also learned from the interviewee failure to solve the problem. The design should be modified to save horizontal value into Queue with node as well. <br>
It is learning experience for the interviewee because she could not figure out how to design Queue, horizontal value should be saved for each node as well. <br>
[Java code with problems](https://gist.github.com/jianminchen/12c811a9ef7a134d5f4dd9831c92ed1b) The code does not work!!!<br>

Feb. 15, 2020<br>
[Mock interviwee's experience](https://gist.github.com/jianminchen/c6cad3f30d03e7fc9f7e1891cd4df858) <br>

Feb. 18, 2020<br>
The interviewee was the manager of FANG (Facebook, Apple, Amazon, Linkedin, Microsoft, Google). He wrote the optimal solution, and also only leftmost horizontal position is found. Good design. I like the idea to increase the size of list based on horizontal index value.<br>
[Feb.18, 2020 10:00 PM mock interviwe as an interviewer](http://juliachencoding.blogspot.com/2020/02/case-study-vertically-traverse-binary.html) optimal time complexity<br>






