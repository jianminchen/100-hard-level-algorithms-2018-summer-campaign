There are multiples ideas to serilize the shape. One with optimized space, no extra space is to record all directions through DFS search for each island. The argument is that the direction string should be the same if two shapes are the same. 

One idea I came out is not space optimized. My idea is to put all nodes in the island into hashmap, and then find minmimum row and minimum column in the island, and then using offset matrix starting from (minRow, minCol) to (maxRow, maxCol) to form a string. Those nodes are not in island also part of serialized string. 

I asked the algorithm in mock interview as an interviewer, I met an engineerw with 10 years experience in VMWARE, he came out the idea to use directions. 

