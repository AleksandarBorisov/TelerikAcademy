namespace SumOfElements
{

		class Program
	{

			static void Main()
		{

			string arguments = System.Console.ReadLine();

			string[] divided = arguments.Split(' ');

			int sum=0;

			for(int i = 0; i < divided.Length; i++)
			{
			int number = int.Parse(divided[i]);
			sum += number;
			}

			System.Console.WriteLine(sum);

		}
	}
}