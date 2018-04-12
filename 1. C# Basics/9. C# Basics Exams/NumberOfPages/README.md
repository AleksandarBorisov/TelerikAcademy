<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2016-2017 / C# Fundamentals Exam - 25 April 2016_

# Task 3(Evening): Number of Pages

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/337#2)

## Description

A book has **N** pages, numbered **from 1 to N** (1, 2, 3, ... N - 1, N).

The total number of **digits** in the page numbers is **D**.

How many pages does the book have?

In other words: Write a program to find the number **N**.

## Input

- On the only input line, there will be the number - **D** - the number of digits used for numbering the book pages.
- The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

- On the only output line, write the number **N** (the number of the pages in the book)

## Constraints

- `1 < D < 1,000,000`
- It is guaranteed that the number of digits will be valid according to the number of pages.
- Allowed working time for your program: **0.1s**
- Allowed memory: **16MB**

## Sample tests

|  Input  |  Output  |
|---------|----------|
| 4       | 4        |
| 192     | 100      |
| 6853    | 1990     |
| 999999  | 185184   |

# Hints
- How can you read the input? What type of variable do you need?
- How can we find **N**?
    - If you have the number of a page, can you calcute how many digits that page has?
    - If you know how many digits there are in a page number, can you find the digits in the page numbers **[1, 2, 3, 4, ...]**?
    - Can you find out how many of those value fit into **D**?
        