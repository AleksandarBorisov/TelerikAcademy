﻿using System;

namespace PermutationsOfSet
{
    class Program
    {
        static void Main()
        {
            //int[] a = new int[] { 1,3,5};
            //int n = a.Length;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] p = new int[n + 1];//стойностите на този масив показват колко пъти трябва да се изпълни дадената размяна
            for (int k = 0; k < n; k++)//преди да се премине към следващата(това са един вид броячи и показател с коя позиция сменяме)
            {
                a[k] = int.Parse(Console.ReadLine());
                p[k] = k;
            }
            p[n] = n;
            int i = 1;//първите позиции за размяна да са 1 и 0
            int j = 0;
            Console.WriteLine(string.Join(" ", a));
            while (i < n)
            {
                p[i]--;
                if (i % 2 != 0)//ако i е нечетно j взима стойността която се съдържа на позиция i в помощния масив
                {//тъй като винаги в началото я намаляме с едно тя със сигурност ще бъде число по-малко от i
                    j = p[i];
                }//този if-else стейтмънт може да се представи и като j = i % 2 * p[i]
                else//ако i(или n във формулите) е четно винаги ще разменяме с първия елемент на индекс j = 0
                {//надолу е обяснено защо
                    j = 0;
                }//Алгоритъма е взет от тук http://www.quickperm.org/01example.php
                int temp = a[j];
                a[j] = a[i];
                a[i] = temp;
                i = 1;
                while (p[i] == 0)//възстановява стойностите на елементите на съответните позиции в помощния масив
                {//да бъдат равни на индексите си(началните им и съответно максимални стойности)
                    p[i] = i;//Винаги проверяваме дали първата позиция е 0
                    i++;//ако е 0 я връщаме до максималната и намеляме следващата вдясно
                }//ако пък е 1 я правим 0
                Console.WriteLine(string.Join(" ", a));
            }//Овновната идея на метода е следната: дръж n-тия елемент докато пренареждаш всички до n-1-вия, после
        }//смени n-тия елемент с един от другите и повтори
    }//ако разменяме четен брой елементи нечетен брой пъти, вземайки винаги първия елемент ни гарантира различна комбинация
}//ако обаче разменяме нечетен брой елементи четен брой пъти винаги ще завършваме с елементи в противоположен ред,
 //следователно ако взимаме винаги първия някой елементи няма да бъдат взети затова трябва да взимаме i+1 всеки път
 //ще се опитам да обобщя: 1 когато сме в извадка с четна дължина(2,4 т.н.) разменяме последователно всички елементи с 
 //последния като започваме от най-близкия до него и вървим наляво, така накрая получаваме шифтнати надясно с 1 елементи
 //2 когато сме в извадка с нечетна дължина (3,5 т.н.) винаги взимаме първия защото вътрешната пермутация на извадката с 
 //четна дължина ни гарантира че той ще бъде различен всеки път
 //В задачата условието очевидно е написано наобратно, в смисъл че ако i e нечетно се изпълнява условието за четна дължина
 // и обратно, това е така защото при четна дължина на елементите, индексите са нечетни (дължина 2, краен индекс 1,
 //дължина 4, краен индекс 3), т. е. на мястото на четната дължина отговаря нечетен индекс.