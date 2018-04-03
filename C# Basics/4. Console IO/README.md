# Homework: Console IO

# Tasks marked with * require additional knowledge or some research
====================

# 01. Sum of 3 numbers

## Description
Write a program that reads 3 real numbers from the console and prints their sum.

## Input
- On the first line, you will receive the number **a**
- On the second line, you will receive the number **b**
- On the third line, you will receive the number **c**

## Output
Your output should consist only of a single line - the sum of the three numbers.

## Constraints
- **a**, **b** and **c** will always be valid real numbers between -1000 and 1000, inclusive
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|           Input      |     Output       |
|----------------------|:----------------:|
| 1<br/>2<br/>3        | 6                |
| -2<br/>0<br/>3       | 1                |
| 5.5<br/>4.5<br/>20.1 | 30.1             |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#0)

---

# 02. Company info

## Description
*	A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
*	Write a program that reads the information about a company and its manager and prints it back on the console.

|       info          |            input           |
|---------------------|----------------------------|
| Company name:       | Telerik Academy            |
| Company address:    | 31 Al. Malinov, Sofia      |
| Phone number:       | +359 888 55 55 555         |
| Fax number:         |                            |
| Web site:           | http://telerikacademy.com/ |
| Manager first name: | Nikolay                    |
| Manager last name:  | Kostov                     |
| Manager age:        | 25                         |
| Manager phone:      | +359 2 981 981             |

## Input
- You will each piece of information about the company on a separate line, in the same order as in the example
  1. Company name
  1. Company address
  1. Phone number
  1. Fax number
  1. Web site
  1. Manager first name
  1. Manager last name
  1. Manager age
  1. Manager phone

## Output
- Print the information the same way as shown in the sample test. Make sure that you print "(no fax)" if an empty line is passed as fax number.

## Constraints
- The input will always be in the described format
- Only the fax number field can be empty, all other fields will be least one symbol
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|            Input           |Output|
|----------------------------|------|
| Telerik Academy<br />231 Al. Malinov, Sofia<br />+359 888 55 55 555<br /><br />http://telerikacademy.com/<br />Nikolay<br />Kostov<br />25<br />+359 2 981 981 | Telerik Academy<br />Address: 231 Al. Malinov, Sofia<br />Tel. +359 888 55 55 555<br />Fax: (no fax)<br />Web site: http://telerikacademy.com/<br />Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981) |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#1)

---

# 03. Circle

## Description
Write a program that reads from the console the radius **r** of a circle and prints its **perimeter** and **area**, rounded and formatted with **2 digits** *after* the decimal point.
## Input
- On the only line of the input you will receive the radius of the circle - **r**

## Output
- You should print one line only: the **perimeter** and the **area** of the circle, **separated** by a whitespace, and with **2 digits** precision

## Constraints
- The radius **r** will always be a valid and positive real number
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|        Input        |        Output      |
|:-------------------:|:------------------:|
| 2                   | 12.57 12.57        |
| 3.5                 | 21.99 38.48        |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#2)

---

# 04. Formatting Numbers

## Description
- Write a program that reads 3 numbers:
	- integer **a** (0 <= a <= 500)
	- floating-point **b**
	- floating-point **c** 
- The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.	
	- The number **a** should be printed in hexadecimal, left aligned
	- Then the number **a** should be printed in binary form, padded with zeroes
	- The number **b** should be printed with 2 digits after the decimal point, right aligned
	- The number c should be printed with 3 digits after the decimal point, left aligned. 

_Examples:_

|  a  |    b    |    c    |                      result                    |
|:---:|:-------:|:-------:|------------------------------------------------|
| 254 | 11.6    | 0.5     | `FE        |0011111110|     11.60|0.500     |` |
| 499 | -0.5559 | 10000   | `1F3       |0111110011|     -0.56|10000.000 |` |
| 0   | 3       | -0.1234 | `0         |0000000000|      3.00|-0.123    |` |

## Submission
- You do not have to submit anything for this problem

---

# 05. Number Comparer

## Description
Write a program that gets two numbers from the console and prints the greater of them.

## Input
- On the first two lines you will receive the two numbers, **A** and **B**

## Output
- On the only line print the larger of the two numbers
  - *Try implementing it without using if-statements
  
## Constraints
- The input will always be valid and in the described format.
- The numbers **A** and **B** will always be valid real number
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|    Input     |  Output  |
|:------------:|:--------:|
| 5<br />6     | 6        |
| 10<br />5    | 10       |
| 0<br />0     | 0        |
| -5<br />-2   | -2       |
| 1.5<br />1.6 | 1.6      |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#3)

---

# 06. Quadratic Equation

## Description
Write a program that reads the coefficients **a**, **b** and **c** of a quadratic equation *ax<sup>2</sup> + bx + c = 0* and solves it (prints its real roots).

