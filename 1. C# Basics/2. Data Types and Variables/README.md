# Homework: Data Types and Variables

# Tasks marked with * require additional knowledge or some research
==================================

# 01. Declare Variables

## Description
Declare five variables choosing for each of them the most appropriate of the types `byte, sbyte, short, ushort, int, uint, long, ulong` to represent the following values: `52130, -115, 4825932, 97, -10000`.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

## Submission
- You do not have to submit anything for this problem

---

# 02. Float or Double

## Description
Which of the following values can be assigned to a variable of type `float` and which to a variable of type `double`: `34.567839023, 12.345, 8923.1234857, 3456.091`?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.

## Submission
- You do not have to submit anything for this problem

---

# 03. Variable in Hexadecimal Format

## Description
Declare an integer variable and assign it with the value `254` in hexadecimal format (`0x###`).
Use Windows Calculator to find its hexadecimal representation.
Print the variable and ensure that the result is `254`.

## Submission
- You do not have to submit anything for this problem

---

# 04. Unicode Character

## Description
Declare a character variable and assign it with the symbol that has Unicode code `42` (decimal) using the `\u00XX` syntax, and then print it.

_Hint: first, use the Windows Calculator to find the hexadecimal representation of `42`. The output should be `*`._

## Submission
- You do not have to submit anything for this problem

---

# 05. Boolean Variable

## Description
Declare a Boolean variable called `isFemale` and assign an appropriate value corresponding to your gender.
Print it on the console.

## Submission
- You do not have to submit anything for this problem

---

# 06. Strings and Objects

## Description
Declare two string variables and assign them with `Hello` and `World`.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

## Submission
- You do not have to submit anything for this problem

---

# 07. Quotes in Strings

## Description
Write a program that outputs `The "use" of quotations causes difficulties.`

## Input
- None

## Output
- Print on a single line `The "use" of quotations causes difficulties.`

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/313#0)

---

# 08. Isosceles Triangle

## Description
Write a program that prints an isosceles triangle of 9 copyright symbols `©`, something like this:

```
   ©
   
  © ©
  
 ©   ©
 
© © © ©
```

_Note: The `©` symbol may be displayed incorrectly at the console so you may need to change the console character encoding to `UTF-8` and assign a Unicode-friendly font in the console._

_Note: Under old versions of Windows the `©` symbol may still be displayed incorrectly, regardless of how much effort you put to fix it._

## Submission
- You do not have to submit anything for this problem

---

# 09. Exchange Variable Values

## Description
Declare two integer variables `a` and `b` and assign them with `5` and `10` and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.

## Submission
- You do not have to submit anything for this problem

---

# 10. Employee Data

## Description
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
- First name
- Last name
- Age (0...100)
- Gender (m or f)
- Personal ID number (e.g. 8306112507)
- Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

## Submission
- You do not have to submit anything for this problem

---

# 11. Bank Account Data

## Description
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

## Submission
- You do not have to submit anything for this problem

---

# 12. Null Values Arithmetic

## Description
Create a program that assigns null values to an integer and to a double variable. 
- Try to print these variables at the console. 
- Try to add some number or the null literal to these variables and print the result.

## Submission
- You do not have to submit anything for this problem

---

# 13*. Comparing Floats

## Description
Write a program that safely compares two floating-point numbers (double) with precision `eps = 0.000001`.

_Note: Two floating-point numbers `a` and `b` cannot be compared directly by `a == b` because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant `eps`._

## Input
- On the first line you will receive the first floating-point number
- On the second line you will receive the second floating-point number

_Hint: Use double.Parse(Console.ReadLine()) to read input_

## Output
- Print `true` if the numbers are equal or `false` if they are not

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input                    | Output (with precision `eps=0.000001`) |                                       Explanation                                     |
|:------------------------:|:--------------------------------------:|:-------------------------------------------------------------------------------------:|
| 5.3<br>6.01              |    false                               | The difference of 0.71 is too big (> eps)                                             |
| 5.00000001<br>5.00000003 |    true                                | The difference `0.00000002 < eps`                                                     |
| 5.00000005<br>5.00000001 |    true                                | The difference `0.00000004 < eps`                                                     |
| -0.0000007<br>0.00000007 |    true                                | The difference `0.00000077 < eps`                                                     |
| -4.999999<br>-4.999998   |    false                               | Border case. The difference `0.000001 == eps`. We consider the numbers are different. |
| 4.999999<br>4.999998     |    false                               | Border case. The difference `0.000001 == eps`. We consider the numbers are different. |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/313#1)

---

# 14*. Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the visible characters of the ASCII table on the console (characters from `33` to `126` including).

_Note: You may need to use for-loops (learn in Internet how)._

## Input
- None

## Output
- The `94` characters on single line

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/313#2)

---

# 15*. Look like a hacker

## Preliminaries
If you haven't done the Command line task from the previous homework, go back and do it.

## Description
Hackers look cool, don't they? They do all kinds of dizzying confusing stuff on their computers that looks like magic. You can also look cool like a hacker, if you complete the task below. **Use only the terminal, unless the description says otherwise**.
- Open a terminal in a folder of your choice
- Make a directory named `im-cool` from the terminal
- Navigate the terminal into the new directory
- Create a file named `ImCool.cs`
- Enter `ImCool.cs` in the terminal
    - This should open the `ImCool.cs` file with the default program for `.cs` files(should be Visual Studio on Windows)
- Write some C# code in `ImCool.cs`
    - Declare a few variables, assign them some value, print them. For example:
    ```csharp
    using System;

    class ImCool
    {
        static void Main()
        {
            string amICool = "Absolutely";
            Console.WriteLine(amICool);
        }
    }
    ```
- Next, run the command `csc ImCool.cs`
    - `csc` is the command to use the C# compiler from the terminal
    - This command will probably not be successful the first time you run it and you will probably see this output
    ```
    'csc' is not recognized as an internal or external command,
    operable program or batch file.
    ```
    - You will need to find where the `csc.exe` is on your computer and copy the path to it's folder
    - Next, you will need to put this path in the **PATH** of you Windows(you're not required to do this in the terminal)
        - Research on the internet how to add something to the PATH of Windows, where to find the C# compiler executable(`csc.exe`)
    - **If you can't get it working after researching for a fair bit, have another student help you or write a question in our forums**
- After you've successfully ran the command `csc ImCool.cs`, list all files in the directory(using `dir` or `ls`)
    - You'll notice that a file named `ImCool.exe` has appeared - you have successfuly compiled a C# file from the terminal. Good job!
- To run the C# program you just compiled, run the command `ImCool.exe`
    - You will be able to see the output of your program in the terminal

## Submission
You do not have to submit anything for this problem.













