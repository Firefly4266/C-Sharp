// TestSimpleMath.cs

using System;

public class TestSimpleMath
{
	public static void Main(string[] args)
	{
		int sum = SimpleMath.Add(5, 7);
		int product = SimpleMath.Multiply(5, 7);
		Console.WriteLine("sum = {0}", sum);
		Console.WriteLine("product = {0}", product);
	}
}
