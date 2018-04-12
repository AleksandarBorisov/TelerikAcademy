<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 2 February 2015 Evening_

# Task 2: Encoding Sum

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/203#1)

## Description   

You are given a text and a number (M). The text can contain any characters: (**digits**, **Latin letters** (both capital and letter case) or **any other symbols**). The character '**@' is special** – it marks the end of the text.   
Your task is to iterate the text and to perform an operation for every character. Having a RESULT = 0, the operations are as follows:  
- If the current character is '@', stop the program and print the value of RESULT  
- If the current character is a digit (‘0’ – ‘9’), then multiply the RESULT by this digit  
- If the current character is a letter, add its index from the Latin alphabet to RESULT.   
  - 'A' has an index 0, ‘B’ has an index 1, etc…  
- If the current character is a symbol, that is different from the ones described above, create module of the RESULT by the provided number (M)  
- See the sample input/output for more detailed explanation  

## Input  

The input data is given at the standard input.   
It consists of two lines:  
- The first one contains the number M, that is used for the module of the result  
- The second line contains the text  

The input will be valid, in the specified format, within the constraints given below. There is no need to check the input data explicitly.

## Output

Print the result from the parsing (RESULT)

## Constraints

- **M** will always be between **2000** and **10 000**
- The length of the text will always be less than **100 000**
- Allowed working time for your program: **0.5** seconds.
- Allowed memory: **16 MB**.


## Example

