using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("unesite stranicu x:\n");
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine("unesite stranicu y:\n");
		int y = int.Parse(Console.ReadLine());
		Console.WriteLine("unesite stranicu z:\n");
		int z = int.Parse(Console.ReadLine());
		if (x > 0 && y > 0 && z > 0)
		{
			if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
			{
				Console.WriteLine("stranice koje su unesene prikazuju pravokutni trokut.");
			}
			else
			{
				Console.WriteLine("stranice koje su unesene ne prikazuju pravokutni trokut.");
			}
		}
	}
}