
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