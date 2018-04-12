<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2013-2014 / C# Fundamentals Exam - 24 June 2013 Evening_

# Task 2: The Secrets of Numbers

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/93#1)

## Description   

The **special sum** of a number is the **sum of its digits** calculated by the following algorithm:  
- Each digit with odd position from right to left adds to the special sum its value multiplied by the square of its position in the number. 
- Each digit with even position from right to left adds to the special sum the square of its value multiplied by its position in the number.  

For example if the number is 37 its special sum is 7 * 1^2^ + 3^2^ * 2 = 25. Another example: if the number is 111 its special sum is 1 * 1^2^ + 1^2^ * 2 + 1 * 3^2^ = 12.  
The **secret alpha-sequence** of a number is a **sequence of capital letters** from the **English alphabet** constructed **by the number’s special sum**. The length of the sequence is indicated by the last digit of the number’s special sum. If this length is 0 the number **has no** secret alpha-sequence.   
The number **R** represents the remainder of a number’s special sum divided by the number of letters in the alphabet (26). The **first letter** of the alpha-sequence is the letter from the English alphabet at position equal to the **sum R + 1**. Every next letter in the secret alpha-sequence is the next letter of the alphabet. If the last letter (‘Z’) is reached the sequence afterwards continues from the first letter of the alphabet (‘A’).  
For example if the special sum of a number is 3, its secret alpha-sequence is “DEF”. Another example: if the special sum of a number is 48 its secret alpha-sequence is “WXYZABCD”.  
Write a program that finds the special sum and the secret alpha-sequence of an **integer number N**.

## Input  

The input data should be read from the console. The only input line contains the integer number **N** to which the secret alpha-sequence is to be found. The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed on the console. The output consists of two lines. On the **first output line** you must print input number’s **special sum** and on the **second output line** you must print its **secret alpha-sequence** or indicate its **absence** in format: “**X has no secret alpha-sequence**” where ‘**X**’ is the input number.

## Constraints

- The integer number **N** will have no more than 400 digits.
- Allowed working time for your program: **0.1** seconds.
- Allowed memory: **16 MB**.

## Examples

|Input|Output|Input|Output|Input|Output|
|:-------------|:--------------|:-------------|:--------------|:-------------|:--------------|
|3<br/><br/>|3<br/>DEF|22<br/><br/>|10<br/>22 has no secret alpha-sequence|424<br/><br/>|48<br/>WXYZABCD|







