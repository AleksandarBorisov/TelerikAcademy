#### _SoftUni C# Basics Exam - 12 April 2014 Evening_

# Task 2: Odd Even Elements

## Submit your solution [here](https://judge.softuni.bg/Contests/Practice/Index/7#1)

## Description   

You are given **N numbers**. Calculate the **sum**, **min** and **max** of its **odd elements** and **sum**, **min** and **max** of its **even elements**. Consider that the first element is odd, the second is even, etc.

## Input  

The input data should be read from the console. It will consists of exactly one line.  
- At the first line **N numbers** will be given, separated one from another by a single **space**.  

The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

You have to print the output in a single line at the console in the following format:  
- **OddSum=…, OddMin=…, OddMax=…, EvenSum=…, EvenMin=…, EvenMax=…**  
Print the numbers in the output without any unneeded trailing zeroes (i.e. print 1.5 instead of 1.50; 1 instead of 1.00). In case the sum, the minimal or the maximal element cannot be calculated (due to missing data), print "**No**".

## Constraints

- All numbers in the input will be in the range [-1 000 000 … 1 000 000], with no more than 10 digits (total, before and after the decimal point). The decimal separator in the non-integer numbers will be '.' and the numbers will have up to 2 digits after the decimal separator.
- The count N of the numbers in the input is in the range [0 … 1000].
- All numbers in the output should be formatted **without unneeded trailing zeroes**.
- Allowed work time for your program: **0.1** seconds.
- Allowed memory: **16 MB**.


## Examples

|Input|Output|
|:-------------|:--------------|
|2 3 5 4 2 1|OddSum=9, OddMin=2, OddMax=5, EvenSum=8, EvenMin=1, EvenMax=4|
|3 -2 8 11 -3|OddSum=8, OddMin=-3, OddMax=8, EvenSum=9, EvenMin=-2, EvenMax=11|
|1|OddSum=1, OddMin=1, OddMax=1, EvenSum=No, EvenMin=No, EvenMax=No|
|1.5 -2.5|OddSum=1.5, OddMin=1.5, OddMax=1.5, EvenSum=-2.5, EvenMin=-2.5, EvenMax=-2.5|
|1.5 1.75 1.5 1.75|OddSum=3, OddMin=1.5, OddMax=1.5, EvenSum=3.5, EvenMin=1.75, EvenMax=1.75|


