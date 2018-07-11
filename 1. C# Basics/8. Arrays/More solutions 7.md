## Още няколко интересни варианта на задачите
### Първа задача с масив:
```C#
	int[] firstArrayEver = new int[20];
        for (int index = 0; index < 20; index++)
        {
            firstArrayEver[index] = 5 * index;
            Console.Write($"{firstArrayEver[index]} ");
        }
        Console.WriteLine();
```
### Сравнение на два масива:
```C#
	Console.Write("Въведете големина на масив A: ");
        int maxIndexA = int.Parse(Console.ReadLine());
        Console.Write("Въведете големина на масив B: ");
        int maxIndexB = int.Parse(Console.ReadLine());
        if (maxIndexA != maxIndexB)
        {
            Console.WriteLine("Двата масива са различни.");
        }
        else
        {
            int[] arrayA = new int[maxIndexA];
            int[] arrayB = new int[maxIndexA];
            bool areEqual = true;
            Console.WriteLine("Въведете елементи за масив А: ");
            for (int index = 0; index < maxIndexA; index++)
            {
                arrayA[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Въведете елементи за масив B: ");
            for (int index = 0; index < maxIndexB; index++)
            {
                arrayB[index] = int.Parse(Console.ReadLine());
                areEqual = arrayA[index] == arrayB[index];
            }
            Console.WriteLine(areEqual ? "Масивите са равни." : "Масивите са различни.");
```
### Selection Sort като вариант:
```C#
	Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }
        int min = int.MaxValue;
        int minIndex = 0;
        int temp = 0;
 
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (arr[j] < min)//Винаги ще се изпълни поне веднъж
                {
                    min = arr[j];
                    minIndex = j;
                }                
            }
            temp = arr[i];
            arr[i] = min;
            arr[minIndex] = temp;
            min = int.MaxValue;
        }
 
        for (int index = 0; index < n; index++)
        {
            Console.Write("{0} ", arr[index]);
        }
```
### Maximal Sum като вариант(+ Какво е Dinamic programming):
>Dynamic programming (also known as dynamic optimization) is a method for solving a complex problem 
>by breaking it down into a collection of simpler subproblems, solving each of those subproblems 
>just once, and storing their solutions. The next time the same subproblem occurs, instead of 
>recomputing its solution, one simply looks up the previously computed solution, thereby saving 
>computation time at the expense of a (hopefully) modest expenditure in storage space. (Each of the 
>subproblem solutions is indexed in some way, typically based on the values of its input parameters, 
>so as to facilitate its lookup.) The technique of storing solutions to subproblems instead of 
>recomputing them is called "memoization".

>A bit of a background: Kadane's algorithm is based on splitting up the set of possible solutions into 
>mutually exclusive (disjoint) sets. We exploit the fact that any solution (i.e., any member of the set 
>of solutions) will always have a last element i (this is what is meant by "sum 
>ending at position i"). Thus, we simply have to examine, one by one, the set of solutions whose last 
>element's index is 1, the set of solutions whose last element's index is 2, then 3, and so forth to n. 
>It turns out that this process can be carried out in linear time. Kadane's algorithm begins with a 
>simple inductive question: if we know the maximum subarray sum ending at position i (call this Bi),
>what is the maximum subarray sum ending at position i + 1 (equivalently, what is Bi + 1)? The answer 
>turns out to be relatively straightforward: either the maximum subarray sum ending at position i + 1 
>includes the maximum subarray sum ending at position i as a prefix, or it doesn't (equivalently, Bi + 1 = 
>max(Ai+1, Ai+1 + Bi), where Ai+1 is the element at index i + 1). Thus, we can compute the maximum 
>subarray sum ending at position i for all positions i by iterating once over the array. As we go, we 
>simply keep track of the maximum sum we've ever seen. 
```C#
	int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int maxSoFar = numbers[0];
        int maxEndingHere = numbers[0];
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 1; i < n; i++)
        {
            maxEndingHere += numbers[i];
            //maxEndingHere = Math.Max(numbers[i], maxEndingHere + numbers[i]);
            if (numbers[i] > maxEndingHere)
            {
                maxEndingHere = numbers[i];
                startIndex = i;
            }
            //maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            if (maxEndingHere > maxSoFar)
            {
                maxSoFar = maxEndingHere;
                endIndex = i;
            }
        }
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine("and the sum is " + maxSoFar);
```
>Note: with a bit of reasoning you will see that max_so_far is equal to max ( B0, B1, B2,..., Bi).
>The algorithm can also be easily modified to keep track of the starting and ending indices of the 
>maximum subarray (when max_so_far changes) as well as the case where we want to allow zero-length 
>subarrays (with implicit sum 0) if all elements are negative.
>Because of the way this algorithm uses optimal substructures (the maximum subarray ending at each 
>position is calculated in a simple way from a related but smaller and overlapping subproblem: the 
>maximum subarray ending at the previous position) this algorithm can be viewed as a simple/trivial 
>example of dynamic programming.

