##
### Въвеждане на данни за фирма:
```C#
	Console.Write("Въведете име на фирмата: ");
        string fName = Console.ReadLine();
        Console.Write("Въведете адрес на фирмата: ");
        string fAdress = Console.ReadLine();
        Console.Write("Въведете телефонен номер на фирмата: ");
        int fNumber = int.Parse(Console.ReadLine());
        Console.Write("Въведете факс на фирмата: ");
        int fFax = int.Parse(Console.ReadLine());
        Console.Write("Въведете сайт на фирмата: ");
        string fSite = Console.ReadLine();
        Console.Write("Въведете първо име на мениджъра: ");
        string mFirstName = Console.ReadLine();
        Console.Write("Въведете фамилия на мениджъра: ");
        string mSurName = Console.ReadLine();
        Console.Write("Въведете телефон на мениджъра: ");
        int mNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Фирма \"{1}\", с координати: {0}", Environment.NewLine, fName);
        Console.Write("адр. {1}, тел. {2}, факс {3},{0}", Environment.NewLine, fAdress, fNumber, fFax);
        Console.Write("която можете на намерите на страница: {1}{0}", Environment.NewLine, fSite);
        Console.Write("е с мениджър: {1} {2}," + " тел. {3}{0}", Environment.NewLine, mFirstName, mSurName, mNumber);
        Console.WriteLine();
```
### Печатане в шестнайсетична бройна система, с подравняване и прецизност:
```C#
	Console.Write("Въведете цяло положително число: ");
        int fNumber = int.Parse(Console.ReadLine());
        Console.Write("Въведете дробно положително число: ");
        double sNumber = double.Parse(Console.ReadLine());
        Console.Write("Въведете дробно отрицателно число: ");
        double tNumber = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("{0,-10:X}", fNumber);
        Console.Write("{0,-10:F2}", sNumber);
        Console.Write("{0,-10:F2}", tNumber);
```
### Колко на брой числа в даден интервал се делят на 5:
```C#
	Console.Write("Въведете начало на интервала: ");
        int fNumber = int.Parse(Console.ReadLine());
        Console.Write("Въведете край на интервала: ");
        int sNumber = int.Parse(Console.ReadLine());
        int rezultat;
        if(fNumber%10==0)
        {
            rezultat = ((sNumber - fNumber) / 5) + 1;
        }
        else
        {
            rezultat = ((sNumber - fNumber) / 5);
        } 
        Console.WriteLine("Броя на числата, които се делят на 5 в интервала е: " + rezultat);
```
### Въвеждане на n числа с проверка за валидност на всяко(направено с while и for цикъл):
```C#
	Console.Write("Въведете колко числа ще сумирате: ");
        int n;
        bool parseSuccessN = Int32.TryParse(Console.ReadLine(), out n);
        while(!parseSuccessN)
        {
            Console.Write("Въвели сте грешен брой, моля въведете отново: ");
            parseSuccessN = Int32.TryParse(Console.ReadLine(), out n);
        }
        double sum = 0;
        for(int i = 1 ; i <= n ; i++)
        {
            Console.Write("Въведете {0} число: ",i);
            string readNumber = Console.ReadLine();
            int rNumber;
            bool parseSuccess = Int32.TryParse(readNumber, out rNumber);
            while (!parseSuccess)
            {
                Console.Write("Въвели сте грешно число, моля въведете отново: ");
                readNumber = Console.ReadLine();
                parseSuccess = Int32.TryParse(readNumber, out rNumber);
            }
            sum += rNumber;
        }
        Console.WriteLine("Сумата от числата е: {0}", sum);
```
### Въвеждане на коефициентите на квадратно уравнение и решението му със всички проверки:
```C#
	Console.OutputEncoding = System.Text.Encoding.UTF8;//+Форматираме конзолата в Lucida Console
        Console.WriteLine("Решаваме уравнение от вида a.x\u00B2+b.x+c=0");
        Console.Write("Въведете коефициент а: ");
        int a;
        bool parseSuccessA = Int32.TryParse(Console.ReadLine(), out a);
        while (!parseSuccessA)
        {
            Console.Write("Въвели сте грешно число, моля въведете отново: ");
            parseSuccessA = Int32.TryParse(Console.ReadLine(), out a);
        }
        Console.Write("Въведете коефициент b: ");
        int b;
        bool parseSuccessB = Int32.TryParse(Console.ReadLine(), out b);
        while (!parseSuccessB)
        {
            Console.Write("Въвели сте грешно число, моля въведете отново: ");
            parseSuccessB = Int32.TryParse(Console.ReadLine(), out b);
        }
        Console.Write("Въведете коефициент c: ");
        int c;
        bool parseSuccessC = Int32.TryParse(Console.ReadLine(), out c);
        while (!parseSuccessC)
        {
            Console.Write("Въвели сте грешно число, моля въведете отново: ");
            parseSuccessC = Int32.TryParse(Console.ReadLine(), out c);
        }
        double D = b * b - 4 *(a * c);
        if (D < 0)
        {
            Console.WriteLine("Уравнението няма реални корени!");
        }
        if (D == 0)
        {
            double x = (-b) / (2 * a);
            char signa = (a > 0 ? '+' : ((a < 0) ? '-' : '+'));
            char signb = (b > 0 ? '+' : ((b < 0) ? '-' : '+'));
            char signc = (c > 0 ? '+' : ((c < 0) ? '-' : '+'));
            Console.WriteLine("Коренът на уравнението {1}{2}.x\u00B2{3}{4}.x{5}{6}=0 е: {0:0.##}", x, signa, Math.Abs(a), signb, Math.Abs(b), signc, Math.Abs(c));
        }
        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            char signa = (a > 0 ? '+' : ((a < 0) ? '-' : '+'));
            char signb = (b > 0 ? '+' : ((b < 0) ? '-' : '+'));
            char signc = (c > 0 ? '+' : ((c < 0) ? '-' : '+'));
            Console.WriteLine("Коренът на уравнението {2}{3}.x\u00B2{4}{5}.x{6}{7}=0 са: {0:0.##} и {1:0.##}", x1, x2,signa,Math.Abs(a),signb,Math.Abs(b),signc,Math.Abs(c));
        }
```
### Извеждане на първите 100 члена от редицата на Фибоначи:
```C#
	Console.Write("Първите 100 члена от редицата на фибоначи са: ");
        long a = 1;
        long b = 0;
        for (int i = 1; i <= 100; i++)
        {
            Console.Write("{0}, ", b);
            b = a + b;
            a = b - a;
        }
### Събиране на числата 1+1/2-1/3+1/4... докато разликата между два члена стане по-малка от 0.001:
```C#
	float a=0;
        float b=2;
        int counter = 0;
        float sum = 1;
        float prev = 0;
        while(Math.Abs(sum-prev)>0.001)
        {
            a = 1 /( b);
            prev = sum;
            if (b % 2 != 0)
            {
                sum -= a;
            }
            if (b % 2 == 0)
            {
                sum += a;
            }
            b++;
            counter++;
        }
        Console.WriteLine("На {0}-ия член сумата достигна търсената точност и е: {1:F3}", counter, sum);
```