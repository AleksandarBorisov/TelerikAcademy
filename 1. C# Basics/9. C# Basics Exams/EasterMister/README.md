<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2013-2014 / C# Fundamentals Exam - 5 December 2013 Morning_

# Task 4: Easter Mister

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Register/104#3)

## Description  
 
Little Basil is in a festive mood. However he is not very good with dates and instead of preparing for the Christmas holidays he started preparing for another famous holiday – **Easter**. Not only this, but he is also not very good at **decorating eggs**. All he wanted is for his eggs to have a small ribbon in the middle, but alas - after hours and hours of trying all he got were a **dozen omelets**. This made him both sad and angry and even though soon it will be Christmas and not Easter, he as very **disappointed**.  
Your task is to help Basil in **painting his eggs**.  
Of course not all eggs are the same – some are bigger and some are smaller than others. You will be given a number **N** which shows the **size** of the egg.   
The **height** of the egg is 2 times the input (**2 * N**). The **width of the egg** is **3 * N – 1** and the **width of the drawing area** is **3 * N + 1**. The sizes of the **top and the bottom of the egg** are **N – 1**.  
The ribbon must be made in the middle of the egg. It must be drawn on **2 lines** and with the ‘**#**’ and ‘**.**’ characters alternating. The first line must start with a ‘**.**’ and the second ‘**#**’.  

## Input  

The input data should be read from the console.  
You have an integer number **N** - the **size** of the egg.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output should be printed on the console.  
Use the “**\***” character for the outer shell, the “**#**” character for the ribbon and “**.**” (dot) for the rest.

## Constraints

- N will always be an **even positive number** between **2** and **26** inclusive.
- Allowed working time for your program: **0.1** seconds.
- Allowed memory: **16 MB**.

## Examples

|Example input|Example output|Example input|Example output|Example input|Example output|
|:-------------|:--------------|:-------------|:--------------|:-------------|:--------------|
|2<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`...*...`<br/>`.*.#.*.`<br/>`.*#.#*.`<br/>`...*...`<br/><br/><br/><br/><br/><br/><br/><br/><br/>|4<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`.....***.....`<br/>`...*.....*...`<br/>`.*.........*.`<br/>`.*.#.#.#.#.*.`<br/>`.*#.#.#.#.#*.`<br/>`.*.........*.`<br/>`...*.....*...`<br/>`.....***.....`<br/><br/><br/><br/><br/>|6<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`.......*****.......`<br/>`.....*.......*.....`<br/>`...*...........*...`<br/>`.*...............*.`<br/>`.*...............*.`<br/>`.*.#.#.#.#.#.#.#.*.`<br/>`.*#.#.#.#.#.#.#.#*.`<br/>`.*...............*.`<br/>`.*...............*.`<br/>`...*...........*...`<br/>`.....*.......*.....`<br/>`.......*****.......`|















