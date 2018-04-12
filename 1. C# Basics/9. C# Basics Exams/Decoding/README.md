<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 3 February 2015 Morning_

# Task 2: Decoding

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/204#1)

## Description   

You are given a number (SALT) and a text. The text must be encoded using the SALT.  
The encoding is done as follows:  
  - If the character is “@”, stop the program  
  - If the character in the original text is a letter, multiply its char code by the given  SALT and add 1000.  
  - If the character in the original text is a digit, add to its char code SALT and add 500  
  - If the character in the original text is not a digit or letter (any other symbol), subtract from its char code SALT  
  - After performing the above operations on the character in the original text:  
      -	If the character is on even position in the original text - divide the encoded value by 100 and round the precision to 2 decimal digits right of the decimal point
      - Else if the character is on odd position in the original text - multiply by 100
      - The first character is at position 0. 

Your task is to encode a text, using the rules above the original text, by given the encoded values for each character.

## Input  

The input data is given at the standard input.  
On the first line you will find an integer number – the SALT number  
On the next line, you will find the text, ending with “@”  
The input will be valid, in the specified format, within the constraints given below. There is no need to check the input data explicitly.  

## Output

Print the encoded text

## Constraints

•	**SALT** will always be between **1 and 10**  
•	The count of the characters in the text will always be less than **10 000**  
•	Allowed working time for your program: 0.1 seconds.  
•	Allowed memory: 16 MB.


## Example

|Input|Output|
|:-------------|:--------------|
|9<br/>I love C#!@<br/><br/><br/><br/><br/><br/><br/><br/><br/>|16.57<br/>2300<br/>19.72<br/>199900<br/>20.62<br/>190900<br/>0.23<br/>160300<br/>0.26<br/>2400|
|**Input**|**Output**|
|10<br/>Starwars 4, 5 and 6 are better that<br/>Starwars 1, 2 and 3 :-)@<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|18.30<br/>216000<br/>19.70<br/>214000<br/>21.90<br/>197000<br/>21.40<br/>215000<br/>0.22<br/>56200<br/>0.34<br/>2200<br/>5.63<br/>2200<br/>19.70<br/>210000<br/>20.00<br/>2200<br/>5.64<br/>2200<br/>19.70<br/>214000<br/>20.10<br/>2200<br/>19.80<br/>201000<br/>21.60<br/>216000<br/>20.10<br/>214000<br/>0.22<br/>216000<br/>20.40<br/>197000<br/>21.60<br/>2200<br/>18.30<br/>216000<br/>19.70<br/>214000<br/>21.90<br/>197000<br/>21.40<br/>215000<br/>0.22<br/>55900<br/>0.34<br/>2200<br/>5.60<br/>2200<br/>19.70<br/>210000<br/>20.00<br/>2200<br/>5.61<br/>2200<br/>0.48<br/>3500<br/>0.31|


