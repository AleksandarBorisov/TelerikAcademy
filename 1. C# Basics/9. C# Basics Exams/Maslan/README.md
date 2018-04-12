<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2015-2016 / C# Fundamentals Exam - 2 February 2015 Evening_

# Task 3: Maslan

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/203#2)

## Description   

In the magical land of Telenarnia there was an eponymous lion, named Maslan, son of Emperor-Over-the-Academy. He is a wise, compassionate, magical authority who serves as mysterious and benevolent guide to human children who visit Telenarnia. In order to prove they are worthy, all kids have to pass a magical test. Maslan makes a mathematical trick with transforming numbers and the children have to simulate it on a computer program. Maslan is a lion with good and fair intentions but he is very strict.   
The steps for performing the mathematical transformation follow:  
1.	Maslan gets a random positive **number** out of nowhere  
2.	Maslan **removes the last digit** (the rightmost one) from the **number**  
3.	Maslan then finds **all digits at odd positions** (starting from zero) and finds their **sum**  
4.	Maslan **returns again to the step 2** and **continues until no digits are left**  
5.	Maslan then finds the **product of all sums** found from the current **number**  
6.	If some of the **sums equals zero**, it is **ignored**. If there are **no sums** to calculate, the **product equals 1**.  
7.	Maslan then takes the **product** as **a new number** and in this way one **transformation** occurred  
8.	If the new **number** has **only one digit**, Maslan **stops** the magic trick and tells the kids **how many transformations occurred in total** and what is the **final resulted number**  
9.	Else if this is **not the 10th transformation** in turn, Maslan gets the **new number** and **starts again with it** from **step 2**  
10.	If this is **the 10th transformation** in turn, Maslan **stops the magic trick** and tells the kids the **final resulted number**
  
Example:  
1.	Maslan gets number **123456** out of nowhere  
2.	Maslan removes the last digit – **12345** and calculates the sum of all digits at odd positions – 2 + 4 = **6**  
3.	Maslan removes the last digit – **1234** and calculates the sum of all digits at odd positions – 2 + 4 = **6**  
4.	Maslan removes the last digit – **123** and calculates the sum of all digits at odd positions – **2**  
5.	Maslan removes the last digit – **12** and calculates the sum of all digits at odd positions – **2**  
6.	Maslan removes the last digit – **1** and calculates the sum of all digits at odd positions – **0**, **ignored in the calculations**  
7.	Maslan removes the last digit – no digits left – get the product of all sums found – 6 * 6 * 2 * 2 = **144**  
8.	One transformation occurred and the number **144** has more than 1 digit – start again from step 2  
9.	Maslan removes the last digit – **14** and calculates the sum of all digits at odd positions – **4**  
10.	Maslan removes the last digit – **1** and calculates the sum of all digits at odd positions – **0**, **ignored in the calculations**  
11.	Maslan removes the last digit – no digits left – get the product of all sums found – **4**  
12.	Second transformation occurred and the number **4** has only one digit – the magic trick stops  
13.	Final result – **2** transformations and the resulted number is **4**  

Your task is to make a program that simulates the magic transformation.

## Input  

The input data should be read from the console.  
On the only input line you will receive the initial number.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed on the console.  
If there were less than 10 transformations – print the number of transformations on the first line and the resulted number on the second line of the output.  
If there were 10 transformations and the magic trick stopped – print only the resulted number on the first line of the output.

## Constraints

- The number from the public will be between **100,000** and **99,999,999,999,999,999**
- Allowed working time for your program: **0.1** seconds.
- Allowed memory: **16 MB**.


## Example

|Example input|Example output|
|:-------------|:--------------|
123456<br/><br/>|2<br/>4|
|5353824709134486|1368900|


