<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2013-2014 / C# Fundamentals Exam - 23 June 2013_

# Task 3: Bulls and Cows

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/91#2)

## Description   

All we love the “Bulls and Cows” game (http://en.wikipedia.org/wiki/Bulls_and_cows). Given a 4-digit **secret number** and a 4-digit **guess number** we say that we have **b bulls** and **c cows** when we have **b** matching digits on their right positions (bulls) and **c** matching digits on different positions (cows). Examples are given below:

|Secret number|1|4|8|1|Bulls = 1|
|-------------|-|-|-|-|----------|
|**Guess number**|**8**|**8**|**1**|**1**|**Cows = 2**|

|Secret number|2|2|4|9|Bulls = 0|
|-------------|-|-|-|-|----------|
|**Guess number**|**9**|**9**|**2**|**4**|**Cows = 3**|

Given the secret number and the number of bulls and cows your task is to write a program to **find all matching guess numbers** in increasing order.

## Input  

The input data should be read from the console. It will consist of exactly 3 lines. At the first line there **the secret number** will be given. At the second line the number of bulls **b** will be given. At the third line the number of cows **c** will be given.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed on the console. It should consist of a single line holding all matched guess numbers, given in increasing order, separated by single space.

## Constraints

- The **secret number** will always consist of exactly 4 digits, each in the range [1…9].
- The numbers **b** and **c** will be in the range [0…9].
- Allowed working time for your program: **0.15** seconds.
- Allowed memory: **4 MB**.

## Example

|Input|Output|Input|Output|Input|Output|
|:-------------|:--------------|:-------------|:--------------|:-------------|:--------------|
|2228<br/>2<br/>1<br/><br/><br/><br/><br/><br/><br/><br/><br/>|1222 2122 2212 2232<br/>2242 2252 2262 2272<br/>2281 2283 2284 2285<br/>2286 2287 2289 2292<br/>2322 2422 2522 2622<br/>2722 2821 2823 2824<br/>2825 2826 2827 2829<br/>2922 3222 4222 5222<br/>6222 7222 8221 8223<br/>8224 8225 8226 8227<br/>8229 9222|1234<br/>3<br/>0<br/><br/><br/><br/><br/><br/><br/><br/><br/>|1134 1214 1224 1231<br/>1232 1233 1235 1236<br/>1237 1238 1239 1244<br/>1254 1264 1274 1284<br/>1294 1334 1434 1534<br/>1634 1734 1834 1934<br/>2234 3234 4234 5234<br/>6234 7234 8234 9234<br/><br/><br/><br/>|1234<br/>3<br/>1<br/><br/><br/><br/><br/><br/><br/><br/><br/>|No<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|





