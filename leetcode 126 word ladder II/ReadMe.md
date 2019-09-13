One of ideas to solve a hard level algorithm is to work on a few simple problems first. And after a few practice to solve simple problems, it is time to solve the hard level algorithm. 

One of simple version Leetcode 126 is to find all paths from source word to destination word, but not minimum path. 


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

Follow up <br>
Sept. 13, 2019<br>
I like to brainstorm and come out all kinds of problems to solve related to word ladder. 

Leetcode 126 word ladder II - find all shortest transformation sequence(s) from beginWord to endWord
Leetcode 127 word ladder - find the length of shortest transformation sequence from beginWord to endWord

Word ladder - find all paths from beginWord to endWord - ask the algorithm in mock interview, onsite interview. My practice is [here](https://github.com/jianminchen/100-hard-level-algorithms-2018-summer-campaign/tree/master/leetcode%20126%20word%20ladder%20II/simple%20version%20for%20interview).
My practice with a bug is [here](). I will add the source code later. 
I like to name the algorithm Leetcode 126-one path-all paths-all shortest paths series. 



