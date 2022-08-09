using System;

class GreaterOfTwoNumbers
{
	static void Main(String [] args)
	{
		Console.Write ("Enter the first number: ");
		int a = Int32.Parse (Console.ReadLine());
		
		Console.Write ("Enter second Number: ");
		int b = Int32.Parse (Console.ReadLine());
		
		int max = (a > b) ? a : b;
		
		Console.Write("The greater number is ");
		Console.WriteLine(max);
		Console.ReadKey();
	}
}