|Input|Output|Description|
|:-------------|:--------------|:--------------|
|2001<br/>Hello .NET 5! My name is Peter 8-)@<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|518<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|RESULT = 0 + 7(H) = 7<br/>RESULT = 7 + 4(e) = 11<br/>RESULT = 11 + 11(l) = 22<br/>RESULT = 22 + 11(l) = 33<br/>RESULT = 33 + 14(o) = 47<br/>RESULT = 47 % 2001( ) = 47<br/>RESULT = 47 % 2001(.) = 47<br/>RESULT = 47 + 13(N) = 60<br/>RESULT = 60 + 4(E) = 64<br/>RESULT = 64 + 19(T) = 83<br/>RESULT = 83 % 2001( ) = 83<br/>RESULT = 83 * 5(5) = 415<br/>RESULT = 415 % 2001(!) = 415<br/>RESULT = 415 % 2001( ) = 415<br/>RESULT = 415 + 12(M) = 427<br/>RESULT = 427 + 24(y) = 451<br/>RESULT = 451 % 2001( ) = 451<br/>RESULT = 451 + 13(n) = 464<br/>RESULT = 464 + 0(a) = 464<br/>RESULT = 464 + 12(m) = 476<br/>RESULT = 476 + 4(e) = 480<br/>RESULT = 480 % 2001( ) = 480<br/>RESULT = 480 + 8(i) = 488<br/>RESULT = 488 + 18(s) = 506<br/>RESULT = 506 % 2001( ) = 506<br/>RESULT = 506 + 15(P) = 521<br/>RESULT = 521 + 4(e) = 525<br/>RESULT = 525 + 19(t) = 544<br/>RESULT = 544 + 4(e) = 548<br/>RESULT = 548 + 17(r) = 565<br/>RESULT = 565 % 2001( ) = 565<br/>RESULT = 565 * 8(8) = 4520<br/>RESULT = 4520 % 2001(-) = 518<br/>RESULT = 518 % 2001()) = 518<br/>|
|2222<br/>Starwars 4, 5 and 6 are better that 1, 2 and 3@<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|1332<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|RESULT = 0 + 18(S) = 18<br/>RESULT = 18 + 19(t) = 37<br/>RESULT = 37 + 0(a) = 37<br/>RESULT = 37 + 17(r) = 54<br/>RESULT = 54 + 22(w) = 76<br/>RESULT = 76 + 0(a) = 76<br/>RESULT = 76 + 17(r) = 93<br/>RESULT = 93 + 18(s) = 111<br/>RESULT = 111 % 2222( ) = 111<br/>RESULT = 111 * 4(4) = 444<br/>RESULT = 444 % 2222(,) = 444<br/>RESULT = 444 % 2222( ) = 444<br/>RESULT = 444 * 5(5) = 2220<br/>RESULT = 2220 % 2222( ) = 2220<br/>RESULT = 2220 + 0(a) = 2220<br/>RESULT = 2220 + 13(n) = 2233<br/>RESULT = 2233 + 3(d) = 2236<br/>RESULT = 2236 % 2222( ) = 14<br/>RESULT = 14 * 6(6) = 84<br/>RESULT = 84 % 2222( ) = 84<br/>RESULT = 84 + 0(a) = 84<br/>RESULT = 84 + 17(r) = 101<br/>RESULT = 101 + 4(e) = 105<br/>RESULT = 105 % 2222( ) = 105<br/>RESULT = 105 + 1(b) = 106<br/>RESULT = 106 + 4(e) = 110<br/>RESULT = 110 + 19(t) = 129<br/>RESULT = 129 + 19(t) = 148<br/>RESULT = 148 + 4(e) = 152<br/>RESULT = 152 + 17(r) = 169<br/>RESULT = 169 % 2222( ) = 169<br/>RESULT = 169 + 19(t) = 188<br/>RESULT = 188 + 7(h) = 195<br/>RESULT = 195 + 0(a) = 195<br/>RESULT = 195 + 19(t) = 214<br/>RESULT = 214 % 2222( ) = 214<br/>RESULT = 214 * 1(1) = 214<br/>RESULT = 214 % 2222(,) = 214<br/>RESULT = 214 % 2222( ) = 214<br/>RESULT = 214 * 2(2) = 428<br/>RESULT = 428 % 2222( ) = 428<br/>RESULT = 428 + 0(a) = 428<br/>RESULT = 428 + 13(n) = 441<br/>RESULT = 441 + 3(d) = 444<br/>RESULT = 444 % 2222( ) = 444<br/>RESULT = 444 * 3(3) = 1332|
|9999<br/>My nickname, when I was 25, was Pencho8473848399 ;-)@<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|2943<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|RESULT = 0 + 12(M) = 12<br/>RESULT = 12 + 24(y) = 36<br/>RESULT = 36 % 9999( ) = 36<br/>RESULT = 36 + 13(n) = 49<br/>RESULT = 49 + 8(i) = 57<br/>RESULT = 57 + 2(c) = 59<br/>RESULT = 59 + 10(k) = 69<br/>RESULT = 69 + 13(n) = 82<br/>RESULT = 82 + 0(a) = 82<br/>RESULT = 82 + 12(m) = 94<br/>RESULT = 94 + 4(e) = 98<br/>RESULT = 98 % 9999(,) = 98<br/>RESULT = 98 % 9999( ) = 98<br/>RESULT = 98 + 22(w) = 120<br/>RESULT = 120 + 7(h) = 127<br/>RESULT = 127 + 4(e) = 131<br/>RESULT = 131 + 13(n) = 144<br/>RESULT = 144 % 9999( ) = 144<br/>RESULT = 144 + 8(I) = 152<br/>RESULT = 152 % 9999( ) = 152<br/>RESULT = 152 + 22(w) = 174<br/>RESULT = 174 + 0(a) = 174<br/>RESULT = 174 + 18(s) = 192<br/>RESULT = 192 % 9999( ) = 192<br/>RESULT = 192 * 2(2) = 384<br/>RESULT = 384 * 5(5) = 1920<br/>RESULT = 1920 % 9999(,) = 1920<br/>RESULT = 1920 % 9999( ) = 1920<br/>RESULT = 1920 + 22(w) = 1942<br/>RESULT = 1942 + 0(a) = 1942<br/>RESULT = 1942 + 18(s) = 1960<br/>RESULT = 1960 % 9999( ) = 1960<br/>RESULT = 1960 + 15(P) = 1975<br/>RESULT = 1975 + 4(e) = 1979<br/>RESULT = 1979 + 13(n) = 1992<br/>RESULT = 1992 + 2(c) = 1994<br/>RESULT = 1994 + 7(h) = 2001<br/>RESULT = 2001 + 14(o) = 2015<br/>RESULT = 2015 * 8(8) = 16120<br/>RESULT = 16120 * 4(4) = 64480<br/>RESULT = 64480 * 7(7) = 451360<br/>RESULT = 451360 * 3(3) = 1354080<br/>RESULT = 1354080 * 8(8) = 10832640<br/>RESULT = 10832640 * 4(4) = 43330560<br/>RESULT = 43330560 * 8(8) = 346644480<br/>RESULT = 346644480 * 3(3) = 1039933440<br/>RESULT = 1039933440 * 9(9) = 9359400960<br/>RESULT = 9359400960 * 9(9) = 84234608640<br/>RESULT = 84234608640 % 9999( ) = 2943<br/>RESULT = 2943 % 9999(;) = 2943<br/>RESULT = 2943 % 9999(-) = 2943<br/>RESULT = 2943 % 9999()) = 2943|


