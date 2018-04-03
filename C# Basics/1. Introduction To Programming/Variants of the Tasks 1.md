### �������� ������� Hello, C#! �� ���������:
```C#
class HelloCSharp
{
	static void Main()
	{
		System.Console.WriteLine("Hello, C#!");
	}
}
```
### �� �������� �������� ���� �������� ���������� � ��������� ���� 10 ������:
```C#
	DateTime birthDay;
        while (!DateTime.TryParse(Console.ReadLine(), out birthDay))
        {
            Console.WriteLine("���� �������� �������� ����: ");
        }
        int difference = (birthDay.DayOfYear > DateTime.Now.DayOfYear) ? (-birthDay.Year - 1) : (-birthDay.Year);
        DateTime age = DateTime.Now.AddYears(difference);
        Console.WriteLine(age.Year);
        Console.WriteLine(age.AddYears(10).Year);
```
### ������ ������� � 3 ����:
```C#
	DateTime birthDay = DateTime.Parse(Console.ReadLine());
        TimeSpan difference = DateTime.Now.Subtract(birthDay);
        Console.WriteLine(difference.Days/365);
```
