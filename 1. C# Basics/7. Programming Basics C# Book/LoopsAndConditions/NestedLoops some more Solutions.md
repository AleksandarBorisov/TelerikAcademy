Разпределяне на числа в даден диапазон по проценти:
	Console.Write("Въведете брой числа: ");
        int n = int.Parse(Console.ReadLine());
        double percentage1 = 0;
        double percentage2 = 0;
        double percentage3 = 0;
        double percentage4 = 0;
        double percentage5 = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Моля въведете {0} число: ", i);
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber < 200)
            {
                percentage1++;
            }
            else if ((currentNumber >= 200) && (currentNumber < 400))
            {
                percentage2++;
            }
            else if ((currentNumber >= 400) && (currentNumber < 600))
            {
                percentage3++;
            }
            else if ((currentNumber >= 600) && (currentNumber < 800))
            {
                percentage4++;
            }
            else if (currentNumber >= 800)
            {
                percentage5++;
            }
        }
        Console.WriteLine("{0:P}", percentage1/n);
        Console.WriteLine("{0:P}", percentage2/n);
        Console.WriteLine("{0:P}", percentage3/n);
        Console.WriteLine("{0:P}", percentage4/n);
        Console.WriteLine("{0:P}", percentage5/n);
Задача за умната Лили:
	//Console.Write("Въведете годините на Лили: ");
        int years = int.Parse(Console.ReadLine());
        int giftMoney = 0;
        int giftToys = 0;
        int bonus = 1;
        for (int i = 1; i <= years; i++)
        {
            if(i%2!=0)
            {
                giftToys++;
            }
            else
            {
                giftMoney += bonus * 10;
                bonus++;
                giftMoney--;
            }
        }
	//Console.Write("Моля въведете цена на пералня машина: ");
        double price = double.Parse(Console.ReadLine());
        //Console.Write("Въведете цена на една играчка: ");
        int p = int.Parse(Console.ReadLine());
        int giftToysMoney = p * giftToys;
        Console.WriteLine("Лили е спестила {0} лева, ", (giftMoney + giftToysMoney)); 
        Console.WriteLine((giftMoney + giftToysMoney) >= price ? $"което е достатъчно с излишък {((giftMoney + giftToysMoney) - price):0.##} лева." : $"което не е достатъчно с недостиг {(price-(giftMoney + giftToysMoney)):0.##} лева.");
Завръщане в миналото(до коя година ще му стигне наследството):
	Console.Write("Въведете колко е наследството на Иванчо: ");
        int inheritance = int.Parse(Console.ReadLine());
        Console.Write("Въведете въпросна година: ");
        int finalYear = int.Parse(Console.ReadLine());
        int age = 18;
        int startingYear = 1800;
        int expense = 0;
        int inheritanceLeft = 0;
        while (inheritance > 0) 
        {
            expense=(startingYear % 2 == 0) ? 12000 : 12000 + 50 * age;
            inheritance -= expense;
            if (finalYear == startingYear)
            {
                inheritanceLeft = inheritance;
            }
            age++;
            startingYear++;
        }
        Console.WriteLine($"Иванчо няма да работи до {age - 1} години или до {startingYear - 1}-а година.");
Завръщане в миналото(дали до определена година ще има излишък или недостиг):
 	Console.Write("Въведете колко е наследството на Иванчо: ");
        double inheritance = double.Parse(Console.ReadLine());
        Console.Write("Въведете въпросна година: ");
        int finalYear = int.Parse(Console.ReadLine());
        int age = 18;
        int expense = 0;
        for (int startingYear = 1800; startingYear <= finalYear; startingYear++) 
        {
            expense=(startingYear % 2 == 0) ? 12000 : 12000 + 50 * age;
            inheritance -= expense;
            age++;
        }
        Console.WriteLine(inheritance>=0 ? $"Yes! He will live a carefree life and will have {inheritance:0.00} dollars left." :
        $"He will need {(inheritance*-1):0.00} dollars to survive.");
Болница:
	//Console.Write("Въведете период за проверка: ");
        int lastDay = int.Parse(Console.ReadLine());
        int patients = 0;
        int doctors = 7;
        int treatedPatients = 0;
        int unTreatedPatients = 0;
        for (int currentDay = 1; currentDay <= lastDay; currentDay++)
        {
             if ((currentDay % 3 == 0) && (unTreatedPatients > treatedPatients))
             {
                doctors++;
             }
             //Console.Write($"Брой пациенти за {currentDay}-ия ден: ");
             patients = int.Parse(Console.ReadLine());
             if (patients > doctors)
             {
                unTreatedPatients += patients - doctors;
                treatedPatients += doctors;
             }
             else
             {
                treatedPatients += patients;
             }
         }
         Console.WriteLine($"For the last {lastDay} days we have\nTreated patients: {treatedPatients}.\nUntreated patients: {unTreatedPatients}.");
Деление без остатък на 2,3,4:
	//Console.Write("Въведете брой цели числа за проверка: ");
        int n = int.Parse(Console.ReadLine());
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        for (int i = 1; i <= n; i++)
        {
            //Console.Write($"Въведете {i}-о число: ");
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber % 2 == 0) 
            {
                p2++;
            }
            if (currentNumber % 3 == 0)
            {
                p3++;
            }
            if (currentNumber % 4 == 0)
            {
                p4++;
            }
        }
        Console.WriteLine($"Делящи без остатък на 2: {p2 / n:P}");
        Console.WriteLine($"Делящи без остатък на 3: {p3 / n:P}");
        Console.WriteLine($"Делящи без остатък на 4: {p4 / n:P}");
Логистика:
	Console.Write("Колко товара ще превозвате: ");
        int count = int.Parse(Console.ReadLine());
        double cargoBus = 0;
        double cargoTruck = 0;
        double cargoTrain = 0;
        double load = 0;
        for(int i = 1; i <= count; i++)
        {
            Console.Write("Въведете тонаж на товара: ");
            int cargo = int.Parse(Console.ReadLine());
            if (cargo <= 3) 
            {
                cargoBus += cargo;
            }
            else if (cargo > 3 && cargo <= 11)
            {
                cargoTruck += cargo;
            }
            else
            {
                cargoTrain += cargo;
            }
            load += cargo;
        }
        Console.WriteLine($"Средната цена на тон е: {(cargoBus * 200 + cargoTruck * 175 + cargoTrain * 120) / load:F2}");
        Console.WriteLine($"{cargoBus / load:P} от товара се превозва с микробус.");
        Console.WriteLine($"{cargoTruck / load:P} от товара се превозва с камион.");
        Console.WriteLine($"{cargoTrain / load:P} от товара се превозва с влак.");