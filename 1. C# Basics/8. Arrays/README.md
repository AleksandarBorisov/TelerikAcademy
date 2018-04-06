# Homework: Arrays
# Tasks marked with * require additional knowledge or some research
================

# 01. Allocate array

## Description
Write a program that allocates array of **N** integers, initializes each element by its index multiplied by `5` and the prints the obtained array on the console.

## Input
- On the only line you will receive the number **N**

## Output
- Print the obtained array on the console.
  - Each number should be on a new line

## Constraints
- 1 <= **N** <= 20
- **N** will always be a valid integer number
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 5     | 0<br>5<br>10<br>15<br>20 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#0)

---

# 02. Compare arrays

## Description
Write a program that reads two `integer` arrays of size **N** from the console and compares them element by element.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the first array will be given
- On the next **N** lines the numbers of the second array will be given

## Output
- Print `Equal` if the two arrays are the same and `Not equal` if they are not

## Constraints
- 1 <= **N** <= 20
- **N** will always be a valid integer number
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 3<br>**1<br>2<br>3<br>1<br>2<br>3** | Equal |
| 3<br>**1<br>1<br>1<br>2<br>2<br>2** | Not equal |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#1)

---

# 03. Compare char arrays
Write a program that compares two `char` arrays lexicographically (letter by letter).

## Input
- On the first line you will receive the first `char` array as a string
- On the second line you will receive the second `char` array as a string

## Output
- Print `<` if the first array is lexicographically smaller
- Print `>` if the second array is lexicographically smaller
- Print `=` if the arrays are equal

## Constraints
- 1 <= **size of arrays** <= 128
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| hello<br>halo | > |
| food<br>food | = |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#2)

---

# 04. Maximal sequence

## Description
Write a program that finds the length of the **maximal sequence** of equal elements in an array of **N** integers.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the length of the **maximal sequence**

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input                                                    | Output |
|:--------------------------------------------------------:|:------:|
| 10<br>2<br>1<br>1<br>2<br>3<br>3<br>**2<br>2<br>2**<br>1 | 3      |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#3)

---

# 05. Maximal increasing sequence

## Description
Write a program that finds the length of the **maximal increasing sequence** in an array of **N** integers.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the length of the **maximal increasing sequence**

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input                                         | Output |
|:---------------------------------------------:|:------:|
| 8<br>7<br>3<br>**2<br>3<br>4**<br>2<br>2<br>4 | 3      |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#4)

---

# 06. Maximal K sum

## Description
Write a program that reads two integer numbers **N** and **K** and an array of **N** elements from the console.
Find the maximal sum of **K** elements in the array.

## Input
- On the first line you will receive the number **N**
- On the second line you will receive the number **K**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the maximal sum of **K** elements in the array

## Constraints
- 1 <= **N** <= 1024
- 1 <= **K** <= **N**
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input                                                       | Output |
|:-----------------------------------------------------------:|:------:|
| 8<br>3<br>3<br>2<br>3<br>-2<br>**5**<br>**4**<br>2<br>**7** | 16     |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#5)

---

# 07. Selection sort

