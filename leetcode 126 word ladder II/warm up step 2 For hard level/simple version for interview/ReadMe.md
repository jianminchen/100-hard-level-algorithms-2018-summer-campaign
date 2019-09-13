
Problem statements:<br>

(good, best), a list of words in the dictionary<br>
good<br>
bood -> bood in dictionary<br>
beod -> beod in dctionary<br>
beed -> beed in dictionary<br>
beet -> beet in dictionary<br>
there maybe more than one path<br>
good -> bood->beod->beed->beet<br>
good -> at most 26 choices -> <br>
good -> boot -<br>
can you return all paths?<br>


I met the interviewee on August 16, 2019. She really worked hard, and then she created a test case to find two paths from source word to destination word. <br>

source = "good"; <br>
dest = "best";<br>

var words = new string[] {"bood", "beod", "besd","goot","gost","gest","best"};<br>
  
two paths<br>
good->bood->beod->besd->best<br>
good->goot->gost->gest->best<br>

[Here](https://juliachencoding.blogspot.com/2019/09/case-study-126-word-ladder-ii.html) is the blog to document the mock interview, the interviewee wrote Java code and she tested the code as well. <br>

Follow up <br>
Time complexity analysis <br>

I asked the algorithm in mock interview more than three time now. I learned from best performer - an interviewee works for Intel. But also I like to share my idea if the interviewee has some difficulty to come out the idea. I like to write down what I learn, sometimes I do make mistakes as well. 

I like to write down time complexity analysis for the depth first earch. Source word is "good", in order to find possible char to change, how much options to search, each char has 25 chars to be replaced, and index position can be from 0 to 3, so total is 4 * 25 = 100; in order to find next char, we may change the same index position more than once, so the time complexity is related to how many times one char should be replaced. Maybe there are more than 4 times to be changed to find the destination word "best". 

Facts:<br>
At least (4 * 25)^4 = 100 ^4 = 100,000,000. <- it is not true
I had some discussion when I asked the algorithm with the interviewee on Sept. 10. But I found out that my analysis is not correct. 
