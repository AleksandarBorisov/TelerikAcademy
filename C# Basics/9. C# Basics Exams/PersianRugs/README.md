<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 3 February 2015 Morning_

# Task 4: Persian rugs

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/204#3)

## Description   

**Ivcho** is the little brother of the infamous Ivancho. He is much more intelligent and much less a dangler than his brother. He was also known to be a very good entrepreneur. As such he was constantly looking for some business opportunity also known as ‘**dalavera’**. One day he noticed that people are buying more and more **Persian rugs** to compensate for the lack of heating. Immediately he knew he had to start producing rugs. Being a **computer- and techno- geek** he wanted to automate the process as much as possible.  
Your task is to help **Ivcho** with his production by writing a program that prints rug designs on the console. He needs the rugs to come out in different sizes depending on his client’s preferences and have variations in the design pattern as well. Draw the two diagonals with “**\\**” and “**/**” and big **X** mark in the center of the rug, where the two diagonals cross. Fill in the two side triangles with “**#**” and draw a smaller triangle in the top and bottom triangles.  
The client will enter **two numbers** each on separate lines.  
•	The first number **N** between **2** and **100** (inclusive) determines the rug’s width = height = **2 * N + 1**.  
•	The second number **D** between **0** and **100** (inclusive) is for the distance between the smaller triangle and the larger as shown on the examples.  
_Note: **D** can be larger than **N**._

## Input  

The input data should be read from the console.
On the first row you have an integer number **N** between **2** and **100** (inclusive) – determines the height and width of the rug: **height = width = 2 * N + 1**.   
On the second row you have an integer number **D** between **0** and **100** (inclusive) – the distance (in spaces) between the small triangle and the large one as shown in the examples.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output should be printed on the console.  
You should print the Persian rug on the console. Each row can contain only the following characters: “ ” (space),”**.**” (dot), “**X**” (letter X), “**/**” (slash), “**\\**” (backslash) and “**#**” (hashtag). As shown in the example.  

## Constraints

•	The number **N** will be a positive integer number between **2** and **100**, inclusive.  
•	The number **D** will be a positive integer number between **0** and **100**, inclusive.  
•	Allowed working time for your program: **0.1** seconds.  
•	Allowed memory: **16** MB.  


## Example

|Input example|Output example|Input example|Output example|Input example|Output example|
|:-------------|:--------------|:-------------|:--------------|:-------------|:-------------|
|5<br/>2<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`\  \.../  /`<br/>`#\  \./  /#`<br/>`##\     /##`<br/>`###\   /###`<br/>`####\ /####`<br/>`#####X#####`<br/>`####/ \####`<br/>`###/   \###`<br/>`##/     \##`<br/>`#/  /.\  \#`<br/>`/  /...\  \`<br/><br/><br/>|3<br/>0<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`\\...//`<br/>`#\\.//#`<br/>`##\ /##`<br/>`###X###`<br/>`##/ \##`<br/>`#//.\\#`<br/>`//...\\`<br/><br/><br/><br/><br/><br/><br/>|6<br/>10<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|`\           /`<br/>`#\         /#`<br/>`##\       /##`<br/>`###\     /###`<br/>`####\   /####`<br/>`#####\ /#####`<br/>`######X######`<br/>`#####/ \#####`<br/>`####/   \####`<br/>`###/     \###`<br/>`##/       \##`<br/>`#/         \#`<br/>`/           \`|