## Input
- On the first three lines, you will receive the coefficients **a**, **b**, and **c**, each on a separate line in the same order

## Output
- If two different real roots exist, print them on two separate lines
  - Print the smaller root on the first line
- If only one real root exists, print it on the only output line
- If no real root exists, print the string "no real roots"
- **The roots, should they exist, must be printed with precision _exactly_ two digits after the floating point**

## Constraints
- The input will always consist of valid real numbers in the range [-1000, 1000] and will follow the described format
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|     Input        |     Output     |
|:----------------:|:--------------:|
| 2<br/>5<br/>-3   | -3.00<br/>0.50  |
| -1<br/>3<br/>0   | 0.00<br/>3.00   |
| -0.5<br/>4<br/>-8| 4.00            |
| 5<br/>2<br/>8    | no real roots   |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#4)

---

# 07. Sum of 5 numbers

## Description
Write a program that reads 5 integer numbers from the console and prints their sum.

## Input
You will receive 5 numbers on five separate lines.

## Output
Your output should consist only of a single line - the sum of the 5 numbers.

## Constraints
- All 5 numbers will always be valid integer numbers between **-1000** and **1000**, inclusive
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|               Input              |     Output        |
|----------------------------------|:-----------------:|
| 1<br/>2<br/>3<br/>4<br/>5        | 15                |
| -1<br/>2<br/>-3<br/>4<br/>10     | 12                |
| 0<br/>0<br/>0<br/>0<br/>0        | 0                 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#5)

---

# 08. Numbers from 1 to N

## Description
Write a program that reads an integer number **N** from the console and prints all the numbers in the interval `[1, n]`, each on a single line.

## Input
- On the only line you will receive the number **N**

## Output
- You should print the numbers from **1** to **N**, each on a separate line

## Constraints
- 1 <= **N** < 1000
- **N** will always be a valid integer number
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input |           Output          |
|-------|:-------------------------:|
| 3     | 1<br/>2<br/>3             |
| 5     | 1<br/>2<br/>3<br/>4<br/>5 |
| 1     | 1                         |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#6)

---

# 09. Sum of N Numbers

## Description
Write a program that enters a number **N** and after that enters more **N** numbers and calculates and prints their sum.
  -  _Note: You may need to use a for-loop._

## Input
- On the first line, you will receive the number **N**
- On each of the next **N** lines, you will receive a floating-point number

## Output
- On must output only one number - the sum of the **N** numbers

## Constraints
- 1 <= **N** <= 200
- All numbers will be valid floating-point numbers in the range `[-1000, 1000]`
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|               Input              |     Output     |
|:--------------------------------:|:--------------:|
| 3<br/>20<br/>60<br/>10           | 90             |
| 5 <br/>2 <br/>-1 <br/>-0.5<br/>4<br/>2 | 6.5            |
| 1 <br/>1                         | 1              |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#7)

---

# 10. Fibonacci Numbers

## Description
Write a program that reads a number **N** and prints
 on the console the first **N** members of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : `0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …`.
 
## Input
- On the only line you will receive the number **N**

## Output
- On the only line you should print the first **N** numbers of the sequence, separated by ", " (comma and space)

## Constraints
- 1 <= **N** <= 50 
- **N** will always be a valid positive integer number
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|     Input      |               Output             |
|:--------------:|:--------------------------------:|
| 1              | 0                                |
| 3              | 0, 1, 1                          |
| 10             | 0, 1, 1, 2, 3, 5, 8, 13, 21, 34  |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#8)

---

# 11*. Interval

## Description
Write a program that reads two positive integer numbers **N** and **M** and prints how many numbers exist between them such that the reminder of the division by **5** is **0**.

## Input
- On the first two lines you will receive two integers - **N** on the first and **M** on the second.

## Output
- Output a single value - the amount of numbers divisible by **5** without remainder.

## Constraints
- 0 <= **N** <= **M** <= 2000
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|     Input       |      Output     |   Explanation   |
|-----------------|-----------------|-----------------|
| 6<br>11         | 1               | 10              |
| 20<br>37        | 3               | 25, 30, 35      |
| 2<br>2          | 0               | think why       |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/311#9)

---

## ***Additional Task (Play with it a little bit.) Falling Rocks

## [C# Console Games](https://github.com/NikolayIT/CSharpConsoleGames)

## Description
- Implement the "Falling Rocks" game in the text console.
	- A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).	
	- A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.	
	- Rocks are the symbols `^, @, *, &, +, %, $, ##, !, ., ;, -` distributed with appropriate density. The dwarf is `(O)`.
- Ensure a constant game speed by `Thread.Sleep(150)`.
- Implement collision detection and scoring system.

![console-falling-rocks](https://cloud.githubusercontent.com/assets/3106986/5611219/7126b0b6-94cc-11e4-8610-28ffa78d0cf7.png)

## Submission
- You do not have to submit anything for this problem











