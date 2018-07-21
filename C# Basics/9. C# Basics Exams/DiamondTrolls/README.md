<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2013-2014 / C# Fundamentals Exam - 6 December 2013 Morning_

# Task 4: Diamond Trolls

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/106#3)

## Description  
 
In the peaceful village of Tel’Er’ik the two internet trolls Baa Zil and Juliette fell in love. After years of sharing a small swamp Baa Zil decided he wanted to propose to his girlfriend troll. So he went to the mall and bought flowers and a lovely “diamond” silver ring. But later that day he noticed that the “diamond” was actually a fake piece of plastic.   
Now this is where you come in – your task is to create a diamond for Baa Zil with which he can propose to his kind-of-cute-for-a-troll girlfriend. He will give you the size **N** for the top of the diamond and you must create it for him.  
The width of the diamond must be **N*2 + 1**.   
The height must be **(6 + ((N – 3) / 2) * 3)**.  
The diamond must have a line going vertically through its middle and a horizontal line where the top and the bottom parts connect.  

## Input  

The input data should be read from the console.  
You have an integer number **N** – the **width** of the top of the diamond.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output should be printed on the console.  
Use the “**\***” (star) characters for the lines and “**.**” (dot) for the rest.  

## Constraints

- **N** will always be a positive number between **3** and **27** inclusive.
- Allowed working time for your program: **0.1** seconds.
- Allowed memory: **16 MB**.

## Examples

|Example input|Example output|Example input|Example output|Example input|Example output|
|:-------------|:--------------|:-------------|:--------------|:-------------|:--------------|
|3<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`..***..`<br/>`.*.*.*.`<br/>`*******`<br/>`.*.*.*.`<br/>`..***..`<br/>`...*...`<br/><br/><br/><br/><br/><br/><br/>|5<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`...*****...`<br/>`..*..*..*..`<br/>`.*...*...*.`<br/>`***********`<br/>`.*...*...*.`<br/>`..*..*..*..`<br/>`...*.*.*...`<br/>`....***....`<br/>`.....*.....`<br/><br/><br/><br/>|7<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`....*******....`<br/>`...*...*...*...`<br/>`..*....*....*..`<br/>`.*.....*.....*.`<br/>`***************`<br/>`.*.....*.....*.`<br/>`..*....*....*..`<br/>`...*...*...*...`<br/>`....*..*..*....`<br/>`.....*.*.*.....`<br/>`......***......`<br/>`.......*.......`|


















