<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2013-2014 / C# Fundamentals Exam - 5 December 2013 Morning_

# Task 1: American Pie

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Register/104#0)

## Description  
 
People love pie. Especially Americans! They really love sweet nice just now baked pies. And you certainly love American Pie! We know you do, don’t try to argue!  
Talking about pies, uncle Pi (not to be mistaken with the math Pi – 3.141592653589793) owns a bakery. He sells very delicious pies. His little dirty secret is that he actually gets the pies from **outside shops**.  Two, if we have to be precise. Every morning uncle Pi receives **two packages full of cut pie pieces**. The problem is that each package’s pies are cut into **different amount of pieces**, giving uncle Pi two kinds of pies to sell. His solution is **to divide the pieces into smaller pieces** so that they have the **same size**. You should help uncle Pi and not by cutting his pies, but by writing a computer program to calculate how much pieces and complete pies he will have after the final cuts.  
If you are not familiar with math fractions – shame on you but here it is an explanation! Fraction **F/G** consists of two parts – nominator (**F**) and denominator (**G**). The decimal value of every fraction is equal to the denominator dividing the nominator.  For example the fraction **4/2** is equal to **2**. Also on one given fraction you can multiply the nominator and the denominator by a number and the fraction’s value will not change. For example **2/5** is equal to **4/10**.   
You are given two fractions **A/B** and **C/D** representing parts of the two types of pies. **A**, **B**, **C** and **D** are always **positive integers**. You should calculate the total amount of pie you have from the two packages. In other words your task is to find the sum between the two fractions of pies. If you receive at least one complete full pie, you should calculate only the amount of full pies from the result. For example **5/2 pies are 2 pies and a half**. Your final result is **2**. Otherwise, if you receive less than one full pie, you should calculate the decimal result, with exactly **20 digits after the decimal point** - rounded. For example **2/3** pies are equal to **0.66666666666666666667** pies as final result. In both cases you should calculate the fraction result with denominator equal to **B * D**. For example **2/4 + 2/3 = 14/12**.  

## Input  

The input data should be read from the console.  
On the first input line you will receive the positive integer **A**.  
On the second input line you will receive the positive integer **B**.  
On the third input line you will receive the positive integer **C**.  
On the fourth input line you will receive the positive integer **D**.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output should be printed on the console.  
If there is at least one complete pie, on the first output line you should print the amount of **complete pies**.  
Otherwise, on the first output line you should print the **decimal result with exactly 20 digits after the decimal point**.  
On the second output line, you should print the **final fraction result with denominator equal to B * D**.


## Constraints

- **A**, **B**, **C**, **D** will be positive integers between **1** and **999 999**, inclusive.
- Allowed working time for your program: **0.10** seconds. 
- Allowed memory: **16 MB**.

## Examples

|Input example|Output example|Input example|Output example|
|:-------------|:--------------|:-------------|:--------------|
|2<br/>4<br/>2<br/>3|1<br/>14/12<br/><br/><br/>|1<br/>5<br/>2<br/>8|0.45000000000000000000<br/>18/40<br/><br/><br/>|















