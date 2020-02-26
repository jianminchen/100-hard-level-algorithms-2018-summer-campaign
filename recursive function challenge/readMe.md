**Problem statement**<br>
Given a list of float numbers, and four operators +, -, *, / with flat preference, find the maximum value by inserting operator between each consecutive pair of numbers.<br>

For example, given the array [1, 12, -3], the maximum number 33 can be found using 1 - 12 * (-3), since all operators have flat preference, so 1 - 12 * (-3) will be handled from left to right, first operation is 1 - 12 with value -11, and then second operation is -11 * (-3) = 33.<br>

Feb. 26, 2020<br>

I reviewed the algorithm on stackexchange.com, code review website. [Here](https://codereview.stackexchange.com/questions/186306/recursive-function-challenge) is the link. <br>

