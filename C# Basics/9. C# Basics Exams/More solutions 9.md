## Още няколко интересни варианта на задачите
### Arrow (моя първи опит за такъв тип задача)
```C#
int n = int.Parse(Console.ReadLine());
string firstPiece = "#";
string secondPiece = null;
string thirdPiece = "#";
string forthPiece = ".";
string fifthPeace = null;
string sixthPieace = null;
for (int i = 3 ; i <= n; i+=2)
{
    firstPiece = "#"+firstPiece+"#";
    secondPiece = secondPiece+".";
    thirdPiece += "#";
    if (i>3)
        {
            forthPiece += "....";
        }
}
Console.WriteLine(secondPiece+firstPiece+secondPiece);
for (int j = 3; j <= n; j++)
{
    Console.WriteLine(secondPiece+"#"+secondPiece+ secondPiece.Remove(secondPiece.Length-1) + "#" + secondPiece);
}
Console.WriteLine(thirdPiece+ secondPiece + secondPiece.Remove(secondPiece.Length - 1)+thirdPiece);
for (int i = 0; i < n-2; i++)
{
    fifthPeace = "#" + forthPiece + "#";
    sixthPieace += ".";
    Console.WriteLine(sixthPieace+fifthPeace+sixthPieace);
    if (forthPiece.Length>=3)
    {
        forthPiece = forthPiece.Remove(forthPiece.Length - 2);
    }
}
Console.WriteLine(sixthPieace+".#."+sixthPieace);
```
### Five Special Letters
```C#
public static void Main()
   {
       //Като мина методи да се върна на тази задача
       //Това решение предлагат в нета, но мисля че моето е по-добро
       long minWeight = long.Parse(Console.ReadLine());
       long maxWeight = long.Parse(Console.ReadLine());

       int resultsCount = 0;
       for (char c1 = 'a'; c1 <= 'e'; c1++)
       {
           for (char c2 = 'a'; c2 <= 'e'; c2++)
           {
               for (char c3 = 'a'; c3 <= 'e'; c3++)
               {
                   for (char c4 = 'a'; c4 <= 'e'; c4++)
                   {
                       for (char c5 = 'a'; c5 <= 'e'; c5++)
                       {
                           string word = "" + c1 + c2 + c3 + c4 + c5;
                           long weight = CalcWeight(word);
                           //Console.WriteLine(word + " " + weight);
                           if (weight >= minWeight && weight <= maxWeight)
                           {
                               if (resultsCount > 0)
                               {
                                   Console.Write(" ");
                               }
                               Console.Write(word);
                               resultsCount++;
                           }
                       }
                   }
               }
           }
       }

       if (resultsCount == 0)
       {
           Console.Write("No");
       }
   }

   static long CalcWeight(string word)
   {
       bool[] used = new bool[(int)'e' + 1];
       long weight = 0;
       int index = 1;
       for (int i = 0; i < word.Length; i++)
       {
           char letter = word[i];
           if (!used[letter])
           {
               weight += index * CalcWeight(letter);
               index++;
               used[letter] = true;//ASCII кода на буквата всъщност е индекс в масива used
           }
       }
       return weight;
   }

   static int CalcWeight(char letter)
   {
       switch (letter)
       {
           case 'a': return 5;
           case 'b': return -12;
           case 'c': return 47;
           case 'd': return 7;
           case 'e': return -32;
       }
       return 0;
   }
```