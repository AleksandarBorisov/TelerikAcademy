<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 3 February 2015 Evening_

# Task 1: A, B and C

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/205)

## Description   

You are given 3 integer number **A**, **B** and **C**. Find:  
 •	The biggest number among them  
 •	The smallest number among them  
 •	The _arithmetic mean_ of the three numbers  
The _arithmetic mean_ is the sum of a collection of numbers divided by the number of numbers in the collection. The result should be rounded with 3 digits after the decimal point.  

## Input  

The input data should be read from the console.  
The number **A** will be given on the first console line.  
The number **B** will be given on the second console line.  
The number **C** will be given on the third console line.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed on the console.  
On the first output line print the biggest number among **A**, **B** and **C**.  
On the second output line print the smallest number among **A**, **B** and **C**.  
On the third output line print the arithmetic mean of the number **A**, **B** and **C** with precision **3 digits** after the decimal point (Hint: use the formatting string {0:F3} for outputting the answer)

## Constraints

•	**A**, **B** and **C** will be integer numbers between -200 000 000 and 200 000 000, inclusive.  
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

## Examples

|Example Input|Example output|Explanation|
|-------------|--------------|-----------|
|1<br>2<br>3|3<br>1<br>2.000||
|-2<br>-2<br>2|2<br>-2<br>-0.667|Here the exact arithmetic mean is -0.6666666666…<br> but when rounded to the second digit after the<br>decimal point we come up with -0.667|

