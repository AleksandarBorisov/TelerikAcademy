<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 3 February 2015 Evening_

# Task 3: ConsoleApplication2

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/205#2)

## Description   

Every mediocre programmer does not care about his code. He just finishes the job as quickly as possible, runs the project – if it works, he leaves it. This is an example of a bad, bad programmer (not to be confused with “bad, bad girl”). One who does not name his solutions, projects, files, classes, methods and variables in a correct meaningful and easy to read way. One who is sloppy, messy, lazy and not eager to gain new knowledge every single day. Remember that, folks, remember it from your good-intentioned trainers!  
Your task is to create a program named “**ConsoleApplication2”** which solves the following task. You will receive **N** numbers from the input. You will have to select those who are in **even** positions (starting from zero) and calculate the product of their **digits**. If one of the digits is **zero**, **ignore it** in the calculations. If the number itself is zero, consider the product of its digits to be **1**. Afterwards find the product of all previously found products as the final result.  
Let’s make it more interesting. If the input numbers are **more than 10**, **calculate** the result from the formula above **for the first 10 numbers** and **then calculate** it again **for all other numbers** after the 10th. If the numbers are **less or equal to 10**, **calculate** the result **for all numbers** of the input.  
Example:
1.	Input numbers are – **123, 456, 789, 1238, 856**
2.	Input numbers are less than **10** – we calculate the result for all of numbers
3.	We select all numbers in even positions – **123**, **789** and **856**
4.	We find the product of all digits of **123**– 1 * 2 * 3 = **6**
5.	We find the product of all digits of **789** – 7 * 8 * 9 = **504**
6.	We find the product of all digits of **856** – 8 * 5 * 6 = **240**
7.	We find the product of all found products – 6 * 504 * 240 = **725760**


## Input  

The input data should be read from the console.  
On the first **N** input lines you will receive one number per line.  
On the **N + 1**st line you will receive “**END**” as string (without the quotes). You should read and parse numbers until you reach “**END**”.  
The input data will always be valid and in the format described. There is no need to check it explicitly.


## Output

The output data should be printed on the console.  
If there were less or equal to 10 initial input numbers – print the final product on the only output line.  
If there were more than 10 initial input numbers – print the final product of from the first 10 numbers of the input on the first output line and the final product from all other numbers of the input on the second output line.


## Constraints

•	N will be between **2** and **10 000**, inclusive.  
•	All numbers will be between **100** and **999 999 999 999 999 999**.  
•	Allowed working time for your program: **0.2** seconds.  
•	Allowed memory: **32** MB.

## Example

|Example input|Example output|
|:-------------|:--------------|
|123<br/>456<br/>789<br/>1238<br/>856<br/>END|725760<br/><br/><br/><br/><br/><br/>|
|**Input**|**Output**|
|123<br/>456<br/>789<br/>123<br/>567<br/>901<br/>345<br/>890<br/>345<br/>901<br/>567<br/>123<br/>END|2286144000<br/>210<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|


