import java.io.*;
import java.util.*;

class Solution {
  
  public List<List<String>> findAllPaths(String[] dict, String src, String dest){
    Set<String> set = new HashSet<>();
    for(String s:dict)
      set.add(s);
    
    List<List<String>> res = new ArrayList<>();
    List<String> curr = new ArrayList<>();
    curr.add(src);
    dfs(src, dest, curr, res, set, new HashSet<>());
    return res;
  }
  
  Trie
  // cRes -> path 
  // allRes -> paths 
  // visited 
  private void dfs(String curr, String dest, List<String> cRes, List<List<String>> allRes,
                  Set<String> dict, 
                  Set<String> v){
    if(v.contains(curr))  // why return here? visited 
      return;
    
    if(curr.equals(dest)){
      allRes.add(new ArrayList<>(cRes));
      // ? 
      return;
    }
    
    v.add(curr);  // add node to - v, key - string, value is set? 
    for(String neighbor:getChildren(curr, dict)){
      cRes.add(neighbor);
      dfs(neighbor, dest, cRes, allRes, dict, v);
      cRes.remove(cRes.size()-1); // backtracking - remove from the path 
    }
    
    v.remove(curr);  // backtracking - remove from visited 
  }
// length =5 , 25 ^5 = -> dictionary can be huge, 25 * 25 * 25 * 25 * 25 = 
  private List<String> getChildren(String curr, Set<String> dict){
    List<String> result=new ArrayList<>();
    char[] cArr=curr.toCharArray();
    
    for(int i=0;i<cArr.length;i++){
      for(int j=0;j<26;j++){
        if(cArr[i]!=(char)('a'+j)){
          char temp = cArr[i];
          cArr[i]=(char)('a'+j);
          String n = new String(cArr);
          if(dict.contains(n))
            result.add(n);
          cArr[i]=temp;  // restore original char
        }
      }
    }
    
    return result;
  }
  
  public static void main(String[] args) {
    Solution soln = new Solution();
    String[] dict=new String[] {"bood", "beod", "besd","goot","gost","gest","best"};
    List<List<String>> res = soln.findAllPaths(dict, "good", "best");
    for(List<String> r : res){
      for(String s: r){
        System.out.print("->" + s);
      }
      System.out.println();
    }
    
  }
}

/*
source = "good";
dest = "best";
var words = new string[] {"bood", "beod", "besd","goot","gost","gest","best"};
two paths
good->bood->beod->besd->best
good->goot->gost->gest->best
Find all paths from source to destination, each intermediate word is in dictionary, each time you can change one char in the word. 
*/