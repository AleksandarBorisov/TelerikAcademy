<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2013-2014 / C# Fundamentals Exam - 5 December 2013 Morning_

# Task 3: Binary Digits

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Register/104#2)

## Description  
 
You are given a non-negative integer number **N**. Your task is to print the **last 16 bits** of the binary representation of **N** on the console. Every bit is printed in a rectangular area with **4 rows** and **3 columns**.   
A bit with value of **1** should be printed in the format:  
`.#.`  
`##.`  
`.#.`  
`###`  
A bit with value of **0** should be printed in the format:  
`###`  
`#.#`  
`#.#`  
`###`  
Between every single bit there should be an **empty column containing only dots (".")**.

## Input  

The input data should be read from the console.  
On the only input line there will be a **non-negative integer number N** which bits must be printed on the console.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output should be printed on the console.  
You should print **the last 16 bits** of **N** on the console in the described format.  
Your output should contain exactly 4 lines with 63 symbols on each line. Symbols should be only hashes ("**#**") and dots ("**.**").

## Constraints

- The number **N** will be a non-negative integer number between 0 and 2147483647, inclusive.
- The only `C#` Console methods that you are allowed to use are `Console.Write()` and `Console.WriteLine()`. This means that `Console.SetCursorPosition()` will not work. 
- Allowed working time for your program: **0.10** seconds. 
- Allowed memory: **16 MB**.

## Examples

|Input example|Output example|
|:-------------|:--------------|
|1<br/><br/><br/><br/>|`###.###.###.###.###.###.###.###.###.###.###.###.###.###.###..#.`<br/>`#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.##.`<br/>`#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#..#.`<br/>`###.###.###.###.###.###.###.###.###.###.###.###.###.###.###.###`|
|1234<br/><br/><br/><br/>|`###.###.###.###.###..#..###.###..#...#..###..#..###.###..#..###`<br/>`#.#.#.#.#.#.#.#.#.#.##..#.#.#.#.##..##..#.#.##..#.#.#.#.##..#.#`<br/>`#.#.#.#.#.#.#.#.#.#..#..#.#.#.#..#...#..#.#..#..#.#.#.#..#..#.#`<br/>`###.###.###.###.###.###.###.###.###.###.###.###.###.###.###.###`|
|65535<br/><br/><br/><br/>|`.#...#...#...#...#...#...#...#...#...#...#...#...#...#...#...#.`<br/>`##..##..##..##..##..##..##..##..##..##..##..##..##..##..##..##.`<br/>`.#...#...#...#...#...#...#...#...#...#...#...#...#...#...#...#.`<br/>`###.###.###.###.###.###.###.###.###.###.###.###.###.###.###.###`|