**In short: Kadane`s algorithm can be described as: The maximal sum of a subset is either its last element or the sum of all preceding elements with the last element.**
### Maximal Sum като вариант:
_If we write all possible combinations of numbers in an array, we`ll see that this solution is a typical example of Kadanes algorithm_ 
```C#
	int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxEndHere = array[0];
        int maxSorFor = array[0];
        int end = 0, begin = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (maxEndHere < 0 )
            {
                maxEndHere = array[i];
                begin = i ;
            }
            else
            {
                maxEndHere += array[i];
            }
            if (maxEndHere > maxSorFor)
            {
                maxSorFor = maxEndHere;
                end = i ;
            }
        }
        for (int i = begin; i <= end; i++)
        {
            Console.Write(array[i] + " ");
} 
```
### Maximal Sum като вариант:
_Typical example of Kadanes algorithm_ 
```C#
	int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int sum = 0;
        int maxSum = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
            if (numbers[i] > sum)
            {
                sum = numbers[i];
            }
            maxSum = (sum > maxSum ? sum : maxSum);
        }
        Console.WriteLine(maxSum);
```
### FindSumInArray като вариант:
```C#
	Console.WriteLine("Enter the wanted sum of the subsets:");
        long wantedSum = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of elements:");
        long numberOfElements = long.Parse(Console.ReadLine());
        long[] elements = new long[numberOfElements];
        int counter = 0;
        string subset = "";
        for (int i = 0; i < elements.Length; i++)
        {
            Console.WriteLine("Enter element № {0}", i + 1);
            elements[i] = long.Parse(Console.ReadLine());
        }
        int maxSubsets = (int)Math.Pow(2, numberOfElements) - 1;
        for (int i = 1; i <= maxSubsets; i++)
        {
            subset = "";
            long checkingSum = 0;
            for (int j = 0; j <= numberOfElements; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + elements[j];
                    subset = subset + " " + elements[j];
                }
            }
            if (checkingSum == wantedSum)
            {
                Console.WriteLine("Number of subest that have the sum of {0}", wantedSum);
                counter++;
                Console.WriteLine("This subset has a sum of {0} : {1} ", wantedSum, subset);
            }
        }
	Console.WriteLine(counter);
```
### FindSumInArray като 2 вариант:
```C#
        string input = Console.ReadLine();
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arrayNums = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            arrayNums[i] = int.Parse(inputElements[i]);
        }
        int s = int.Parse(Console.ReadLine());
        // The first loop assigns a starting index
        for (int i = 0; i < arrayNums.Length; i++)
        {
            int sum = 0;
            /* The second loop sums the elements from the starting index to the right 
             * until this partial sum reaches or is greater than S. */
            for (int j = i; j < arrayNums.Length; j++)
            {
                sum = sum + arrayNums[j];                
                if (sum > s)
                {
                    sum = 0;
                    break;
                }
                // If the sum is equal to S, we remember the starting index (from the first loop) and the ending index (from the second loop).
                if (sum == s)
                {
                    for (int index = i; index <= j; index++)
                    {
                        Console.Write(index != j ? arrayNums[index] + ", " : arrayNums[index] + "\n");
                    }
                }
            }
	}
```
### FindSumInArray като 3 вариант:
```C#
	int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int currentSum = 0;
        int counter = 0;
        int sum = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            currentSum += numbers[i];
            if (currentSum >= sum)
            {
                while (currentSum > sum)
                {
                    currentSum -= numbers[counter];
                    counter++;
                }
                if (currentSum==sum)
                {
                    for (int j = counter; j <= i; j++)
                    {
                        Console.WriteLine(numbers[j]);
                    }
                }
            }
        }
```
### Quick Sort simple explanation [link](https://www.youtube.com/watch?v=aQiWF4E8flQ&list=LLTo5TXdsIkS5XgD4lkvae-A&index=1&t=226s) algorithm [link](https://www.programmingalgorithms.com/algorithm/quick-sort-iterative)

