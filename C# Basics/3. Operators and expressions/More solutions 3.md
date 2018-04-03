## Още няколко интересни варианта на задачите
### Проверка четно и нечетно:
```C#
	Console.Write("Моля въведете число: ");
        int n = int.Parse(Console.ReadLine());
        n = n % 2;
        Console.WriteLine(n == 0 ? "Числото е четно" : "Числото е нечетно");
```
### Проверка без остатък при делене на 5  7:
```C#
        Console.Write("Моля въведете число: ");
        int number = int.Parse(Console.ReadLine());
        int remainderFive = number % 5;
        int remainderSeven = number % 7;
        Console.WriteLine(remainderFive == 0 && remainderSeven == 0 ? "Числото се дели без остатък" : "Числото НЕ се дели без остатък");
```
### Проверка дали третата цифра е 7:
```C#
	Console.Write("Моля въведете число: ");
        int number = int.Parse(Console.ReadLine());
        number = number / 100;
        number = number % 10;
        Console.WriteLine(number==7?"Третата цифра е 7.":"Третата цифра НЕ е 7.");
```
### Проверка дали третия бит е 0 или 1:
```C#
	Console.Write("Моля въведете число: ");
        int number = int.Parse(Console.ReadLine());
        int bit = number & 4;
        Console.WriteLine(bit!=0 ? "Третият бит е 1." : "Третият бит е 0.");
```
### Тегло на земята и на луната:
```C#
	Console.Write("Моля въведете тегло: ");
        int kg = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Теглото на човек на луната ще бъде: "+0.17*kg);
```
### Дали точка влиза в окръжност:
```C#
	Console.Write("Моля въведете х координата за точка О: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Моля въведете y координата за точка О: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int c;
        c = (x * x) + (y * y);
        Console.WriteLine(c<= 25 ? "Точка О е в окръжността." : "Точка О е вън от окръжността.");
```
### Дали точка влиза в окръжност и е извън правоъгълник:
```C#
	Console.Write("Моля въведете х координата за точка О: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Моля въведете y координата за точка О: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int isInCircle;
        isInCircle = (x * x) + (y * y);
        bool isInRectangle = (x >= -1) && (y >= 1);
        bool proverka = (isInCircle <= 25) && (!isInRectangle);
        Console.WriteLine(proverka ? "Точка О е в окръжността и извън правоъгълника." : "Точка О не отговаря на условията.");
```
### Разделяне число на цифри, ограничаването им и боравенето с тях:
```C#
	Console.Write("Моля въведете число: ");
	var number = int.Parse(Console.ReadLine());
	while (number.ToString().Length>4||number.ToString().Length<4)
	{
            Console.WriteLine("Въвели сте грешно число.");
            Console.WriteLine("Моля въведете четерицифрено число: ");
            number = int.Parse(Console.ReadLine());
	}
	int edinici = number % 10;
	int desetici = (number/10) % 10;
	int stotici = (number/100) % 10;
	int hilqdi=(number/1000) % 10;
	Console.WriteLine("Сбора от цифирите на числото е: " + hilqdi + "+" + stotici + "+" + desetici + "+" +edinici + "=" + ( hilqdi+ stotici+ desetici+ edinici));
	Console.WriteLine("Цифрите в обратен ред са: " + edinici + desetici + stotici + hilqdi);
	Console.WriteLine("Числото с последната цифра на първо място е: " + edinici + hilqdi + stotici + desetici);
	Console.WriteLine("Числото с разменени втора и трета цифра е: " + hilqdi + desetici + stotici + edinici);
```
### Намиране на кой да е бит от произволно число:
```C#
	Console.Write("Моля въведете число: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете позиция на бит: ");
        int p = int.Parse(Console.ReadLine());
        int i = 1;
        int mask=i << (p-1);
        Console.WriteLine((mask & n) != 0 ? 1 : 0);
```
### Замяна на кой да е бит от число с избран от нас бит:
```C#
	Console.Write("Моля въведете число: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете позиция на бит: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете стойност на бит: ");
        int v = int.Parse(Console.ReadLine());
        while(v!=0&&v!=1)
        {
            Console.WriteLine("Въвели сте грешен бит.");
            Console.WriteLine("Въведете нов бит: ");
            v = int.Parse(Console.ReadLine());
        }
        int mask = v == 1 ? (1 << (p-1)) : ~(1 << (p-1));
        int rezultat = v == 1 ? (mask|n) : (mask&n);
        Console.WriteLine("Резултатът е: "+rezultat);
```
### Извеждане на всичко прости числа от 1 до 100 и проверка дали въведено от нас число е просто:
```C#
	Console.Write("Моля въведете число: ");
        int n = int.Parse(Console.ReadLine());
        Boolean nIsPrime = false;
        Console.Write("Простите числа от 1 до 100 са: ");
        for (int i = 2 ; i <= 100 ; i++)  
        {
            Boolean isPrime = true;
            for (int j = 2 ; j <= Math.Sqrt(i) ; j++)
            {
                if (i % j == 0) isPrime = false;
            }
            if (isPrime) Console.Write("{0} ", i);
            if (i == n) nIsPrime = true;
        }
        Console.WriteLine();
        if (nIsPrime) Console.WriteLine("Следователно {0} е просто число.", n);
```
### Размяна на битовете на позиции 3 и 24:
```C#
	Console.Write("Моля въведете число: ");
        int n = int.Parse(Console.ReadLine());
        int mask3 = 1 << 2;
        int bitproverka3 = n & mask3;
        bool dali3e1 = bitproverka3 != 0 ? true : false;
        int mask24 = 1 << 23;
        int bitproverka24 = n & mask24;
        bool dali24e1 = bitproverka24 != 0 ? true : false;
        bool razmqna3i24 = dali3e1 ^ dali24e1 ? true : false;
        if(razmqna3i24)
            {
            int razmqna3 = dali3e1 ? ~mask3 : mask3;
            int n3 = dali3e1 ? razmqna3 & n : razmqna3 | n;
            int razmqna24 = dali24e1 ? ~mask24 : mask24;
            int n3i24 = dali24e1 ? razmqna24 & n3 : razmqna24 | n3;
            Console.WriteLine("Новото число е: " + n3i24);
            }
        else
        {
            Console.WriteLine("Числото е същото като зададеното: " + n);
        }
```
### Размяна на групи от битове в дадено число:
```C#
	Console.Write("Моля въведете число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Двоичното му представяе е: {0}", Convert.ToString(n, 2));
        Console.Write("Моля въведете позиция за начало на първия интервал: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете позиция за начало на втория интервал: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете брой позиции за размяна: ");
        int k = int.Parse(Console.ReadLine());
        int closeMask = 1 << k;
        closeMask = closeMask - 1 << (p - 1) ;
        int closeBitValue = n & closeMask;
        closeBitValue = closeBitValue>> (p - 1);
        int farMask = 1 << k;
        farMask = farMask - 1 << (q - 1);
        int farBitValue = n & farMask;
        farBitValue = farBitValue >> (q - 1);
        n = n & ~closeMask;
        n = n & ~farMask;
        closeBitValue = closeBitValue << (q - 1);
        n = n | (closeBitValue);
        farBitValue = farBitValue << (p - 1);
        n = n | (farBitValue);
        Console.WriteLine("Новото число е: " + n);
        Console.WriteLine("Двоичното му представяе е: {0}", Convert.ToString(n, 2));
```