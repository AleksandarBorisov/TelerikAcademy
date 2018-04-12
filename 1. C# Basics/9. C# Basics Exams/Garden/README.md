<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2013-2014 / C# Fundamentals Exam - 24 June 2013 Evening_

# Task 1: Garden

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/93#0)

## Description   

Uncle Pesho needs help to calculate his garden production. He grows different vegetable plants. You are assigned to write a program to help him with the production calculations.   
Uncle Pesho wants to plant the following vegetables: **tomato**, **cucumber**, **potato**, **carrot**, **cabbage**, **beans**.   
For each vegetable, **except the beans**, uncle Pesho knows:  
- **how many seeds** he wants to plant 
- **on what area** he wants to plant those seeds  

**For the beans**, uncle Pesho has decided:
- **how many seeds** he wants to plant
- the **area for the bean**s will be **the area remaining after** planting the other vegetables

The **total area** uncle Pesho has is **250 square meters**.  
Of course, everything in life has a price – including seeds. Below you will find a table with prices per seed for each vegetable  
Write a program to **calculate the total cost of all the seeds** Pesho needs to buy and the **total area remaining for the beans**.
### Seeds Costs

|tomato|0.5$ per seed||carrot|0.6$ per seed|
|:-------------|:--------------|:--------------|:--------------|:--------------|
|**cucumber**|**0.4$ per seed**||**cabbage**|**0.3$ per seed**|
|**potato**|**0.25$ per seed**||**beans**|**0.4$ per seed**|



## Input  

The input data consists of 11 lines describing all the vegetables. Each line will hold a single number:  
- The first line holds the tomato seeds amount, the second – the tomato area.
- The third line holds the cucumber seeds amount, the fourth line – cucumber area. 
- The fifth line holds the potato seeds amount, sixth line – potato area.
- The seventh line holds the carrot seeds amount, eighth line – carrot area.
- The ninth line holds the cabbage seeds amount, tenth line – cabbage area. 
- The eleventh line holds the beans seeds amount.

The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed at the console in two lines:  
- At the first line print the total seeds cost, rounded to second digit after the decimal separator, in format “**Total costs: X.XX**” where **X.XX** are the costs.
- At the second line print the remaining area for beans.
   - In case there is some area for beans left, print its **size** in format “**Beans area: X**” where **X** is the area left for beans.
   - In case of no area for beans is left, print „**No area for beans**“.
   - In case the area for the tomato, cucumber, potato, carrot and cabbage is insufficient, print “**Insufficient area**”.

## Constraints

- The seeds amount is non-negative integer number in the range [0…1000].
- The plants area is non-negative integer number in the range [0…250].
- All numbers should use as a decimal separator the symbol “**.**” (point, no comma).
- Allowed work time for your program: **0.1** seconds.
- Allowed memory: **4 MB**.


## Examples

|Input|Output|Input|Output|Input|Output|
|:-------------|:--------------|:-------------|:--------------|:-------------|:--------------|
|10<br/>20<br/>25<br/>30<br/>42<br/>38<br/>15<br/>23<br/>18<br/>36<br/>70|Total costs: 67.90<br/>Beans area: 103<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|30<br/>39<br/>50<br/>60<br/>15<br/>77<br/>18<br/>36<br/>28<br/>39<br/>65|Total costs: 83.95<br/>Insufficient area<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|0<br/>0<br/>50<br/>0<br/>0<br/>100<br/>200<br/>50<br/>30<br/>100<br/>65|Total costs: 175.00<br/>No area for beans<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>|