### Prime numbers (вариант с листи който е адски бавен):
```C#
	using System.Collections.Generic;
	int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < n - 1; i++)
        {
            numbers.Add(i + 2);
        }
        int startIndex = 0;
        int firstPrime = numbers[startIndex];
        while (firstPrime != numbers[numbers.Count - 1])//Последното винаги ще е просто затова не го проверяваме
        {
            for (int comparison = firstPrime; comparison <= numbers[numbers.Count-1]; comparison+=firstPrime)
            {
                if (comparison!=firstPrime)
                {
                    numbers.Remove(comparison);
                }
            }
            firstPrime = numbers[++startIndex];
        }
        foreach (var prime in numbers)
        {
            Console.WriteLine(prime);
        }
```
### Prime numbers (вариант с три масива, който е адски бавен):
```C#
	int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n - 1];
        for (int i = 0; i < n - 1; i++)
        {
            numbers[i] = i + 2;
        }
        int isPrime = 0;
        while (isPrime != numbers.Length-1) //Последното число винаги ще е просто затова не го проверяваме
        {
            string primes = " ";
            for (int comparison = 0; comparison <= numbers.Length - 1; comparison ++)
            {
                if (comparison <= isPrime || numbers[comparison] % numbers[isPrime] != 0)
                {
                    primes = primes + " " + numbers[comparison];
                }
            }
            primes = primes.Trim(' ');
            string[] numbersAsStrings = primes.Split(' ');
            int[] itarationNumbers = new int[numbersAsStrings.Length];
            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                itarationNumbers[i] = int.Parse(numbersAsStrings[i]);
            }
            numbers = itarationNumbers;
            ++isPrime;
        }
        Console.WriteLine(numbers[numbers.Length-1]);
```
### Prime numbers(вариант с два масива, които заемат адски много памет):
```C#
        long n = long.Parse(Console.ReadLine());
        long[] numbers = new long[n - 1];
        for (long i = 0; i < n - 1; i++)
        {
            numbers[i] = i + 2;
        }
        long startIndex = 0;
        long isPrime = numbers[startIndex];//започваме с първото число
        while (isPrime != numbers[numbers.Length - 1])//Проверяваме дали сме достигнали псоледното число
        {//Последното число винаги ще е просто затова не го проверяваме
            long[] iterationNumbers = new long[numbers.Length];//въвеждаме помощен масив
            long index = 0;//тук ще запишем първото число
            for (long comparison = 0; comparison < numbers.Length; comparison++)
            {//винаги обхождаме целия масив от числа
                if (numbers[comparison] <= isPrime || numbers[comparison] % isPrime != 0)
                //Това ни гарантира че по-малките или равни на настоящото просто
                //число винаги ще се копират, както и тези, които се делят с остатък
                {
                    iterationNumbers[index] = numbers[comparison];//записваме в помощния масив
                    index++;//Пази ни индекса на последния записан елемент
                }
            }
            numbers = new long[index];//дефинираме дадения масив с нова големина
            for (long i = 0; i < index; i++)
            {
                numbers[i] = iterationNumbers[i];//присвояваме му заделените числа
            }
            isPrime = numbers[++startIndex];//взимаме следващото просто число
        }
        //foreach (var prime in numbers)
        //{
        //    Console.WriteLine(prime);
        //}
        Console.WriteLine(numbers[numbers.Length-1]);
```
### Prime numbers(вариант с масив и стринг, които заемат адски много памет):
```C#
	long n = long.Parse(Console.ReadLine());
        string[] numbers = new string[n - 1];
        for (long i = 0; i < n - 1; i++)
        {
            numbers[i] = (i + 2).ToString();
        }
        long startIndex = 0;
        long isPrime = long.Parse(numbers[startIndex]);
        while (isPrime != long.Parse(numbers[numbers.Length - 1]))
        {
            string primes = " ";
            for (long comparison = 0; comparison < numbers.Length; comparison++)
            {
                if (long.Parse(numbers[comparison]) <= isPrime || long.Parse(numbers[comparison]) % isPrime != 0)
                {
                    primes = primes + " " + numbers[comparison];
                }
            }
            primes = primes.Trim(' ');
            numbers = primes.Split(' ');
            isPrime = long.Parse(numbers[++startIndex]);
        }
        foreach (var prime in numbers)
        {
            Console.WriteLine(prime);
        }
```
### Prime numbers(сравнително добро решение):
```C#
	long n = long.Parse(Console.ReadLine());
        bool[] isNotPrime = new bool[n+1];//стойностите на елементите чийто индекси са числата от 2 до n
        for (int i = 2; i < n; i++)//числата от 2 до n ще бъдат индекси в масива от стойности
        {
            if (!isNotPrime[i])//всички булеви стойности имат стойност по подразбиране false
            {
                for (int j = 2; j * i <= n; j++)//това е коефициента по който умножаваме
                {
                    isNotPrime[i * j] = true;//местата където имаме кратни на i се маркират като сложни числа;
                }
            }
        }
        for (long i = n; i >= 0; i--)//въртим ги отзад напред и търсим първото просто
        {
            if (!isNotPrime[i])
            {
                Console.WriteLine(i);
                break;
            }
        }
```
### Subset With Sum S(вариант с побитови операции, който работи до 64 бита):
```C#
	int s = int.Parse(Console.ReadLine());
        string[] line = Console.ReadLine().Split(' ');
        int[] numbers = new int[line.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(line[i]);
        }
        bool sumFound = false;
        for (long combination = 1; combination < Math.Pow(2, numbers.Length); combination++)
        {
            long sum = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                long bit = (combination >> index) & 1;
                sum += numbers[index] * bit;
            }
            if (sum == s)
            {
                sumFound = true;
                break;
            }
        }
        Console.WriteLine(sumFound ? "yes" : "no");
```
### Subset With Sum S(обяснения по метода на динамичното оптимиране тук [link](https://youtu.be/FAL4qqzeHIM?t=4425)):
#### Условие  
| |0|1|2|3|4|5|6|7|8|9|
|-|-|-|-|-|-|-|-|-|-|-|
|**1**|F|T|F|F|F|F|F|F|F|F|
|**2**|F|T|T|T|F|F|F|F|F|F|
|**6**|F|T|T|T|F|F|T|T|T|T| 
 
