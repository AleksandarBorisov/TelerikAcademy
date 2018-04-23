## Още няколко интересни варианта на задачите
### Извеждане на най-голямо и най-малко измежду n числа:
```C#
	Console.Write("Моля въведете колко числа ще проверявате: ");
        int n;
        int biggestNumber = int.MinValue;
        int smalestNumber = int.MaxValue;
        bool parseSuccess = Int32.TryParse(Console.ReadLine(), out n);
        while (!parseSuccess)
        {
            Console.Write("Моля въведете коректна бройка: ");
            parseSuccess = Int32.TryParse(Console.ReadLine(), out n);
        }
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Въведете {0} число: ", i);
            int newNumber = int.Parse(Console.ReadLine());
            if (biggestNumber < newNumber)
            {
                biggestNumber = newNumber;
            }
            if (smalestNumber > newNumber)
            {
                smalestNumber = newNumber;
            }
        }
        Console.WriteLine("Най-голямото от {0}-те числа е: {1}, а най-малкото е: {2}.", n, biggestNumber,smalestNumber);
```
### Извеждане на всички карти от едно тесте 52(13 карти от 4 цвята):
```C#
	Console.WriteLine("В едно тесте се съдържат следните карти: ");
            Console.WriteLine();
            for (int i = 5; i >= 2; i--)
            {
                for (int j = 2; j <= 14; j++)
                {
                    if(i == 2)
                    {
                        i = i + 4;
                    }
                    switch (j)
                    {
                        case 11: Console.Write("J" + ((char)i) + " "); break;
                        case 12: Console.Write("Q" + ((char)i) + " "); break;
                        case 13: Console.Write("K" + ((char)i) + " "); break;
                        case 14: Console.Write("A" + ((char)i) + " "); break;
                    }
                    if (j <= 10)
                    {
                        Console.Write(j  + "{0} ", ((char)i));
                    }
                    if (i == 6)
                    {
                        i = i - 4;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
```
### Същото условие направено с друг оператор:
```C#
	string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] colors = { " спатия", " каро", " купа", " пика" };
        foreach(string card in cards)
        {
            foreach(string color in colors)
            {
                Console.Write("{0,3}{1}",card,color);
            }
            Console.WriteLine();
        }
```
### Пограма, която смята N!/K!:
```C#
	Console.Write("Въведете N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Въведете К: ");
        int k = int.Parse(Console.ReadLine());
        int faktorial = 1;
        for (int i = (k + 1); i <= n; i++)
        {
            faktorial *= i;
        }
        Console.WriteLine("Стойността на израза N!/K! e: {0}", faktorial);
```
### Пограма, която смята N!*K!/(N-K)!:
```C#
	Console.Write("Въведете N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Въведете К: ");
        int k = int.Parse(Console.ReadLine());
        long faktorial = 1;
        long multiplier = 1;
        long divisor = 1;
        for (long i = 1; i <= n; i++)
        {
            if ((i >= (n - k + 1)) && (i <= k)) 
            {//Числителя се изменя от N-K+1 до К, защото другото се съкращава
                multiplier *= i;
            }
            if ((i >= (k + 1)) && (i <= (n - k)))
            {//Знаменателя се изменя от K+1 до N-K, защото другото се съкращава
                divisor *= i;
            }
            faktorial *= i;
        }
        Console.WriteLine("Стойността на израза N!*K!/(N-K)! e: " + faktorial/divisor*multiplier);
```
### Извеждане на n-тото число на Каталан:
```C#
	Console.Write("Въведете N: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger catalan = 1;
        BigInteger divisor = 1;
        for (BigInteger i = 1; i <= 2*n; i++)
            {
                if (i>=n+2)
                {
                    catalan *= i;
                }
                if (i<=n)
                {
                    divisor *= i;
                }
            }
        Console.WriteLine("Стойността на {0}-ото число на Каталан e: " + catalan/divisor,n);
```
### Програма, която смята: S=1+1!/x+2!/(x^2)+...+n!/(x^n):
```C#
	Console.Write("Въведете N: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Въведете X: ");
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        double faktorial = 1;
        for (double i = 1; i <= n; i++)
        {
            faktorial *= i;
            sum += faktorial/Math.Pow(x, i);
        }
        Console.WriteLine("Сумата за n={0} и x={1} e: {2}.",n,x,sum);
```
### Задача Matrix Of Numbers решена с два цикъла:
```C#
	Console.Write("Въведете N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= (n + i - 1); j++)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
```
### Odd and Even Product като вариант:
```C#
	int n = int.Parse(Console.ReadLine());
        string numbers = Console.ReadLine() + " ";
        int odd = 1;
        int even = 1;
        int number = 0;
        bool isOdd = true;
        for (int i = 0; i < 2 * n; i++)
        {//2 * n с включените празни места
            if (char.IsWhiteSpace(numbers[i]))
            {
                if (isOdd)
                {
                    odd *= number;
                }
                else
                {
                    even *= number;
                }
                isOdd = !isOdd;
                number = 0;
            }
            else
            {
                number = number * 10 + (numbers[i] - '0');
            }
        }
        Console.WriteLine(even == odd ? "yes " + even : "no " + odd + " " + even);
```
### Odd and Even Product като още един вариант:
```C#
	int n = int.Parse(Console.ReadLine());
        char number = (char)Console.Read();
        int odd = 1;
        int even = 1;
        int result = 0;
        bool isOdd = true;
        do
        {
            if (char.IsWhiteSpace(number))
            {
                if (isOdd)
                {
                    odd *= result;
                }
                else
                {
                    even *= result;
                }
                isOdd = !isOdd;
                result = 0;
            }
            else
            {
                result = result * 10 + (number - '0');
            }
            number = (char)Console.Read();
        } while (number != '\n');
        Console.WriteLine(even == odd ? "yes " + even : "no " + odd + " " + even);
```
### Програма, която пресмята с колко нули завършва факториела на дадено число:
```C#
	Console.Write("Въведете N: ");
        long n = long.Parse(Console.ReadLine());
        long faktorial = 1;
        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            faktorial *= i;
        }
        while (faktorial % 10 == 0)
        {
            faktorial /= 10;
            counter++;
        }
        Console.WriteLine("Броят нули в края на {0}-ия факториел е: {1}", n, counter);
```
### Преобразуване на число от десетична в двоична бройна система:
```C#
	Console.Write("Число в десетична система: ");
        int n = int.Parse(Console.ReadLine());
        string binary = " ";
        int counter = 2;
	if (n==0)
        {
            Console.WriteLine(n);
        }
        else
        {
            for (int i = n; i > 0; i /= 2)
            {
                if (i % 2 != 0)
                {
                    binary = binary.PadLeft(counter,'1');  
                }
                else
                {
                    binary = binary.PadLeft(counter,'0');
                }
                counter++;
            }
            binary = binary.Remove(binary.Length-1);
            Console.WriteLine("Числото в двоична система: " + binary);
	}
```
### Преобразуване на число от двоична в десетична бройна система:
_Първи вариант, при който се достига лимита от време_
```C#
	Console.Write("Число в двоична система: ");
        string number = Console.ReadLine();
        string buffer=null;
        long end = (long) Math.Pow(2, number.Length);
        int move = (number.Length)-1;
        long k;
        for (long i = 0; i < end; i++)
        {
            for (long j = end/2; j >= 1; j /= 2)//Последователно взимаме всеки бит от съответната
            {//позиция отляво надясно (Пример: 1-нулева, 2-първа, 4-втора и т.н.)
                k = i & j;
                k = k >> move;//Местим битовете отляво най-вдясно на нулевата позиция
                if(k==0)
                {
                    buffer += 0;
                }//Проверяваме какъв е съответния бит и записваме
                else
                {
                    buffer += 1;
                }
                move--;//Отиваме на следващата позиция вдясно
            }
            if(number==buffer)
            {//Ако числата съвпаднат сме намерили нашето число
                Console.WriteLine("Числото в десетична е: " + i);
            }
            buffer = null;
            move = (number.Length) - 1;
	}
```
### Преобразуване на число от десетична в шестнайсетична бройна система:
```C#
	Console.Write("Число в десетична система: ");
        int n = int.Parse(Console.ReadLine());
        string hex = " ";
        int counter = 2;
        int value = 0;
        for (int i = n; i > 0; i /= 16)
            {
            value = i % 16;
            switch (value)
            {
                case 10: hex = hex.PadLeft(counter, 'A'); break;
                case 11: hex = hex.PadLeft(counter, 'B'); break;
                case 12: hex = hex.PadLeft(counter, 'C'); break;
                case 13: hex = hex.PadLeft(counter, 'D'); break;
                case 14: hex = hex.PadLeft(counter, 'E'); break;
                case 15: hex = hex.PadLeft(counter, 'F'); break;
                default: hex = hex.PadLeft(counter, Convert.ToChar(value.ToString())); break;
            }
            counter++;
        }
        hex = hex.Remove(hex.Length-1);
        Console.WriteLine("Числото в шестнайсетична система: " + hex);
```
### Преобразуване на число от шестнайсетична в десетична бройна система:
```C#
	Console.Write("Число в шестнайсетична система: ");
        string number = Console.ReadLine();
        double end = number.Length;
        double dec = 1;
        double sum = 0;
        for (double i = 0; i < end; i++)
        {
            char last = number[number.Length - 1];
            switch (last)
            {
                case 'A': dec = 10 * Math.Pow(16, i); break;
                case 'B': dec = 11 * Math.Pow(16, i); break;
                case 'C': dec = 12 * Math.Pow(16, i); break;
                case 'D': dec = 13 * Math.Pow(16, i); break;
                case 'E': dec = 14 * Math.Pow(16, i); break;
                case 'F': dec = 15 * Math.Pow(16, i); break;
                default:
                    int digit = (int)char.GetNumericValue(last);
                    dec = digit* Math.Pow(16, i);
                    break;
            }
            number = number.Remove(number.Length - 1);
            sum += dec;
            }
            Console.WriteLine("Числото в десетична система: " + sum);
```
### Най-голям общ делител на две числа (Алгоритъм на Евклид):
```C#
	int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int remain = a % b;
        while (remain != 0)
        {
            a = b;
            b = remain;
            remain = a % b;
        }
        Console.WriteLine(b);
```
### Най-голям общ делител на две числа (Алгоритъм на Евклид):
_Още един вариант, възможно най-кратък_
```C#
	int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (b != 0)
        {
            var oldB = b;
            b = a % b;
            a = oldB;
        }
        Console.WriteLine(a);
```
### SpiralMatrix(вариант на по-кратко решение):
```C#
	System.Console.SetWindowSize(100, 30);
	int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        int value = 1;
        if (n > 0 && n < 21)
        {
            while (value <= n * n)
            {
                while (col < matrix.GetLength(0) && matrix[col, row] == 0)
                {
                    matrix[row, col++] = value;
                    value++;
                }
                col--;
                row++;
                while (row < matrix.GetLength(1) && matrix[row, col] == 0)
                {
                    matrix[row++, col] = value;
                    value++;
                }
                row--;
                col--;
                while (col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col--] = value;
                    value++;
                }
                col++;
                row--;
                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row--, col] = value;
                    value++;
                }
                col++;
                row++;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * 5, i * 2);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
```
### SpiralMatrix(още един по-кратък вариант):
```C#
	int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int currentNumber = 1;
        int start = 0;
        int ending = n;
        do
        {
            //top side
            for (int i = start; i < ending; i++)
            {
                matrix[start, i] = currentNumber;
                currentNumber++;
            }
            //right side
            for (int i = start + 1; i < ending; i++)
            {
                matrix[i, ending - 1] = currentNumber;
                currentNumber++;
            }
            //bottom side
            for (int i = ending - 2; i >= start; i--)
            {
                matrix[ending - 1, i] = currentNumber;
                currentNumber++;
            }
            //left side
            for (int i = ending - 2; i >= start+1; i--)
            {
                matrix[i, start] = currentNumber;
                currentNumber++;
            }
            start++;
            ending--;
        } while (ending - start > 0);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}",matrix[i, j]);
            }
            Console.WriteLine();
        }
```