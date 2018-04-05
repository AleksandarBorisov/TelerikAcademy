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
            {
                multiplier *= i;
            }
            if ((i >= (k + 1)) && (i <= (n - k)))
            {
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
### Задача с нещо като магически квадрати:
```C#
	Console.Write("Въведете N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= (n+i-1); j++)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
```
### Същото условие, решено с един цикъл:
```C#
	Console.Write("Въведете N: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; (i <= n + counter) && (counter < n); i++)
        {
            if (i == (n+counter))
            {
                Console.WriteLine(i+" ");
                counter++;
                i = counter;
            }
            else
            {
                Console.Write(i+" ");
            }
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
```C#
	Console.Write("Число в двоична система: ");
        string number = Console.ReadLine();
        string buffer=null;
        int end = (int) Math.Pow(2, number.Length);
        int move = (number.Length)-1;
        int k;
        for (int i = 1; i <= end; i++)
        {
            for (int j = end/2; j >= 1; j /= 2)//Взимаме битовете от всяка позиция поотделно
            {
                k = i & j;
                k = k >> move;
                if(k==0)
                {
                    buffer += 0;
                }
                else
                {
                    buffer += 1;
                }
                move--;
            }
            if(number==buffer)
            {
                Console.WriteLine("Числото в десетична е: " + i);
            }
            buffer = null;
            move = (number.Length) - 1;
	}
```
### Същото усовие, друг начин на решение(в ПЪТИ по бърз):
```C#
	string number = Console.ReadLine();
        int sum = 0;
        int power = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '1')
            {
                power = number.Length - 1 - i;
                sum += (int)Math.Pow(2, power);
            }
        }
        Console.WriteLine(sum);
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
### Същото усовие, друг начин на решение(в ПЪТИ по бърз):
```C#
	string number = Console.ReadLine();
        long dec = 0;
        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case 'A': dec += 10 * (long)Math.Pow(16, number.Length - i - 1); break;
                case 'B': dec += 11 * (long)Math.Pow(16, number.Length - i - 1); break;
                case 'C': dec += 12 * (long)Math.Pow(16, number.Length - i - 1); break;
                case 'D': dec += 13 * (long)Math.Pow(16, number.Length - i - 1); break;
                case 'E': dec += 14 * (long)Math.Pow(16, number.Length - i - 1); break;
                case 'F': dec += 15 * (long)Math.Pow(16, number.Length - i - 1); break;
                default: dec += (int)char.GetNumericValue(number[i]) * (long)Math.Pow(16, number.Length - i - 1); break;
            }
        }
        Console.WriteLine(dec);
        Console.WriteLine();
```
### Най-голям общ делител на две числа (Алгоритъм на Евклид):
```C#
	Console.Write("Въведете число A: ");
        int? a = int.Parse(Console.ReadLine());
        Console.Write("Въведете число B: ");
        int? b = int.Parse(Console.ReadLine());
        while((a!=b)&&(a>0)&&(b>0))
        {
            if(a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        Console.WriteLine("Най-големият общ делител на числата е: {0}", (a ?? b));
```
### Най-голям общ делител на две числа (Алгоритъм на Евклид 2 вариант):
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
### SpiralMatrix:
```C#
	int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        int row = 0;
        int col = 0;
        int endIndex = ((n % 2 == 0) ? (n / 2 - 1) : (n / 2));
        //Индекса се определя от броя вписани квадрати във външния
        //Оркрих зависимостта:  (n)1 2 3 4 5 6 7 8...
        //       (вписани квадрати)0 0 1 1 2 2 3 3...
        for (int index = 0; index <= endIndex; index++)
        {
            while (col + index < n - index)
            {
                matrix[row + index, col + index] = counter;
                counter++;
                col++;
            }
            col--;
            counter--;
            while (row + index < n - index)//Само фиксира колко пъти да се изпълни(може да се запипе и row<n-2*index)
            {
                matrix[row + index, col + index] = counter;//фиксира откъде да започне да се изпълнява(винаги по главния диагонал)
                counter++;
                row++;
            }
            row--;
            counter--;
            while (col >= 0)
            {
                matrix[row + index, col + index] = counter;
                counter++;
                col--;
            }
            col++;
            counter--;
            while (row > 0)
            {
                matrix[row + index, col + index] = counter;
                counter++;
                row--;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(" " + matrix[i, j]);
            }
       	    Console.WriteLine();
        }
```
### SpiralMatrix(по кратко решение от един пичага):
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
### SpiralMatrix(решение от още един пичага):
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