## Още няколко интересни варианта на задачите
### Извеждане на знак на произведение на три числа без да го пресмятаме:
```C#
	Console.Write("Моля въведете първо число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете второ число: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете трето число: ");
        int c = int.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Произведението е нула");
        }
        else if (c > 0)
        {
            if (a > 0 ^ b > 0)
            {
                Console.WriteLine("Произведението е отрицателно число");
            }
            else
            {
                Console.WriteLine("Произведението е положително число");
            }
        }
        else if(c < 0)
        {
            if (a > 0 ^ b > 0)
            {
                Console.WriteLine("Произведението е положително число");
            }
            else
            {
                Console.WriteLine("Произведението е отрицателно число");
            }
        }
```
### Сортиране на три числа във възходящ ред:
```C#
	Console.Write("Моля въведете първо число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете второ число: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете трето число: ");
        int c = int.Parse(Console.ReadLine());
        if(a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        if(a > c)
        {
            a = a + c;
            c = a - c;
            a = a - c;
        }
        if(b > c)
        {
            b = b + c;
            c = b - c;
            b = b - c;
        }
        Console.WriteLine("Числата във възходящ ред са: {0} {1} {2}",a,b,c);
```
### Извеждане на името на цифра на български език:
```C#
	Console.Write("Моля въведете цифра: ");
        string number = Console.ReadLine();
        while(number.Length>1)
        {
            Console.Write("Моля въведете коректна цифра: ");
            number = Console.ReadLine();
        }
        int n;
        bool parseSuccess = Int32.TryParse(number, out n);
        while(!parseSuccess)
        {
            Console.Write("Моля въведете коректна цифра: ");
            parseSuccess = Int32.TryParse(Console.ReadLine(), out n);
        }
        switch (n)
        {
            case 0: Console.WriteLine("Цифрата е нула."); break;
            case 1: Console.WriteLine("Цифрата е едно."); break;
            case 2: Console.WriteLine("Цифрата е две."); break;
            case 3: Console.WriteLine("Цифрата е три."); break;
            case 4: Console.WriteLine("Цифрата е четири."); break;
            case 5: Console.WriteLine("Цифрата е пет."); break;
            case 6: Console.WriteLine("Цифрата е шест."); break;
            case 7: Console.WriteLine("Цифрата е седем."); break;
            case 8: Console.WriteLine("Цифрата е осем."); break;
            case 9: Console.WriteLine("Цифрата е девет."); break;
            default:Console.WriteLine("Въвели сте грешна цифра."); break;
        }
```
### Извеждане на най-голямото измежду n числа:
```C#
	Console.Write("Моля въведете колко числа ще проверявате: ");
        int n;
        int biggestNumber=0;
        bool parseSuccess = Int32.TryParse(Console.ReadLine(), out n);
        while(!parseSuccess)
        {
            Console.Write("Моля въведете коректна бройка: ");
            parseSuccess = Int32.TryParse(Console.ReadLine(), out n);
        }
        for (int i = 1 ; i <= n ; i++)
        {
            Console.Write("Въведете {0} число: ",i);
            int newNumber;
            bool parseSuccessN = Int32.TryParse(Console.ReadLine(), out newNumber);
            while(!parseSuccessN)
            {
                Console.Write("Моля въведете коректно число: ");
                parseSuccessN = Int32.TryParse(Console.ReadLine(), out newNumber);
            }
            if(biggestNumber<newNumber)
            {
                 biggestNumber = newNumber;
            }
        }
        Console.WriteLine("Най-голямото от {0}-те числа е: {1}", n,biggestNumber);
```
### Игра с int, double и стринг:
```C#
	Console.Write("Моля въведете тип данни: \n1-int\n2-double\n3-string\n");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.Write("Моля въведете число: ");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(k + 1);
                break;
            case 2:
                Console.Write("Моля въведете число: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case 3:
                Console.Write("Моля въведете string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str+"*");
                break;
            default:
                Console.WriteLine("Грешен вход!");
                break;
        }
```
### Дадени са 5 числа да се провери дали има група от тях на която сумата е 0:
```C#
	int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        int n4 = 0;
        int n5 = 0;
        bool noZero = true;
        Console.WriteLine("Моля въведете 5 цели числа: ");
        bool isValid = false;
        while(!isValid)
        {
            Console.Write("Моля въведете първо число: ");
            isValid = Int32.TryParse(Console.ReadLine(), out n1);
        }
        isValid = false;
        while (!isValid)
        {
            Console.Write("Моля въведете второ число: ");
            isValid = Int32.TryParse(Console.ReadLine(), out n2);
        }
        isValid = false;
        while (!isValid)
        {
            Console.Write("Моля въведете трето число: ");
            isValid = Int32.TryParse(Console.ReadLine(), out n3);
        }
        isValid = false;
        while (!isValid)
        {
            Console.Write("Моля въведете четвърто число: ");
            isValid = Int32.TryParse(Console.ReadLine(), out n4);
        }
        isValid = false;
        while (!isValid)
        {
            Console.Write("Моля въведете пето число: ");
            isValid = Int32.TryParse(Console.ReadLine(), out n5);
        }
        isValid = false;
        int k1 = 0;
        int k2 = 0;
        int k3 = 0;
        int k4 = 0;
        int k5 = 0;
        for (int counter = 1; counter < 32; counter++)
        {
            k1 = counter & 1;
            k2 = (counter & 3) >> 1;
            k3 = (counter & 5) >> 2;
            k4 = (counter & 9) >> 3;
            k5 = (counter & 17) >> 4;
            int sum = k1 * n1 + k2 * n2 + k3 * n3 + k4 * n4 + k5 * n5;
            if((sum == 0) && (counter != 1) && (counter != 2) && (counter != 4) && (counter != 8) && (counter != 16))
            {
                if (k1 != 0) Console.Write("{0} ", n1);
                if (k2 != 0) Console.Write("{0} ", n2);
                if (k3 != 0) Console.Write("{0} ", n3);
                if (k4 != 0) Console.Write("{0} ", n4);
                if (k5 != 0) Console.Write("{0} ", n5);
                Console.WriteLine();
                noZero = false;
            }
        }
        if (noZero == true)
        {
            Console.WriteLine("Няма нулево множество!");
        }
```
### Извеждане с думи на числата от 0 до 999:
```C#
	Console.Write("Моля въведете число: ");
        int n = int.Parse(Console.ReadLine()); 
        if(n/100!=0)
        {
            switch (n/100)
            {
                case 1: Console.Write("сто "); break;
                case 2: Console.Write("двеста "); break;
                case 3: Console.Write("триста "); break;
                case 4: Console.Write("четиристотин "); break;
                case 5: Console.Write("петстотин "); break;
                case 6: Console.Write("шестстотин "); break;
                case 7: Console.Write("седемстотин "); break;
                case 8: Console.Write("осемстотин "); break;
                case 9: Console.Write("деветстотин "); break;
            }
        }
        if((n % 100) / 10 >= 2)
        {
            if(((n % 100) % 10 == 0)&&(n/100!=0))
            {
                Console.Write("и ");
            }  
            switch ((n % 100) / 10)
            {
                case 2: Console.Write("двадесет"); break;
                case 3: Console.Write("тридесет"); break;
                case 4: Console.Write("четиридесет"); break;
                case 5: Console.Write("петдесет"); break;
                case 6: Console.Write("шестдесет"); break;
                case 7: Console.Write("седемдесет"); break;
                case 8: Console.Write("осемдесет"); break;
                case 9: Console.Write("деветдесет"); break;
            }
        }
        if ((n % 100) / 10 == 1)
        {
            if(n / 100 != 0)
            {
                Console.Write("и ");
            }
            switch ((n % 100) % 10)
            {
                case 0: Console.Write("десет"); break;
                case 1: Console.Write("единадесет"); break;
                case 2: Console.Write("дванадесет"); break;
                case 3: Console.Write("тринадесет"); break;
                case 4: Console.Write("четеринадесет"); break;
                case 5: Console.Write("петнадесет"); break;
                case 6: Console.Write("шестнадесет"); break;
                case 7: Console.Write("седемнадесет"); break;
                case 8: Console.Write("осемнадесет"); break;
                case 9: Console.Write("деветнадесет"); break;
            }
        }
        if(((n % 100) / 10>=2)||((n % 100) / 10==0))
        {
            if(((n / 100 != 0 ) && ( n % 10 !=0) ) || ((n / 100 == 0) && (n % 10 != 0)&&((n % 100) / 10 != 0)))
            {
                Console.Write(" и ");
            }
            switch (n % 10)
            {
                case 1: Console.Write("едно"); break;
                case 2: Console.Write("две"); break;
                case 3: Console.Write("три"); break;
                case 4: Console.Write("четири"); break;
                case 5: Console.Write("пет"); break;
                case 6: Console.Write("шест"); break;
                case 7: Console.Write("седем"); break;
                case 8: Console.Write("осем"); break;
                case 9: Console.Write("девет"); break;
            }
        }
        if (((n / 100) == 0) && ((n % 100) / 10 == 0)&&(n%10)==0)
        {
            Console.Write("нула");
        }
        Console.WriteLine(); 
```
### Вариант на сумата от 5 числа, върху който да поразсъждавам като напредна:
```C#
	using System;
	using System.Linq;

	//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

	class SumOfFiveNumbers
	{
	static void Main()
	{
	Console.Write("Please, write 5 numbers separated by a space: ");
	var numbers = Console.ReadLine().Split().Take(5);
	Double[] digits = numbers.Select(d => Convert.ToDouble(d)).ToArray();
	double sum = digits.Sum();
	Console.WriteLine("The sum is: " + sum);
	}
	}
```
### И още един:
```C#
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	namespace _07.Sumof5Numbers
	{
	class Sumof5numbers
	{
	static void Main(string[] args)
	{
	Console.WriteLine("Enter Numbers separete with space ");
	string numbers = Console.ReadLine();
	int numbersum = numbers.Split(' ').Sum(x => int.Parse(x));
	Console.WriteLine("The sum of numbers are = {0}",numbersum);
	}
	}
	}
Изпозва се .Split с разделител space и .sum, за да намерим x, който се декларира и преобразува в int.
```
### И още един:
```C#
using System.Linq;
	string consoleString = Console.ReadLine();
        string[] numbersLikeString = consoleString.Split(' ');
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(numbersLikeString[i]);
        }
        if (numbers.Sum() == 0)
        {
            Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0");
            return;
        }
        long sum = 0;
        string result = "";
        bool isZeroSubset = false;
        for (int combination = 1; combination < 32; combination++)
        {
            int bit = 0;
            for (int i = 0; i < 5; i++)
            {
                bit = (combination >> i) & 1;
                sum += numbers[i] * bit;
                if (bit == 1)
                {
                    result += (numbers[i] >= 0 ? " + " : " - ") + Math.Abs(numbers[i]);
                }
            }
            result = result.Trim('+', ' ');
            result += " = " + sum;
            if (sum == 0)
            {
                Console.WriteLine(result);
                isZeroSubset = true;
            }
            result = "";
            sum = 0;
        }
        if (isZeroSubset == false)
        {
            Console.WriteLine("no zero subset");
        }
```