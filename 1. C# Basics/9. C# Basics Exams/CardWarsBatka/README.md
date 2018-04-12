<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2013-2014 / C# Fundamentals Exam - 24 June 2013 Evening_

# Task 3: Card Wars Batka!

## Submit your solution [here](http://bgcoder.com/Contests/Practice/Index/93#2)

## Description   

Pesho and Gosho are best friends and they love to play card games. They have played all the card games in the world and now they are bored. So they decided to ask their friend Stamat to invent a new, fun, card game for them. After many, many sleepless night, Stamat invented a new card game called **“Card Wars Batka!”**. So here are the rules of this new card game:  
A game **match** consists of **N games** and in each game **both players get 3 cards** and each card has different **point strength**. Here is a table with all the cards and their point strength:  

|Card|2|3|4|5|6|7|8|9|10|A|J|Q|K|
|:-|:-|:-|:-|:-|:-|:-|:-|:-|:-|:-|:-|:-|:-|
|**Points**|10|9|8|7|6|5|4|3|2|1|11|12|13|

The goal of each game is to **get a better hand strength** than the other player. The hands strength is made by the sum of the points of each card in the hand, so if we have **5**, **A** and **Q**, the hand strength is
**7 + 1 + 12 = 20**.  
At the end of each game we check which hand strength is bigger and we choose a winner. Then we **increase the player’s score with the amount of points his hand strength has**. So if player one has **20 points hand strength** and he wins the match – **he has 20 points player score** and if in his second game he has **hand strength of 35** and he wins the match, his **player score will be 20 + 35 = 55**.  
**Note**: The player score **can** be negative.  
**Only** the winning player gets the points form his hand strength to his player score. If both players have **equal hand strengths**, then **no one gets any points to their player scores** and the game does not count as “won” for either of them.  
But wait, there is more and more!  
Stamat added to the game **3 more special cards**! So here is a list of them and what they do:  
- The “Z” card – **doubles** the current player's score. The card can be drawn more than once in the same hand (2 times drawn → player score * 4; 3 times drawn → player score * 8).
- The “Y” card – **subtracts** 200 from the player's score. The card can be drawn more than once in the same hand (2 times drawn → player score -400; 3 times drawn → player score -600).
- The “X” card – **wins the whole game match, BUT** if both players draw the “X” card in the same game, they are **both awarded 50 points** to their player score (without any one of them winning the game). It doesn’t matter if the card is drawn 2 or 3 times in the same hand.  

At the end of each game match your program should print these **exact messages** on the console in these cases:

|Condition|Message|Comments|
|:-------------|:--------------|:-------------|
|If player one has drawn “X” card<br/><br/>|X card drawn! Player one wins the match!|The first player wins.<br/><br/><br/>|
|If player two has drawn the “X” card<br/><br/>|X card drawn! Player two wins the match!|The second player wins.<br/><br/><br/>|
|If player one has a bigger player score than player two|First player wins!<br/>Score: **S**<br/>Games won: **G**|**S** is the score of the first player. The games won by the first player is **G**.|
|If player two has a bigger player score than player one|Second player wins!<br/>Score: **S**<br/>Games won: **G**|**S** is the score of the second player. The games won by the second player is **G**.|
|If player score of the first and the second player are equal|It's a tie!<br/>Score: **S**<br/><br/>|Where **S** is the score of both players.<br/><br/>|

## Input  

The input data should be read from the console.  
At the first line you are given the number of games in a match (**N**). So if we are given 5, there will be 5 games in this match.  
At the next 3 lines we are given the 3 cards for the first player hand, and after that at the next 3 lines we are given the 3 cards for the second player hands. The 3 + 3 line model is repeated **N** times where **N** is the number of games.  
The input data will always be valid and in the format described. There is **no need** to check it explicitly.  

## Output

The output data should be printed on the console.  
AT the standard output your program should print an appropriate message with the **exact letters casing**.

## Constraints

- The number **N** is in the range [1…100] inclusive.
- Allowed working time for your program: **0.1** seconds.
- Allowed memory: **16 MB**.

## Examples

|Input|Output|Input|Output|Input|Output|Input|Output|
|:-------------|:--------------|:-------------|:--------------|:-------------|:--------------|:-------------|:--------------|
|2<br/>2<br/>2<br/>2<br/>A<br/>A<br/>5<br/>2<br/>K<br/>2<br/>5<br/>6<br/>A|First player wins!<br/><br/>Score: 63<br/><br/>Games won: 2<br/><br/><br/><br/><br/><br/>|1<br/>10<br/>10<br/>10<br/>K<br/>Q<br/>J<br/><br/><br/><br/><br/><br/><br/>|Second <br/>player wins!<br/><br/>Score: 36<br/><br/>Games won: 1<br/><br/><br/><br/><br/>|1<br/>K<br/>Q<br/>J<br/>10<br/>X<br/>10<br/><br/><br/><br/><br/><br/><br/>|X card drawn!<br/><br/>Player two wins the match!<br/><br/><br/><br/><br/><br/><br/><br/>|2<br/>A<br/>A<br/>A<br/>A<br/>A<br/>A<br/>A<br/>A<br/>A<br/>A<br/>A<br/>A|It's a tie!<br/><br/>Score: 0<br/><br/><br/><br/><br/><br/><br/><br/><br/>|