## Description
**Sorting** an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the [Selection sort](http://en.wikipedia.org/wiki/Selection_sort) algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the sorted array
  - Each number should be on a new line

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 6<br>**3<br>4<br>1<br>5<br>2<br>6** | 1<br>2<br>3<br>4<br>5<br>6 |
| 10<br>**36<br>10<br>1<br>34<br>28<br>38<br>31<br>27<br>30<br>20** | 1<br>10<br>20<br>27<br>28<br>30<br>31<br>34<br>36<br>38 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#6)

---

# 08. Maximal sum

## Description
Write a program that finds the maximal sum of consecutive elements in a given array of **N** numbers.

- _Can you do it with only one loop (with single scan through the elements of the array)?_

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the maximal sum of consecutive numbers

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 10<br>2<br>3<br>-6<br>-1<br>**2<br>-1<br>6<br>4**<br>-8<br>8 | 11 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#7)

---

# 09. Frequent number

## Description
Write a program that finds the most frequent number in an array of **N** elements.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the most frequent number and how many time it is repeated
  - Output should be `REPEATING_NUMBER (REPEATED_TIMES times)`

## Constraints
- 1 <= **N** <= 1024
- 0 <= **each number in the array** <= 10000
- There will be only one most frequent number
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 13<br>**4**<br>1<br>1<br>**4**<br>2<br>3<br>**4**<br>**4**<br>1<br>2<br>**4**<br>9<br>3 | 4 (5 times) |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#8)

---

# 10. Find sum in array

## Description
Write a program that finds in given array of integers a sequence of given sum `S` (if present).

## Sample tests

|        array            |  S |  result |
|-------------------------|----|---------|
| 4, 3, 1, **4, 2, 5**, 8 | 11 | 4, 2, 5 |

## Submission
- You do not have to submit anything for this problem

---

# 11. Binary search

## Description
Write a program that finds the index of given element **X** in a sorted array of **N** integers by using the [Binary search](https://en.wikipedia.org/wiki/Binary_search_algorithm) algorithm.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given
- On the last line you will receive the number **X**

## Output
- Print the index where **X** is in the array
  - If there is more than one occurence print the first one
  - If there are no occurences print `-1`

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 10<br>**1<br>2<br>4<br>8<br>16<br>31<br>32<br>64<br>77<br>99**<br>32 | 6 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#9)

---

# 12. Index of letters

## Description
Write a program that creates an array containing all letters from the alphabet (`a-z`).
Read a word from the console and print the index of each of its letters in the array.

## Input
- On the first line you will receive the word

## Output
- Print the index of each of the word's letters in the array
  - Each index should be on a new line

## Constraints
- 1 <= **word length** <= 128
- Word is consisted of **lowercase english letters**
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input          | Output |
|:--------------:|:------:|
| telerikacademy | 19<br>4<br>11<br>4<br>17<br>8<br>10<br>0<br>2<br>0<br>3<br>4<br>12<br>24 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#10)

---

# 13**. Merge sort

## Description
Write a program that sorts an array of integers using the [Merge sort](http://en.wikipedia.org/wiki/Merge_sort) algorithm.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the sorted array
  - Each number should be on a new line

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 6<br>**3<br>4<br>1<br>5<br>2<br>6** | 1<br>2<br>3<br>4<br>5<br>6 |
| 10<br>**36<br>10<br>1<br>34<br>28<br>38<br>31<br>27<br>30<br>20** | 1<br>10<br>20<br>27<br>28<br>30<br>31<br>34<br>36<br>38 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#11)

---

# 14**. Quick sort

## Description
Write a program that sorts an array of integers using the [Quick sort](http://en.wikipedia.org/wiki/Quicksort) algorithm.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the sorted array
  - Each number should be on a new line

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 6<br>**3<br>4<br>1<br>5<br>2<br>6** | 1<br>2<br>3<br>4<br>5<br>6 |
| 10<br>**36<br>10<br>1<br>34<br>28<br>38<br>31<br>27<br>30<br>20** | 1<br>10<br>20<br>27<br>28<br>30<br>31<br>34<br>36<br>38 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#12)

---

# 15. Prime numbers

## Description
Write a program that finds all prime numbers in the range [`1 ... N`]. Use the [Sieve of Eratosthenes](http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes) algorithm. The program should print the biggest prime number which is `<= N`.

## Input
- On the first line you will receive the number **N**

## Output
- Print the biggest prime number which is `<= N`

## Constraints
- 2 <= **N** <= 10 000 000
- Time limit: **0.3s**
- Memory limit: **64MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 13    | 13     |
| 126   | 113    |
| 26    | 23     |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#13)

---

# 16**. Subset with sum S

## Description
We are given an array of integers and a number `S`.
Write a program to find if there exists a subset of the elements of the array that has a sum `S`.

## Sample tests

|       input array                      | S  |     result    |
|:--------------------------------------:|:--:|:-------------:|
| 2, **1**, **2**, 4, 3, **5**, 2, **6** | 14 | yes           |

## Submission
- You do not have to submit anything for this problem

---

# 17**. Subset K with sum S

## Description
Write a program that reads three integer numbers `N`, `K` and `S` and an array of `N` elements from the console.
- Find in the array a subset of `K` elements that have sum `S` or indicate about its absence.

## Submission
- You do not have to submit anything for this problem

---

# 18*. Remove elements from array

## Description
Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
Print the minimal number of elements that need to be removed in order for the array to become sorted.

## Input
- On the first line you will receive the number **N**
- On the next **N** lines the numbers of the array will be given

## Output
- Print the minimal number of elements that need to be removed

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 8<br>**1<br>4<br>3<br>3<br>6<br>3<br>2<br>3** | 3 |
| 10<br>**14<br>2<br>9<br>8<br>3<br>13<br>17<br>19<br>30<br>1** | 4 |

## Submission
#### Submit your code [here](http://bgcoder.com/Contests/Practice/Index/315#14)

---

# 19**. Permutations of set

## Description
Write a program that reads a number `N` and generates and prints all the permutations of the numbers [`1 … N`].

## Sample tests

| N |                                  result                                 |
|:-:|:-----------------------------------------------------------------------:|
| 3 | `{1, 2, 3}` <br> `{1, 3, 2}` <br> `{2, 1, 3}` <br> `{2, 3, 1}` <br> `{3, 1, 2}` <br> `{3, 2, 1}` |

## Submission
- You do not have to submit anything for this problem

---

# 20**. Variations of set

## Description
Write a program that reads two numbers `N` and `K` and generates all the variations of `K` elements from the set [`1..N`].

## Sample tests

| N | K |                                      result                                      |
|:-:|:-:|:--------------------------------------------------------------------------------:|
| 3 | 2 | `{1, 1}` <br> `{1, 2}` <br> `{1, 3}` <br> `{2, 1}` <br> `{2, 2}` <br> `{2, 3}` <br> `{3, 1}` <br> `{3, 2}` <br> `{3, 3}` |

## Submission
- You do not have to submit anything for this problem

---

# 21**. Combinations of set

## Description
Write a program that reads two numbers `N` and `K` and generates all the combinations of `K` distinct elements from the set [`1..N`].

## Sample tests

| N | K |                                          result                                           |
|:-:|:-:|:-----------------------------------------------------------------------------------------:|
| 5 | 2 | `{1, 2}` <br> `{1, 3}` <br> `{1, 4}` <br> `{1, 5}` <br> `{2, 3}` <br> `{2, 4}` <br> `{2, 5}` <br> `{3, 4}` <br> `{3, 5}` <br> `{4, 5}` |

## Submission
- You do not have to submit anything for this problem

---

# 22*. Command line arguments

## Description
For this task, use only the command line and a text editor. 
Create a folder(name it however you want), navigate into it and create a `CLI.cs` file. 
Open the `CLI.cs` file from the command line with whatever text editor you're comfortable with. 
Write a program that, when compiled to an executable, is run from the command line. Also, you should pass parameters(numbers) to it. 
Your executable should be called like that:

```bash
./CLI.exe 1 20 33 45 66 17
```

All parameters passed to your executable should be parsed to integers and summed. Print the sum on the console.

| Call                | Output       |
|:--------------------|:-------------|
| ./CLI.exe 1 2 3 4 5 | 15           |
| ./CLI.exe 10 10     | 20           |
| ./CLI.exe 7 8 13 33 | 61           |

## Submission
You do not have to submit anything for this task.





























