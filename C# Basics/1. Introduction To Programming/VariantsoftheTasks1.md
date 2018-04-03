### Изведете надписа Hello, C#! на конзолата:
```C#
class HelloCSharp
{
	static void Main()
	{
		System.Console.WriteLine("Hello, C#!");
	}
}
```
### По въведена рожденна дата изведете настоящата и възрастта след 10 години:
```C#
	DateTime birthDay;
        while (!DateTime.TryParse(Console.ReadLine(), out birthDay))
        {
            Console.WriteLine("Моля въведете коректна дата: ");
        }
        int difference = (birthDay.DayOfYear > DateTime.Now.DayOfYear) ? (-birthDay.Year - 1) : (-birthDay.Year);
        DateTime age = DateTime.Now.AddYears(difference);
        Console.WriteLine(age.Year);
        Console.WriteLine(age.AddYears(10).Year);
```
### Същото условие в 3 реда:
```C#
	DateTime birthDay = DateTime.Parse(Console.ReadLine());
        TimeSpan difference = DateTime.Now.Subtract(birthDay);
        Console.WriteLine(difference.Days/365);
```
