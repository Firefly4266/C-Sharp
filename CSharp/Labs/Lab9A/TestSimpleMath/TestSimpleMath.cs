// TestSimpleMath.cs

using System;

public class TestSimpleMath
{
	public static void Main(string[] args)
	{
		int sum = SimpleMath.Add(5, 7);
		int product = SimpleMath.Multiply(5, 7);
        int subtract = SimpleMath.Subtract(7, 5);
        int divide = SimpleMath.Divide(25, 5);
		Console.WriteLine("sum = {0}", sum);
		Console.WriteLine("product = {0}", product);
        Console.WriteLine("subtract = {0}", subtract);
        Console.WriteLine("divide = {0}", divide);

        double dsum = SimpleMath.Add(5, 7);
        double dproduct = SimpleMath.Multiply(5, 7);
        double dsubtract = SimpleMath.Subtract(7, 5);
        double ddivide = SimpleMath.Divide(25, 5);
        Console.WriteLine("dsum = {0}", dsum);
        Console.WriteLine("dproduct = {0}", dproduct);
        Console.WriteLine("dsubtract = {0}", dsubtract);
        Console.WriteLine("ddivide = {0}", ddivide);
    }
}
