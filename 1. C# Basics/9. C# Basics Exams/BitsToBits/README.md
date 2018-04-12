<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 2 February 2015 Morning_

# Task 5: Bits to Bits

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/202#4)

## Description   

You are given a list of **N** numbers.  
Get the most right **30 bits** of every number and concatenate them.  
Write a program to find the length of the **longest sequence of zeroes** and the length of the **longest sequence of ones** from the obtained concatenated sequence.  
See examples for clarification.  

## Input  

The input data should be read from the console.  
On the first line there will be the number **N**.  
On each of the next **N** lines there will be a number from the list.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed on the console.  
On the first output line print the length of the longest sequence of zeroes.  
On the second output line print the length of the longest sequence of ones.

## Constraints

- **N** will be between **1** and **100**, inclusive.  
- All numbers will be integers between **0** and **1073741823**, inclusive.  
- Allowed working time for your program: **0.1** seconds. 
- Allowed memory: **16 MB**.  

## Example

|Example input|Example output|Explanation|
|:-------------|:--------------|:--------------|
|2<br/>3<br/>1073737743|28<br/>20<br/><br/>|Bit sequence:<br/>==0000000000000000000000000000==<ins>11</ins><br/><ins>111111111111111111</ins>000000001111|
|3<br/>715827882<br/>715827882<br/>357913941|2<br/>1<br/><br/><br/>|Bit sequence:<br/><ins>1</ins>01010101010101010101010101010<br/>10101010101010101010101010101==0==<br/>==0==10101010101010101010101010101
|4<br/>262267<br/>1337<br/>10000000<br/>28244445|19<br/>5<br/><br/><br/><br/>|Bit sequence:<br/>000000000001000000000001111011<br/>==0000000000000000000==10100111001<br/>000000100110001001011010000000<br/>00000110101110<ins>11111</ins>00111011101|

