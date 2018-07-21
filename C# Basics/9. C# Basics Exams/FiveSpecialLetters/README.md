#### _SoftUni C# Basics Exam - 12 April 2014 Evening_

# Task 4: Five Special Letters

## Submit your solution [here](https://judge.softuni.bg/Contests/Practice/Index/7#3)

## Description   

We are given two numbers: **start** and **end**. Write a program to **generate all sequences of 5 letters**, each from the set { '**a**', '**b**', '**c**', '**d**', '**e**' }, such that the weight of these 5 letters is a number in the range [**start … end**] inclusively. Print them in alphabetical order, in a single line, separated by a space.  
The **weight of a single letter** is calculated as follows:  weight('**a**') = **5**; weight('**b**') = **-12**;  weight('**c**') = **47**;  weight('**d**') = **7**;  weight('**e**') = **-32**. The **weight of a sequence** of letters c~1~c~2~…c~n~ is the calculated by first removing all repeating letters (from right to left) and then calculate the formula: 

                        weight(c~1~c~2~…c~n~) = 1\*weight(c~1~) + 2\*weight(c~2~) + … + n\*weight(c~n~)  

For example, the weight of "**bcddc**" is calculated as follows: First we remove the repeating letters and we get "**bcd**". Then we apply the formula: 1\*weight('**b**') + 2\*weight('**c**') + 3\*weight('**d**') = 1\*(-12) + 2\*47 + 3\*7 = 103. Another example: weight("cadea") = weight("cade") = 1\*47 + 2\*5 + 3\*7 - 4\*32 = -50.

## Input  

The input data should be read from the console. It will consist of 2 lines:
- The number **start** stays at the first line.
- The number **end** stays at the second line.
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output should be printed on the console as a sequence of strings in **alphabetical order**. Each string should be separated than the next string by a single space. In case no 5-letter strings exist with a weight in the specified range, print “**No**”.

## Constraints

- The numbers **start** and **end** will be an **integers** in the range [-10000…10000].  
- Allowed working time for your program: **0.25** seconds.  
- Allowed memory: **16 MB**.  

## Examples

|Input|Output|Comments|
|:-------------|:--------------|:--------------|
|40<br/>42<br/><br/><br/>|bcead bdcea<br/><br/><br/><br/>|weight("bcead") = 41<br/>weight("bdcea") = 40|
|-1<br/>1<br/><br/>|bcdea cebda eaaad eaada eaadd eaade eaaed eadaa eadad eadae eadda eaddd eadde eadea eaded eadee eaead eaeda eaedd eaede eaeed eeaad eeada eeadd eeade eeaed eeea||
|200<br/>300<br/><br/>|baadc babdc badac badbc badca badcb badcc badcd baddc bbadc bbdac bdaac bdabc bdaca bdacb bdacc bdacd bdadc bdbac bddac beadc bedac eabdc ebadc ebdac edbac||
|300<br/>400|No<br/><br/>||


