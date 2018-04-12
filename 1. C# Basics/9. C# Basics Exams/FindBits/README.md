<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 3 February 2015 Evening_

# Task 5: Find Bits

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/205#4)

## Description   

You are given a list of **N** numbers and a number **S**.   
Count the occurrences of the most right **5 bits** of **S** in the most right **29 bits** in **every given number**.   
For example there are 3 occurrences of the 5 most right bits of 9 in the number 9369.   
The 5 most right bits of 9 are 01001 and the 29 most right bits in the number 9369 are 00000000000000010010010011001.   
The occurrences are:   
•	00000000000000<ins>**01001**</ins>0010011001   
•	00000000000000010<ins>**01001**</ins>0011001  
•	00000000000000010010<ins>**01001**</ins>1001  
It is allowed for one occurrence to be part of another one (like in the example above).  


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

•	**N** will be an integer between **1** and **100**, inclusive.  
•	**S** will be an integer between **0** and **31**, inclusive.  
•	All numbers will be integers between **0** and **536870911**, inclusive.  
•	Allowed working time for your program: **0.1** seconds.  
•   Allowed memory: **16** MB.  


## Example

|Example input|Example output|Explanation|
|:-------------|:--------------|:--------------|
|9<br/>1<br/>9369<br/><br/>|3<br/><br/><br/><br/>|The 5 bits of S are 01001<br/>There are **3** occurrences in the number:<br/>00000000000000<ins>**01001**</ins>0010011001<br/>00000000000000010<ins>**01001**</ins>0011001<br/>00000000000000010010<ins>**01001**</ins>1001|
|4<br/>3<br/>4<br/>268437804<br/>268435456<br/><br/><br/><br/>|3<br/><br/><br/><br/><br/><br/><br/><br/>|The bits of S are 00100<br/>There is **1** occurrence in the first number:<br/>000000000000000000000000<ins>**00100**</ins><br/>There are **2** occurrences in the second number:<br/>100000000000000<ins>**00100**</ins>100101100<br/>100000000000000001<ins>**00100**</ins>101100<br/>There are no occurrences in the third number.<br/>10000000000000000000000000000<br/>|


