# Sequence in matrix

## Description
We are given a matrix of strings of size `N x M`. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

## Input
- On the first line you will receive the numbers **N** and **M** separated by a single space
- On the next **N** lines there will be **M** strings separated with spaces - the strings in the matrix

## Output
- Print the length of the longest sequence of equal strings in the matrix

## Constraints
- 3 <= **N**, **M** <= 128
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input |Input |
|:------|:------|
| 6 6<table><tbody><tr><td>92</td><td>11</td><td>23</td><td>42</td><td>59</td><td>48</td></tr><tr><td>09</td><td>92</td><td>23</td><td>72</td><td>56</td><td>14</td></tr><tr><td>17</td><td>63</td><td>92</td><td>46</td><td>85</td><td>**95**</td><tr><td>34</td><td>12</td><td>52</td><td>69</td><td>23</td><td>**95**</td></tr></tr><tr><td>26</td><td>88</td><td>78</td><td>71</td><td>29</td><td>**95**</td></tr><tr><td>26</td><td>34</td><td>16</td><td>63</td><td>39</td><td>**95**</td></tr></tbody></table>**Output**<br>4| 3 4<table><tbody><tr><td>**ha**</td><td>fifi</td><td>ho</td><td>hi</td></tr><tr><td>fo</td><td>**ha**</td><td>hi</td><td>xx</td></tr><tr><td>xxx</td><td>ho</td><td>**ha**</td><td>xx</td></tr></tbody></table><br><br><br><br>**Output**<br>3|

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/316#2)
