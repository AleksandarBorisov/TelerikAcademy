<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 3 February 2015 Morning_

# Task 5: Search in Bits

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/204#4)

## Description   

You are given a list of **N** numbers and a number **S**.  
Count the occurrences of the most right **4 bits** of **S** in the most right **30 bits** in **every given number**.  
For example there are 3 occurrences of the 4 most right bits of 9 in the number 1177.  
The 4 most right bits of 9 are 1001 and the 30 most right bits in the number 1177 are 000000000000000000010010011001.  
The occurrences are:  
•	0000000000000000000<ins>**1001**</ins>0011001  
•	0000000000000000000100<ins>**1001**</ins>1001  
•	00000000000000000001001001<ins>**1001**</ins>   
It is allowed for one occurrence to be part of another one (like the first and the second one in the above example).

## Input  

The input data should be read from the console.  
On the first line there will be the number **S**.  
On the second line there will be the number **N**.  
On each of the next **N** lines there will be a number from the list.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed on the console.  
On the only output line print the number of occurrences found.  

## Constraints

•	**N** will be an integer between 1 and 100, inclusive.  
•	**S** will be an integer between 0 and 15, inclusive.  
•	All numbers will be integers between 0 and 1073741823, inclusive.  
•	Allowed working time for your program: 0.1 seconds.  
•	Allowed memory: 16 MB.  

## Example

|Example input|Example output|Explanation|
|:-------------|:--------------|:--------------|
|9<br/>1<br/>1177<br/><br/><br/>|3<br/><br/><br/><br/><br/>|The 4 bits of S are 1001<br/>There are **3** occurrences in the number:<br/>0000000000000000000<ins>**1001**</ins>0011001<br/>0000000000000000000100<ins>**1001**</ins>1001<br/>00000000000000000001001001<ins>**1001**</ins>
|
|4<br/>3<br/>4<br/>536873260<br/>536870912<br/><br/><br/><br/>|3<br/><br/><br/><br/><br/><br/><br/><br/>|The bits of S are 0100<br/>There is **1** occurrence in the first number:<br/>00000000000000000000000000**0100**<br/>There are **2** occurrences in the second number:<br/>10000000000000000**0100**100101100<br/>10000000000000000010**0100**101100<br/>There are no occurrences in the third number.<br/>100000000000000000000000000000|


