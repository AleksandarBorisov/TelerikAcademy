<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 3 February 2015 Evening_

# Task 2: Symbol to Number

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/205#1)

## Description   

You are given a number (SECRET) and a text. The text must be encoded using the SECRET.  
The encoding is done as follows:  
- If the character is “@”, stop the program  
- If the character in the text is a letter, multiply its char code by the given SECRET and add 1000.  
- If the character in the text is a digit, add to its char code SECRET and add 500  
- If the character in the text is not a digit, letter or “@” (any other symbol), subtract from its char code SECRET  
- After performing the above operations on the character in the original text:  
  - If the character is on even position in the text - divide the encoded value by 100 and round the precision to 2 digits after the decimal point  
  - Else if the character is on odd position in the original text – multiply its encoded value by 100  
  - The first character in the text is at position 0.  
 
Your task is to encode a text, using the rules above.  

## Input  

The input data is given at the standard input.   
On the first line you will find an integer number – the SECRET number  
On the next line, you will find the text, ending with “@”  
The input will be valid, in the specified format, within the constraints given below. There is no need to check the input data explicitly.  

## Output

Print the encoded text

## Constraints

•	**SECRET** will always be between **1 and 10**  
•	The count of the characters in the text will always be less than **10 000**  
•	Allowed working time for your program: 0.1 seconds.  
•	Allowed memory: 16 MB.  

## Example

|Input|Output|
|:-------------|:--------------|
|6<br/>Telerik Academy Rocks!@<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|15.04<br/>160600<br/>16.48<br/>160600<br/>16.84<br/>163000<br/>16.42<br/>2600<br/>13.90<br/>159400<br/>15.82<br/>160000<br/>16.06<br/>165400<br/>17.26<br/>2600<br/>14.92<br/>166600<br/>15.94<br/>164200<br/>16.90<br/>2700<br/>|
|**Input**|**Output**|
|10<br/>C#1 is pretty easy exam@<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|16.70<br/>2500<br/>5.59<br/>2200<br/>20.50<br/>215000<br/>0.22<br/>212000<br/>21.40<br/>201000<br/>21.60<br/>216000<br/>22.10<br/>2200<br/>20.10<br/>197000<br/>21.50<br/>221000<br/>0.22<br/>201000<br/>22.00<br/>197000<br/>20.90<br/>|