Всички възможни суми на трите елемента {1, 2, 6} са индексите, на които имаме стойност **`True`** на последния ред от таблицата.

### Remove elements from array(най-кратко решение):
```C#
        int n = int.Parse(Console.ReadLine());
        int[] forSorting = new int[n];
        for (int i = 0; i < n; i++)
        {
            forSorting[i] = int.Parse(Console.ReadLine());
        }
        int[] subsetCount = new int[n];
        for (int i = 0; i < n; i++)
        {
            subsetCount[i] = 1;//задаваме всички да са с дължина 1
        }
        int maxCount = 1;
        for (int rightIndex = 1; rightIndex < n; rightIndex++)
        {
            for (int leftIndex = 0; leftIndex < rightIndex; leftIndex++)
            {
                if (forSorting[leftIndex]<=forSorting[rightIndex]&&
                    subsetCount[rightIndex]<=subsetCount[leftIndex]+1)
		//Винаги ни избира най-дългата последователност от предходните и запазва нея за себе си + 1      
                {
                    subsetCount[rightIndex] = subsetCount[leftIndex] + 1;//в помощния масив на съответната позиция
                    maxCount = Math.Max(maxCount, subsetCount[leftIndex] + 1);//винаги пазим най-голямата дължина за всички позиции
                }
            }
        }
        Console.WriteLine(n - maxCount);
```
### Remove elements from array(използвайки динамично оптимиране, обяснено в лекцията [тук](https://www.youtube.com/watch?v=FAL4qqzeHIM&feature=youtu.be&t=1h13m40s)):
#### Условие
|i|0|1|2|3|4|5|6|7|8|
|:-|:-|:-|:-|:-|:-|:-|:-|:-|:-|
|**Sequence S~i~**|2|4|3|5|1|7|6|9|8|
|**Length L~i~**|1|2|2|3|1|4|4|5|5|
|**Predecessor P~i~**|-1|0|0|2|-1|3|3|6|6|
```C#
	string[] line = Console.ReadLine().Split(' ');
        int[] numbers = new int[line.Length];
        for (int i = 0; i < line.Length; i++)
        {
            numbers[i] = int.Parse(line[i]);
        }
        int[] length = new int[numbers.Length];
        int[] predecessors = new int[numbers.Length];//Пази индексите на предходните елементи
        int bestEnd = 0;
        int maxLength = 0;
        length[0] = 1;
        predecessors[0] = -1;//Предшественика на първия елемент е извън масива
        for (int rightIndex = 1; rightIndex < numbers.Length; rightIndex++)
        {
            length[rightIndex] = 1;//Стойности по подразбиране в случай, че не влезнем нито веднъж в if-а
            predecessors[rightIndex] = -1;
            for (int leftIndex = 0; leftIndex < rightIndex; leftIndex++)
            {
                if (numbers[leftIndex] <= numbers[rightIndex] &&
                    length[leftIndex] + 1 >= length[rightIndex])
                {
                    length[rightIndex] = length[leftIndex] + 1;
                    predecessors[rightIndex] = leftIndex;
                }
            }
            if (length[rightIndex] > maxLength)
            {
                bestEnd = rightIndex;
                maxLength = length[rightIndex];
            }
        }
        int index = bestEnd;
        while (index != -1)
        {
            Console.Write(numbers[index] + " ");//Изписваме елемента, който стои на този индекс
            index = predecessors[index];//Новия индекс е елемента от масив predecessors, който стои на този индекс
        }
```
### Permutations (вариация на countdown):
```C#
	int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] p = new int[n + 1];
        for (int k = 0; k < n; k++)
        {
            a[k] = int.Parse(Console.ReadLine());
            p[k] = k;
        }
        p[n] = n;
        int i = 1;
        int j = 0;
        Console.WriteLine(string.Join(" ", a));
        while (i < n)
        {//При този вариант на метода на Heap когато имаме четен брой елементи (2,4...) разменяме първия с последния,
        //втория с предпоследния и така докато стигнем средата
            p[i]--;
            j = 0;
            do//първия вариант е с j = i % 2 * p[i] вместо този цикъл
            {
                int temp = a[j];
                a[j] = a[i];
                a[i] = temp;
                j++;
                i--;
            } while (j < i);
            i = 1;
            while (p[i] == 0)
            {
                p[i] = i;
                i++;
            }
            Console.WriteLine(string.Join(" ", a));
        }
```
**Теория за Пермутации(Вариации) и Комбинации от тук:**
[link](https://www.mathsisfun.com/combinatorics/combinations-permutations.html)   
**Обяснение какво са Комбинациите от тук:**  [link](https://youtu.be/p8vIcmr_Pqo?list=LLTo5TXdsIkS5XgD4lkvae-A)  
**Теорията за задачата от тук:**
[link](http://permute.tchs.info/ScalablePermutations.html#chap03), 
[link](http://www.quickperm.org/), 
[link](http://mikejfromva.com/2016/10/15/heaps-algorithm/), 
[link](https://stackoverflow.com/questions/31425531/heap-algorithm-for-permutations)  
**Алгоритъм:** [link](http://www.quickperm.org/01example.php)

Обяснение:
>Овновната идея на метода е следната:   
Дръж n-тия елемент докато пренареждаш всички до n-1-вия, после смени n-тия елемент с един от другите и повтори. Ако разменяме четен брой елементи нечетен брой пъти, вземайки винаги първия елемент ни гарантира различна комбинация. Ако обаче разменяме нечетен брой елементи четен брой пъти винаги ще завършваме с елементи в противоположен ред. Следователно ако взимаме винаги първия някой елементи няма да бъдат взети затова трябва да взимаме i+1 всеки път.  
Да обобщим:  
1 когато сме в извадка с четна дължина(2,4 т.н.) разменяме последователно всички елементи с последния като започваме от най-близкия до него и вървим наляво, така накрая получаваме шифтнати надясно с 1 елементи.  
2 когато сме в извадка с нечетна дължина (3,5 т.н.) винаги взимаме първия защото вътрешната пермутация на извадката с четна дължина ни гарантира че той ще бъде различен всеки път.  
В задачата условието очевидно е написано наобратно, в смисъл че ако i e нечетно се изпълнява условието за четна дължина и обратно, това е така защото при четна дължина на елементите, индексите са нечетни (дължина 2, краен индекс 1, дължина 4, краен индекс 3), т. е. на мястото на четната дължина отговаря нечетен индекс.

### Permutations (вариация на counting):
```C#
	int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];//може да се реши и като варианта с countdown от VS с два while цикъла
        int[] p = new int[n];
        for (int k = 0; k < n; k++)
        {
            a[k] = int.Parse(Console.ReadLine());
            p[k] = 0;
        }
        int i = 1;
        int j = 0;
        Console.WriteLine(string.Join(" ", a));
        while (i < n)
        {
            if (p[i] < i)
            {
                if (i % 2 != 0)
                {
                    j = p[i];
                }
                else//може да се замени с j = i % 2 * p[i]
                {
                    j = 0;
                }
                int temp = a[j];
                a[j] = a[i];
                a[i] = temp;
                p[i]++;
                i = 1;
                Console.WriteLine(string.Join(" ", a));
            }
            else//(p[i] == i)
            {
                p[i] = 0;
                i++;
            }
        }
```
### Finding the previous Permutation
>Теорията за намиране на Пермутации е тук [link](https://www.nayuki.io/page/next-lexicographical-permutation-algorithm) [link](https://leetcode.com/articles/next-permutation/)
```C#
	int n = int.Parse(Console.ReadLine());
        string[] inputPermutation = Console.ReadLine().Split(' ');
        int[] a = new int[inputPermutation.Length];
        for (int k = 0; k < a.Length; k++)
        {
            a[k] = int.Parse(inputPermutation[k]);
        }
        int i = n - 1;//Намираме най-дългата ненамаляща подредица
        while (i > 0 && a[i - 1] <= a[i])
        {
            i--;
        }
        if (i <= 0)
        {
            Console.WriteLine("This is the first permutation.");
            return;
        }
        int j = n - 1;//Намираме най-десния елемент, по-малък от pivot-a(позиция i-1)
        while (a[i - 1] <= a[j])//В случая суфикса все още е ненамаляваща редица
        {
            j--;
        }
        int swap = a[i - 1];
        a[i - 1] = a[j];
        a[j] = swap;
        j = n - 1;
        while (i < j)
        {//Обръщаме реда на елементите в суфикса
            swap = a[i];
            a[i] = a[j];
            a[j] = swap;
            i++;
            j--;
        }
        Console.WriteLine(String.Join(" ",a));
```
### Combinations of set
_Алгоритъм за намиране на броя битове, които са единица в дадено число [here](https://prismoskills.appspot.com/lessons/Bitwise_Operators/Count_ones_in_an_integer.jsp)_
### Как да четем научна литература:
>Let me give you some advice about reading papers. If you find some detail you don't understand, often you can keep 
>reading and see if you can still understand what is going on. Sometimes there will be a typo in the paper that is 
>small or inconsequential. Sometimes it's a detail but if you keep reading you can still understand much of the rest 
>of the paper. Sometimes the paper is actually correct and once you absorb the rest of the ideas in the paper, when
> you go back and re-read the paper you'll realize what the authors actually meant. (Of course, occasionally you'll 
>discover a serious fundamental flaw in the paper. But don't jump to assuming that's the case; that should be your 
>last hypothesis, rather than your first hypothesis.) If you still can't understand the paper, try to find other 
>papers that cover related topics -- e.g., that it cite or that cite it -- and build up your understanding of the area. 
>Then, come back and read the paper again.
>Often, if you follow these strategies, you'll be able to work out what is going on. These are useful skills -- 
>they will make you more self-reliant and more effective at getting value out of the research literature.			